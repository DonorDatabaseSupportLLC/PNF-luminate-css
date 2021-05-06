SELECT Jobid
       , EmailName
       , DateSend
       , sum(clicks)                  	AS Clicked
       , sum(formstack)      			AS formStackClick
       , sum(opens)          			AS Opened
       , sum(Bounces)        			AS HardBounce
       , sum(unsubscribes)   			AS Unsubscribed
       , count(distinct SubscriberKey) 	AS TotalSent
FROM(SELECT s.SubscriberKey
            , s.jobid 
            , j.EmailName  
            --, convert(date, j.DeliveredTime) AS DateSend
			,  j.DeliveredTime 									  AS DateSend
            , CASE WHEN c.EventDate IS NOT NULL THEN 1 ELSE 0 END AS clicks
            , CASE WHEN o.EventDate IS NOT NULL THEN 1 ELSE 0 END AS opens
            , CASE WHEN b.EventDate IS NOT NULL THEN 1 ELSE 0 END AS Bounces
            , CASE WHEN u.EventDate IS NOT NULL THEN 1 ELSE 0 END AS unsubscribes
            , CASE WHEN d.EventDate IS NOT NULL THEN 1 ELSE 0 END AS formstack
            , row_number()over(partition BY s.SubscriberKey ORDER BY s.SubscriberKey) rnk 
       FROM _sent s 
       JOIN _job j              ON j.jobid = s.jobid 
       LEFT JOIN _click c       ON c.SubscriberKey = s.SubscriberKey 
                               AND c.jobid = s.jobid 
                               AND c.ListID  = s.ListID 
                               AND c.BatchID = s.BatchID 
                               AND c.IsUnique = '1' 
       LEFT JOIN _open o        ON o.SubscriberKey = s.SubscriberKey 
                               AND o.jobid = s.jobid 
                               AND o.ListID = s.ListID
                               AND o.BatchID  = s.BatchID 
                               AND o.IsUnique = '1'
       LEFT JOIN _bounce b      ON b.SubscriberKey = s.SubscriberKey  
                               AND b.jobid   = s.jobid 
                               AND b.ListID  = s.ListID
                               AND b.BatchID = s.BatchID
                               AND LOWER(b.bounceCategory) = 'hard bounce' 
                               AND b.IsUnique = '1'
       LEFT JOIN _unsubscribe u ON u.SubscriberKey = s.SubscriberKey
                               AND u.jobid = s.jobid 
                               AND u.ListID = s.ListID 
                               AND u.BatchID = s.BatchID 
                               AND u.IsUnique = '1'  
      LEFT JOIN _click d        ON d.SubscriberKey = s.SubscriberKey 
                               AND d.jobid = s.jobid 
                               AND d.ListID  = s.ListID 
                               AND d.BatchID = s.BatchID 
                               AND LOWER(d.URL) like '%formstack%'
                               AND d.IsUnique = '1' 
)w 
WHERE rnk = 1 
GROUP BY Jobid, EmailName, DateSend
