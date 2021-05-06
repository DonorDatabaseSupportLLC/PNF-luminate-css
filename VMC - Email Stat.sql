SELECT Jobid
       , EmailName
       , DateSend
       , sum(clicks)  AS Clicked
       , sum(opens)   AS Opened
       , sum(Bounces) AS HardBounce
       , sum(clicks)  AS Unsubscribed
       , count(distinct SubscriberKey) AS TotalSent
FROM(SELECT s.SubscriberKey
            , J.jobid 
            , j.EmailName  
            , s.EventDate AS DateSend
            , CASE WHEN c.EventDate IS NOT NULL THEN 1 ELSE 0 END AS clicks
            , CASE WHEN o.EventDate IS NOT NULL THEN 1 ELSE 0 END AS opens
            , CASE WHEN b.EventDate IS NOT NULL THEN 1 ELSE 0 END AS Bounces
            , CASE WHEN u.EventDate IS NOT NULL THEN 1 ELSE 0 END AS unsubscribes
       FROM _sent s 
       JOIN _job j          ON j.jobid = s.jobid 
       LEFT JOIN _click c   ON c.SubscriberKey = s.SubscriberKey 
                           AND c.jobid = s.jobid AND c.ListID = s.ListID
                           AND c.BatchID = s.BatchID 
                           AND c.ListID  = s.ListID
                           AND c.IsUnique ='1' 
                           
       LEFT JOIN _open o    ON o.SubscriberKey = s.SubscriberKey 
                           AND o.jobid = s.jobid 
                           AND o.ListID = s.ListID
                           AND o.BatchID = s.BatchID 
                           AND o.ListID  = s.ListID
                           AND o.IsUnique ='1'
                           
       LEFT JOIN _bounce b  ON b.SubscriberKey = s.SubscriberKey 
                           AND b.jobid = s.jobid 
                           AND b.ListID = s.ListID
                           AND b.BatchID = s.BatchID 
                           AND b.ListID  = s.ListID
                           AND LOWER(b.bounceCategory) = 'hard bounce'
                           AND b.IsUnique ='1'
       LEFT JOIN _unsubscribe u ON u.SubscriberKey = s.SubscriberKey 
                               AND u.jobid = s.jobid 
                               AND u.ListID = s.ListID
                               AND u.BatchID = s.BatchID 
                               AND u.ListID  = s.ListID
                               AND u.IsUnique ='1'   
      WHERE j.jobid = 9585590    
     

)w 
WHERE 1=1 
GROUP BY Jobid, EmailName, DateSend
