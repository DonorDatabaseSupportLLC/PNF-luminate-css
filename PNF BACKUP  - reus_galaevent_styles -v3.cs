<style type="text/css"><!--
/* V2.0*/

body {
color:#4d525a;
background:#fff url('../teamraiser-themes/theme1/images/bg-pattern-cross.png');
}
body, p, table, tr, th, td, .Explicit {
font-family: Myriad Pro, sans-serif;
}
a, div.indicator-container a.indicator-link {
color:#9e91c6;
}
a.btn-more {
color:#888;
}
a.btn-more:hover {
text-decoration:none;
}
h2 .btn-more {
float:right;
}
@media (max-width: 767px) {
.hidden-xs.in,
.hidden-xs.collapsing {
display:block !important;
}
}
@media (min-width: 768px) {
form.hidden-xs {
height:auto !important;
}
}
#header {
/******* 10/21/18. Abdi Jibril, DDS,LLC removed ***********/
/*
background:#ffffff url('../teamraiser-themes/theme1/images/bg-pattern-diagonal.png');
*/
background: #9e91c6;  /**** 10/21/18. NEW. Abdi Jibril, DDS,LLC Added ****/
}
#header .row {
margin:0;
border:0;
}
#header [class*="col-"] {
padding:0;
}
#header .row > div:last-child {
float:right;
}
#header .navbar {
min-height:0;
}
#header-nav {
padding:0;
}
#header .navbar-header {
position:absolute;
height:100%;
}
#header .navbar-toggle {
margin-right:0;
}
#header .navbar-toggle .icon-bar {
background:#444;
}
@media (max-width: 767px) {
#header .navbar-header {
position:relative;
border-bottom:4px solid #f0b323;
background:#fff;
}
#header .row > div:last-child {
min-height:0;
}
#header .container {
padding:0;
}
#header .navbar-nav {
margin:0;
}
#header .navbar-collapse {
max-height:100%;
padding:0;
}
}
#logo {
	background:#fff;
	border-bottom:2px solid  #4d525a;  /* #f0b323  *** 10/21/208  Abdi Jibri, DDS, LLC Changed */;
	padding:20px;
	margin-bottom:-20px;
	margin-top:0;
	position:relative;
	z-index:999;
	height:90%; /**** 110% *** 10/21/208  Abdi Jibri, DDS, LLC Changed - Fix Logo header to fit  ****/
	overflow:hidden;
}
#logo a,
#logo p {
display:block;
position:relative;
width:100%;
height:100%;
}
#logo img {
position:absolute;
bottom:0;
left:0;
right:0;
top:0;
margin:auto 0;
max-width:100%;
display:block;
}
@media (max-width: 767px) {
#logo {
padding:6px 10px;
margin:0;
float:left;
height:54px;
border-bottom:0;
position:static;
}
#logo a {
}
#logo img {
position:static;
width:auto;
height:100%;
}
}
.page-home #logo {
margin-left:10px;
}
@media (max-width: 991px) {
.page-home #logo {
margin-left:0;
}
}

#utility {
margin:0;
}
#utility .navbar-nav a {
padding:3px 8px;
margin:12px 0 12px 5px;
color:#ffffff;
}
#utility .navbar-nav a:hover {
background-color:transparent;
text-decoration:underline;
}
#utility a.button,
#utility button.button,
#utility .btn {
color:#fff;
font-size:11px;
text-transform:uppercase;
}

/* 10/21/18. New. DDS,LLC added. Login button Mouse hover snippet  */
.btn-success#button:hover {
  background: #1f9d55;
  border-color: #1f9d55;
  border-radius: 5px;
}

#utility .navbar-nav a.btn-success:hover {
background-color:#ffffff;
text-decoration:none;
}
#utility .navbar-form {
padding:5px 15px 4px;
}
#utility .form-group {
text-align:right;
width:100px;
}
#utility .form-group .form-control {
font-size:12px;
height:30px;
border:0;
box-shadow:none;
background:#fff;
border:1px solid #ccc;
padding-left:10px;
width:100%;
}
@media (max-width: 767px) {
#utility {
padding:10px;
}
#utility .form-group {
width:100%;
}
#utility .navbar-form {
margin:0 0 10px;
padding:0;
}
#utility .navbar-nav li a {
margin:0 10px 10px 0;
padding:0;
}
#utility .navbar-nav .button {
font-size:13px;
padding:8px 15px;
float:left;
display:inline-block;
}
}

#nav-home a {
font-weight:bold;
}

#nav-user {
margin-right:10px;
}
@media (max-width: 767px) {
#nav-user {
margin:0 0 10px;
}
}

#nav-social-icons {
}


#utility #nav-social-icons li a {
/* margin: 12px 4px 0;  **** Abdi Jibri, Consultant of DDS, LLC changed ****/
margin: 30px 4px 0
width: 35px;
height: 35px;
border: 2px solid #385e9d;
border-radius: 50%;
font-size: 2rem;
padding: 6px;
text-align: center;
color: #385e9d;
}
#utility #nav-social-icons li a:hover {  
border-color: #f0b323;
color: #f0b323;
text-decoration: none;
}


/* ****10/21/2018: NEW. Abdi Jibri, Consultant of DDS, LLC Added change  ****/
#utility #nav-social-icons li a, #RTVirtualConnect #nav-social-icons li a {
    margin: 30px 4px 0;  
    width: 35px;
    height: 35px;
    border: 2px solid #82afde;
    border-radius: 50%;
    font-size: 2rem;
    padding: 6px;
    text-align: center;
    font-family: 'FontAwesome';
    background-color:whitesmoke;
    text-decoration: none;
}

@media (max-width: 767px) {
#nav-social-icons {
padding:0;
}
#nav-social-icons li {
display:inline;
float:left;
}
#utility #nav-social-icons li a {
margin:0 4px;
}
}

#nav {
margin:0 0 5px;
clear:both;
}
.page-home #nav {
margin:0;
}
@media (max-width: 767px) {
#nav {
border:0;
margin:0 0 10px;
}
#nav.navbar-inverse .navbar-nav>.active>a,
#nav.navbar-inverse .navbar-nav>.active>a:hover,
#nav.navbar-inverse .navbar-nav>.active>a:focus {
margin-top:0;	
margin-bottom:0;
}
}

#media {
overflow:hidden;
}
#media .item:after {
content:"";
position:absolute;
top:0; bottom:0; left:0; right:0;
opacity:0.4;
border:10px solid #fff;
}
#media .item > img {
width:100%;
height:auto;
}
#media .carousel-indicators {
bottom:2px;
left:0;
padding:10px 20px;
margin:0;
text-align:left;
width:100%;
}
#media .carousel-indicators li {
border:0;
background:#385e9d;
}
#media .carousel-indicators li.active {
background:#f0b323;
}
#media .carousel-caption {
background:transparent url('../teamraiser-themes/theme1/images/bg-pattern-diagonal-white.png');
text-align:right;
padding:15px 20px;
width:355px;
left:0;
bottom:38px;
}
#media .carousel-caption h3 {
margin-top:0;
font-family: Arial,Helvetica,Verdana,sans-serif;
font-size:25px;
font-style:italic;
text-transform:none;
color:#385e9d;
line-height:1.35;
}
#media .carousel-caption :last-child {
margin-bottom:0;
}
#media .carousel-caption .button {
font-weight:bold;
font-size:15px;
}
#media .carousel-control {
width: auto;
padding: 0 20px;
}
#media .carousel-control.left {
background:url('../teamraiser-themes/theme1/images/carousel-chevron-left-white.png') center center no-repeat;
}
#media .carousel-control.right {
background:url('../teamraiser-themes/theme1/images/carousel-chevron-right-white.png') center center no-repeat;
}
@media (max-width: 767px) {
#media .carousel-caption {
width:100%;
position:static;
}
#media .carousel-caption h3 {
font-size:14px;
}
#media .carousel-caption .button {
font-size:11px;
}
}


#call-to-action {
background:#9e91c6;
}
#call-to-action .row {
padding:10px 0;
}
#call-to-action .button {
font-size:18px;
font-weight:bold;
padding-left:0;
padding-right:0;
}
#call-to-action .button small {
font-family: Arial,Helvetica,Verdana,sans-serif;
font-style:italic;
font-size:16px;
font-weight:normal;
text-transform:none;
display:block;
}
@media (max-width: 767px) {
#call-to-action .button {
margin-bottom:10px;
}
#call-to-action .row div:last-child .button {
margin-bottom:0;
}
}
@media (max-width: 991px) {
#call-to-action .row {
margin-left:-5px;
margin-right:-5px;
}
#call-to-action div[class*="col-"] {
padding:0 5px;
}
}

#content {
padding-bottom:40px;
}
@media (max-width: 767px) {
#content {
padding-bottom:10px;
}
}
#content img {
display: block;
max-width: 100%;
height: auto;
}

#footer {
text-align:center;
font-size:12px;
background:#fff;
}
#footer .container {
padding-top:40px;
}
#footer p {
margin: 0 0 20px;
}

#content-inner {
padding:25px 0;
}

#content-primary {
padding-top:40px;
}
.page-home #content-primary {
padding-top:20px;
}
@media (max-width: 767px) {
#content-primary {
padding-top:15px;
}
}

#content-secondary {
padding-top:40px;
}
.page-home #content-secondary {
padding-top:20px;
}
#content-secondary .form-control {
background:#E1E2E3;
box-shadow:none;
padding:4px 12px;
border:0;
}
#content-secondary .input-group {
margin-top:5px;
}
#content-secondary h2 {
color:#f0b323;
font-family: Arial,Helvetica,Verdana,sans-serif;
font-weight:normal;
font-size:24px;
margin:0 0 10px;
text-transform: uppercase;
}
#content-secondary .btn {
border-width:0;
padding:7px 8px;
font-size:14px;
background:#9e91c6;
display:block;
color:#fff;
margin:0 !important;
}
@media (max-width: 767px) {
#content-secondary {
padding-top:0;
}
#content-secondary h2 {
font-size:14px;
}
}
@media (max-width: 991px) {
#content-secondary h2 {
font-size:18px;
}
}

.sidebar-group {
margin-bottom:15px;
padding-bottom:15px;
border-bottom:1px solid #e2e1e0;
}
.sidebar-group:last-child {
border-bottom:0;
margin-bottom:0;
padding-bottom:0;
}
@media (max-width: 767px) {
.page-home .sidebar-group {
padding:0 0 10px;
margin:0 0 10px;
}
}

#sponsors {
padding:20px 0;
border-top:1px solid #d3d2d1;
border-bottom:2px solid #d3d2d1;
background:#fff;
}
#sponsors ul.nav {
margin:0 -10px;
padding:0;
text-align:center;
}
#sponsors ul.nav li {
padding:10px;
margin:0;
position:relative;
height:130px;
width:16.666666667%;
display:inline-block;
overflow:hidden;
}
#sponsors ul.nav li a {
padding:0;
height:100%;
}
#sponsors ul.nav li a:hover {
background:transparent;
}
#sponsors ul.nav li a img {
width:100%;
height:auto;
position:absolute;
margin:auto;
top:0;
right:0;
bottom:0;
left:0;
}
@media (max-width: 767px) {
#sponsors ul.nav li {
width:100%;
height:auto;
position:static;
display:block;
}
#sponsors ul.nav li a img {
position:static;
width:auto;
max-width:100%;

}
}

#hidden-scripts {
display:none;
}

input.default-submit-hack {
display:none;
}

a.button,
button.button,
.step-button,
div#find_participant button.search-button,
button.search-button,
div.responsive button.action-button,
div.indicator-container a.indicator-link {
text-transform:uppercase;
-moz-user-select: none;
    background-image: none;
    border: 1px solid rgba(0, 0, 0, 0);
    border-radius: 0;
    cursor: pointer;
    display: inline-block;
    font-size: 14px;
    font-weight: normal;
    line-height: 1.42857;
    margin-bottom: 0;
    padding: 6px 12px;
    text-align: center;
    vertical-align: middle;
    white-space: normal;
    color:#fff;
    text-indent:0;
    background-color:#9e91c6;
}
.button:hover,
.step-button:hover,
div#find_participant button.search-button:hover,
button.search-button:hover,
div.responsive button.action-button:hover,
div.indicator-container a.indicator-link {
text-decoration:none;
}

/* BOOTSTRAP OVERRIDES */
h1,
.header-container h2,
div.tr-page-header h2,
div#team_page_header h2 {
color:#f0b323;
font-size:26px;
font-weight:normal;
font-family: Arial,Helvetica,Verdana,sans-serif;
margin:0 0 15px;
}
h2 {
color:#9e91c6;
font-size:18px;
}
h3 {
color:#333;
font-size:14px;
text-transform:uppercase;
}
h4 {
font-size:14px;
}
a.btn {
border-radius:0;
}
a.btn-primary, a.btn-primary:hover, div.thermometer-container div.donation-link-container a {
color: #ffffff;
background-color: #385e9d;
border-color: #385e9d;
}
.btn-primary:hover, .btn-primary:focus, .btn-primary:active, .btn-primary.active, .open .dropdown-toggle.btn-primary {
background-color:#049cc6;
border-color:#049cc6;
}
button.btn-success,
a.btn-success {
background: #5f134e;   /** 10/21/18: Abdi Jibril, DDS,LLC. NEW. LOGIN button font weight*****/ 
border-color: #5f134e;
color: #FFFFFF;
border-radius:0;
font-weight: 700;     /** 10/21/18: Abdi Jibril, DDS,LLC. NEW. LOGIN button font weight *****/
border-width: thin;  /** 10/21/18: Abdi Jibril, DDS,LLC. NEW. LOGIN button font weight  ****/
}
a.btn-primary,
a.btn-primary:hover,
div.thermometer-container div.donation-link-container a {
background-image:url('../teamraiser-themes/theme1/images/bg-pattern-diagonal.png');
border-width:5px;
border-color: #385e9d;
}
.btn-success:hover, .btn-success:focus, .btn-success:active, .btn-success.active, .open .dropdown-toggle.btn-success {
color: #ffffff;
background-color: #f0b323;
border-color: #f0b323;
}
.navbar-inverse {
border-left:0;
background:#9e91c6;
border-color:#9e91c6;
border-radius:0;
}
/* Event navigation bar - Main Menu */
.navbar-inverse .navbar-nav>li>a {
text-transform:uppercase;
font-size:13px;
color:#fff;
text-decoration: none; /*10/21/18. NEW: Abdi Jibril, DDS,LLC added */
font-weight: 550; /*10/21/18. NEW: Abdi Jibril, DDS,LLC added */
}
@media (max-width: 991px) {
.navbar-inverse .navbar-nav>li>a {
font-size:12px;
padding:8px 12px;
}
}

/********** 10/21/18. New. DDS,LLC added. MAIN MENU Mouse hover BG color *********/
.navbar-inverse .navbar-nav > li > a:hover {
    color: #fff;
    background: #1f9d55;
    text-decoration: underline;
    border-radius: 5px;
    border-color: #1f9d55;
}


.navbar-inverse .navbar-nav>.active>a,
.navbar-inverse .navbar-nav>.active>a:hover,
.navbar-inverse .navbar-nav>.active>a:focus {
border-top:1px solid  #19acd7;
border-bottom:1px solid #19acd7;
margin-top:-1px;
margin-bottom:-1px;
}
.panel-primary {
border-color: #9e91c6;
}
.panel-primary>.panel-heading {
color: #ffffff;
background-color: #9e91c6;
border-color: #9e91c6;
border-radius:0;
}
.carousel-caption {
text-shadow:none;
}
@media (min-width: 768px) {
#content-secondary .hidden-xs {
display:block !important;
}
}

/* LUMINATE OVERRIDES */
div.responsive {
width:100% !important;
padding:0 !important;
font-family: Myriad Pro, sans-serif !important;
font-size:14px !important;
border-radius:0 !important;
border:0 !important;
color:#333333 !important;
background:transparent !important;
}
div.tr-page-container,
div.registration-page-container div.section-container {
border-radius:0;
border:0;
color:#333333;
}
div.tr-page-container div.header-container {
background:transparent;
}
div.tr-page-container div.section-sub-header,
div.registration-page-container div.section-sub-header {
background:transparent;
border:0;
padding:0;
}
div.tr-page-container div.main-content,
div.tr-page-main-content {
width:66.6666666667%;
margin:0;
padding:0 20px 0 0;
}
div.tr-page-container div.side-bar {
width:33.33333333%;
}
@media (max-width: 767px) {
div.tr-page-container div.main-content,
div.tr-page-container div.side-bar {
width:100%;
padding:0;
}
}
div.tr-page-container div.side-bar > div {
padding:20px 15px;
margin:0 0 10px;
background:#e8e9eb url('../teamraiser-themes/theme1/images/bg-pattern-cross.png');
}
div.tr-page-container div.side-bar div.indicator-container * {
font-size:13px !important;
}
div.tr-page-container div.side-bar h3 {
margin:0;
}
#entry div.entry-option-info-container + div.entry-option-info-container {
margin-top:0;
}
h2.tr-page-title,
span.section-header-text,
div.section-header,
#title_container {
font-family: Arial,Helvetica,Verdana,sans-serif;
color:#f0b323;
font-size:26px;
font-weight:normal;
padding:0 !important;
background:transparent !important;
margin:0;
}
div.registration-page-container div.sub-section-header {
border:0;
padding:0;
margin:15px 0;
font-size:16px;
font-weight:bold;
color:#555;
background:transparent;
}
div.registration-page-container div.sub-section-container {
background:transparent;
}
div.section-body,
div#reg_instr_container,
div.registration-page-container div.sub-section-body {
padding:0 !important;
}
div.section-footer {
background:transparent !important;
padding:15px 0 20px !important;
border-top:1px solid #e2e2e2;
}
div#email_optin label, div#gift_notice_optin label {
display:inline;
font-weight:normal;
}
div.responsive a.step-button,
div.responsive button.step-button,
div.responsive a.step-button:hover,
div.responsive button.step-button:hover {
border-radius:0;
background-image:none;
white-space:normal;
font-size:18px;
margin:0 0 10px;
}
div.responsive a.next-step,
div.responsive button.next-step,
div.responsive a.next-step:hover,
div.responsive button.next-step:hover,
div.responsive a.previous-step,
div.responsive button.previous-step,
div.responsive a.previous-step:hover,
div.responsive button.previous-step:hover,
div.responsive a.cancel-step,
div.responsive button.cancel-step,
div.responsive a.cancel-step:hover,
div.responsive button.cancel-step:hover {
color: #ffffff;
background: #9e91c6;
border-color: #9e91c6;
background-image:url('../teamraiser-themes/theme1/images/bg-pattern-diagonal.png');
border-width:5px;
filter:none;
text-decoration: none;
margin: 0 0 10px;
padding: 10px 7px;
min-width: 132px;
font-size: 18px;
}
div.responsive a.secondary-step,
div.responsive button.secondary-step,
div.responsive a.secondary-step:hover,
div.responsive button.secondary-step:hover {
background: #f0b323;
border-color: #f0b323;
color: #FFFFFF;
}
div.tr-page-container #entry_page_custom_html {
padding:0 20px 20px 0;
}
h3.menu-title,
div.indicator-title {
font-size:16px;
font-weight:normal;
text-transform:uppercase;
color:#333333;
margin:0;
padding:0 0 10px;
display:block;
float:none;
}
div.indicator-container {
border:0;
border-radius:0;
}
#search_part_team div.ui-tabs-panel {
background:#fff;
margin-bottom:0;
padding:20px 10px 10px;
}
#search_part_team ul li {
padding:7px 10px 0;
}
#search_part_team ul li.ui-tabs-selected {
background:#fff;
padding:7px 10px 5px;
}
#search_part_team div.ui-tabs-panel input {
margin:0 0 10px;
border-radius:0;
box-shadow:none;
display:block;
width:100%;
border:0;
background:#e9e8e7;
}
div.responsive input.default-submit-hack {
padding:0;
margin:0 !important;
border:0;
}
div.thermometer-container div.thermometer-outer {
background:#fff;
box-shadow:0 2px 4px #ccc;
}
div.thermometer-container div.thermometer-inner {
background-color:#f0b323;
border:0;
}
div.thermometer-container div.donation-link-container {
padding:10px 0 0;
}
a#sidebar_donate_button {
margin:0 0 10px;
}
div.tr-status-indicator-container + div.tr-status-indicator-container {
margin-top:10px;
}
div.thermometer-container div.donation-link-container a {
display:block;
}
div.indicator-container {
padding:0;
}
#team_find_new_team_attributes,
#team_find_new_team_company {
width:100%;
float:none;
}
div.input-container,
div.responsive div.form-content {
margin:0 0 15px !important;
}
div.donation-level-container div.form-content {
margin:0 !important;
}
div.donation-level-input-container, div.generic-repeat-label-checkbox-container {
padding:0;
}
div.responsive div.ErrorMessage.page-error > span.field-error-text {
width:auto;
}
#team_find_page label,
label {
margin:0 !important;
padding:0 !important;
font-size:14px !important;
}
input[type="text"],
input[type="password"],
input[type="email"],
textarea,
select {
display:block;
width:100%;
border-radius:0 !important;
border:1px solid #e2e2e2;
box-shadow:0;
background:#f2f1f0;
padding:4px;
}
div.responsive div.form-error input[type="text"],
div.responsive div.form-error input[type="password"],
div.responsive div.form-error textarea,
div.responsive div.form-error select {
background:#fff;
border-color:#B94A49;
}
.header-container .campaign-banner-container {
font-size:26px;
margin:0 0 10px;
font-weight:bold;
}
div.form-progress-bar,
div.progress-bar-container {
overflow:hidden;
margin:0 0 15px;
}
div.progress-bar-step-current div.progress-bar-step-number-container {
background:#f0b323;
}
.form-info-message {
padding:0 0 15px;
}
div.progress-bar-step-container {
background:#e8e9eb url('../teamraiser-themes/theme1/images/bg-pattern-cross.png');
margin:0 4px 4px 0;
padding:10px;
float:left;
line-height:1.35;
}
div.progress-bar-step-text-container {
vertical-align:middle;
}
div.progress-bar-step-text-container a {color: #9e91c6 !important;}

#team_find_registration_type_container {
font-size:1em;
margin:0;
}
div#part_type_fundraising_goal_container input,
#fr_gift,
div#user_type_new_participant_registration_container #next_step {
margin:0;
}
div#cons_info_component_container div#personal_info_section_one,
div#cons_info_component_container div#personal_info_section_two,
div#cons_info_component_container div#contact_info_section_one,
div#cons_info_component_container div#contact_info_section_two,
div#registration_options_page div#user_name_pword_container,
div#registration_options_page div#privacy_opts_container,
div#registration_options_page div#tribute_component_section_one,
div#registration_options_page div#tribute_component_section_two,
div#emergency_contact_container,
div#gift_notice_optin,
div#email_optin {
width:100%;
float:none;
}
div.reg-summary-thanks-common-container div.reg-summary-total {
margin:0;
}
div.reg-summary-participant-info-container {
margin:15px 0;
}
div.reg-summary-thanks-common-container div.reg-summary-address-info {
width:100%;
display:block;
}
div.reg-summary-thanks-common-container div.reg-summary-event-info {
display:block;
width:100%;
border-left-width:2px;
}
div.reg-summary-thanks-common-container div.action-button-container,
#reg_payment_page #billing_addr_street1_row input,
#reg_payment_page #billing_addr_street2_row input,
#employer_street_row input,
#billing_addr_street1_row input,
#billing_addr_street2_row input,
#billing_addr_street3_row input,
#billing_addr_country_row input.ui-autocomplete-input,
#donor_addr_street1_row input,
#donor_addr_street2_row input,
#donor_addr_street3_row input,
#donor_addr_country_row input.ui-autocomplete-input,
#shipping_addr_street1_row input,
#shipping_addr_street2_row input,
#shipping_addr_street3_row input,
#shipping_addr_country_row input.ui-autocomplete-input,
#tribute_notify_recip_street1_row input,
#tribute_notify_recip_street2_row input,
#tribute_notify_recip_street3_row input,
#tribute_notify_recip_country_row input.ui-autocomplete-input,
#tribute_signature_row input,
#tribute_message_closing_row input,
div.employer-address-container input#employer_street {
width:100%;
}
@media (max-width: 767px) {
    div.progress-bar-step-number-container {
        float:left;
        width:10%;
    }
    div.progress-bar-step-text-container {
        width:90%;
        margin:0;
        padding:0 0 0 10px;
        font-size:14px;
        line-height:28px;
    }
    div.progress-bar-step-container,
    div.progress-bar-step-text-container {
        float:none;
        margin:0 0 5px;
        max-width:100%;
    }
    div.progress-bar-step-container {
        width:100%;
        padding:10px;
        margin:0 0 5px;
    }
}
@media (max-width: 991px) {
div.section-footer .step-button {
display:block;
margin:0 0 10px !important;
float:none !important;
width:100%;
}
}
.trPage .header h2 {
margin-top:0;
}
.trPage {
    margin:0;
    width:100%;
}
.trPage .main {
width: 100% !important;
margin:0;
overflow:visible;
float:none;
}
div#find_participant div.search-content {
padding:0;
}
#find_participant div.participant-find-search-container {
width:100%;
}
#find_participant div.participant-find-search-results {
background:transparent;
padding:0;
border:0;
}
#find_participant div.list-component-row,
div.responsive div.list-row {
background-image:none;
background:#fff;
border:0;
margin:0 0 10px;
padding:15px;
border-bottom:1px solid #e2e1e0;
border-radius:0;
}
div.list-component-cell {
padding:0;
}
div#find_participant div.list-component-body div.list-component-cell span.list-component-cell-title-text {
font-style:normal;
}
#team_search_field_team,
#last_name_search_field {
width:82%;
}
div#content button#fr_find_search_team,
button#fr_find_search {
width:auto;
}
div#content button.search-button {
background:#9e91c6;
height:auto !important;
width:auto;
font-size:14px;
}
div#find_participant span#participant_find_search_text, div#find_participant span#team_find_search_text {
display:inline;
}
div.find-participant-badge-container {
float:left;
}

div#user_type_new_participant_registration_container,
div#user_type_login_container {
margin:0 0 30px;
width:100%;
padding:0;
border:0;
background:transparent;
}
div#fr_thanks_page a#part_ctr_container {
margin:10px 0;
width:100%;
}
div.appArea {
width:100%;
margin:10px 0;
}
#donate_direct_link_container,
#donate_link_container,
#entry_page_reg_team_type_container,
#entry_misc_links {
display:none;
}
div.thermometer-container span.amount-percentage-value,
div.thermometer-container span.amount-raised-value {
font-size:18px;
}

/* LEADERBOARDS */
#leaderboards .panel-heading {
text-align:center;
text-transform:uppercase;
}
#leaderboards .panel-heading h4 {
display:inline;
margin:0;
padding:0;
color:#fff;
font-size:18px;
font-weight:normal;
}
#leaderboards div.donor-list-indicator-container .indicator-container {
border-top:0;
}
#leaderboards .panel-heading a {
color:#4e525d;
font-weight:bold;
font-size:12px;
margin-left:10px;
}
#leaderboards .panel {
border:0;
background:transparent;
box-shadow:none;
}
#leaderboards .panel-body {
padding:0;
}
#leaderboards div.donor-list-indicator-container {}
#leaderboards div.donor-list-indicator-container .indicator-title {
display:none;
}
#leaderboards div.donor-list-indicator-container .indicator-list-row {
padding:5px 20px;
}
#leaderboards div.donor-list-indicator-container .indicator-list-row:nth-child(even) {
background:#e8e9eb url('../teamraiser-themes/theme1/images/bg-pattern-cross.png');
}
#leaderboards .indicator-list-row .list-name-container {
display:inline;
}
#leaderboards .indicator-list-row .list-name-container .display-name {
display:inline;
}
#leaderboards .indicator-list-row .list-name-container .indicator-link {
color:#73b748;
background:transparent;
padding:0;
margin:0;
display:inline;
text-transform:none;
border:0;
text-align:left;
}
#leaderboards .indicator-list-row .list-value-container {
display:inline;
float:right;
}

/* PERSONAL PAGE */
div.tr-page-header,
div#team_page_header {
padding:0;
margin:0 0 20px;
background:transparent;
}
div#personal_page_image_div,
div#team_image {
    width:40%;
    float:left;
    margin:0 15px 15px 0;
}
div#personal_page_image_div img,
div#team_image img {
    width:100%;
    height:auto;
    padding:8px;
    background:#fff;
    box-shadow:0 2px 4px rgba(0,0,0,0.25);
}
div#personal_page_menu {
margin:0 0 10px;
}
div#personal_join_team_button_container,
div#join_team_button_container {
margin:0;
}
div.team-roster-raised-label {
display:block;
float:none;
text-align:right;
margin:0 -5px 15px;
padding:5px;
border-top:1px solid #ccc;
border-bottom:1px solid #ccc;
text-transform:uppercase;
color:#888;
font-size:85%;
}
div.team-roster-legend {
padding:5px 5px 0 5px;
border-top:1px solid #ccc;
margin:15px -5px 0;
}
div.team-roster-participant-row {
margin:0 0 8px;
}
@media (max-width: 767px) {
#personal_page_main_content,
div#team_page_main_content {
width:100%;
margin:0 0 10px;
padding:0;
}
div#personal_page_image_div,
div#team_image {
width:100%;
margin:0 0 10px;
}
}


/* HONOR ROLL */
div.donor-list-indicator-container {
margin:0;
}
div.donor-list-indicator-container div.vscroll-container > div {
margin:0 !important;
padding:0;
}
div.donor-list-indicator-container div.vscroll-container div.indicator-list-row {
margin:0 0 5px;
padding:0;
}
div.donor-list-indicator-container .indicator-container {
border-top: 1px solid #ccc;
padding:10px 0 0;
}
div.donor-wall-link-container {
padding:5px 0;
}

/* SHARE THIS */
#section-share {
clear:both;
overflow:hidden;
}
#section-share > span {
display:block;
float:left;
margin:0 3px 3px 0;
}
#section-share > span:last-child {
margin-right:0;
}
#section-share > span > span {
display:block;
margin:0;
padding:0;
}

/* REGISTER */
div#user_type_oauth_login_container {
    width:100%;
    padding:0 0 0 350px;
    margin-top: -430px;
margin-bottom: 10px;
}

span#fr_responsive_social_login_container {
    display:block;
    padding:0 0 10px;
}
.social-provider-link-container {
    float:left;
}
div.social-provider-link-container a {
    padding:0;
    margin:0 10px 10px 0;
    display:block;
}
div.registration-page-container div.sub-section-body {
    background:transparent;
}


/* SPECIFIC HOVERS */

.sponsors-footer a img:hover, .tr-social-icon:hover { opacity: 0.75 !important; }
#nav-social-icons a:hover { background-color:transparent !important; }

#nav li:hover { 
/* IE9 SVG, needs conditional override of 'filter' to 'none' */
background-image: url(data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiA/Pgo8c3ZnIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyIgd2lkdGg9IjEwMCUiIGhlaWdodD0iMTAwJSIgdmlld0JveD0iMCAwIDEgMSIgcHJlc2VydmVBc3BlY3RSYXRpbz0ibm9uZSI+CiAgPGxpbmVhckdyYWRpZW50IGlkPSJncmFkLXVjZ2ctZ2VuZXJhdGVkIiBncmFkaWVudFVuaXRzPSJ1c2VyU3BhY2VPblVzZSIgeDE9IjAlIiB5MT0iMCUiIHgyPSIwJSIgeTI9IjEwMCUiPgogICAgPHN0b3Agb2Zmc2V0PSIwJSIgc3RvcC1jb2xvcj0iI2ZmZmZmZiIgc3RvcC1vcGFjaXR5PSIwLjMiLz4KICAgIDxzdG9wIG9mZnNldD0iMTAwJSIgc3RvcC1jb2xvcj0iI2ZmZmZmZiIgc3RvcC1vcGFjaXR5PSIwLjMiLz4KICA8L2xpbmVhckdyYWRpZW50PgogIDxyZWN0IHg9IjAiIHk9IjAiIHdpZHRoPSIxIiBoZWlnaHQ9IjEiIGZpbGw9InVybCgjZ3JhZC11Y2dnLWdlbmVyYXRlZCkiIC8+Cjwvc3ZnPg==);
background-image: -moz-linear-gradient(top,  rgba(255,255,255,0.3) 0%, rgba(255,255,255,0.3) 100%); /* FF3.6+ */
background-image: -webkit-gradient(linear, left top, left bottom, color-stop(0%,rgba(255,255,255,0.3)), color-stop(100%,rgba(255,255,255,0.3))); /* Chrome,Safari4+ */
background-image: -webkit-linear-gradient(top,  rgba(255,255,255,0.3) 0%,rgba(255,255,255,0.3) 100%); /* Chrome10+,Safari5.1+ */
background-image: -o-linear-gradient(top,  rgba(255,255,255,0.3) 0%,rgba(255,255,255,0.3) 100%); /* Opera 11.10+ */
background-image: -ms-linear-gradient(top,  rgba(255,255,255,0.3) 0%,rgba(255,255,255,0.3) 100%); /* IE10+ */
background-image: linear-gradient(to bottom,  rgba(255,255,255,0.3) 0%,rgba(255,255,255,0.3) 100%); /* W3C */
filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#4dffffff', endColorstr='#4dffffff',GradientType=0 ); /* IE6-8 */
 }

.button.btn-primary.btn-block.btn-lg:hover, button.btn-success:hover, a.btn-success:hover, div#content button.search-button:hover, div.responsive a.next-step:hover, div.responsive button.next-step:hover, div.responsive button.cancel-step:hover, div.responsive a.cancel-step:hover, div.responsive button.previous-step:hover, div.responsive a.previous-step:hover  { 
/* IE9 SVG, needs conditional override of 'filter' to 'none' */
background-image: url(data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiA/Pgo8c3ZnIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyIgd2lkdGg9IjEwMCUiIGhlaWdodD0iMTAwJSIgdmlld0JveD0iMCAwIDEgMSIgcHJlc2VydmVBc3BlY3RSYXRpbz0ibm9uZSI+CiAgPGxpbmVhckdyYWRpZW50IGlkPSJncmFkLXVjZ2ctZ2VuZXJhdGVkIiBncmFkaWVudFVuaXRzPSJ1c2VyU3BhY2VPblVzZSIgeDE9IjAlIiB5MT0iMCUiIHgyPSIwJSIgeTI9IjEwMCUiPgogICAgPHN0b3Agb2Zmc2V0PSIwJSIgc3RvcC1jb2xvcj0iI2ZmZmZmZiIgc3RvcC1vcGFjaXR5PSIwLjIiLz4KICAgIDxzdG9wIG9mZnNldD0iMTAwJSIgc3RvcC1jb2xvcj0iI2ZmZmZmZiIgc3RvcC1vcGFjaXR5PSIwLjIiLz4KICA8L2xpbmVhckdyYWRpZW50PgogIDxyZWN0IHg9IjAiIHk9IjAiIHdpZHRoPSIxIiBoZWlnaHQ9IjEiIGZpbGw9InVybCgjZ3JhZC11Y2dnLWdlbmVyYXRlZCkiIC8+Cjwvc3ZnPg==);
background-image: -moz-linear-gradient(top,  rgba(255,255,255,0.2) 0%, rgba(255,255,255,0.2) 100%); /* FF3.6+ */
background-image: -webkit-gradient(linear, left top, left bottom, color-stop(0%,rgba(255,255,255,0.2)), color-stop(100%,rgba(255,255,255,0.2))); /* Chrome,Safari4+ */
background-image: -webkit-linear-gradient(top,  rgba(255,255,255,0.2) 0%,rgba(255,255,255,0.2) 100%); /* Chrome10+,Safari5.1+ */
background-image: -o-linear-gradient(top,  rgba(255,255,255,0.2) 0%,rgba(255,255,255,0.2) 100%); /* Opera 11.10+ */
background-image: -ms-linear-gradient(top,  rgba(255,255,255,0.2) 0%,rgba(255,255,255,0.2) 100%); /* IE10+ */
background-image: linear-gradient(to bottom,  rgba(255,255,255,0.2) 0%,rgba(255,255,255,0.2) 100%); /* W3C */
filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#33ffffff', endColorstr='#33ffffff',GradientType=0 ); /* IE6-8 */
 }

.media-container {     
    height: 0;
    overflow-x: hidden;
    overflow-y: hidden;
    padding-bottom: 56.25%;
    padding-top: 30px;
    position: relative;
}
.media-container iframe, .media-container object, .media-container embed {
    height: 100%;
    left: 0;
    position: absolute;
    top: 0;
    width: 100%;
}
 
button.navbar-toggle { z-index:100; }

h2.tr-page-title, span.section-header-text, div.section-header, #title_container, h1, .header-container h2, div.tr-page-header h2, div#team_page_header h2 {
	font-size:22px;
	font-weight:bold;
}

h3.menu-title, div.indicator-title { 
font-weight:bold;
}

/* Updates to Drop Down Menu & Gigya Login */
@media (max-width: 430px) {
div#user_type_oauth_login_container {
    width:100%;
    padding:0 !important;
margin:15px 0 0;
}
}

/*Drop Down Styles */
#nav > ul li:hover { background:#f0b323; }
#nav ul ul {display:none; list-style-type:none; position:absolute; width:200px; z-index:9999; }
#nav ul ul, #nav ul ul li, #nav ul ul li a { color:#FFF; text-transform: uppercase; font-size: 13px; background:#f0b323; padding:5px; }

#nav ul ul:hover,
#nav ul ul li:hover,
#nav ul ul li a:hover,
#nav ul li:hover ul,
#nav ul li:hover ul li,
#nav ul li:hover ul li a { display:block; background:#f0b323; }
#sponsortext { margin:0 auto; width:120px; color:#000; font-size:18px; font-weight:bold; }

div.responsive a:visited, div.responsive a:link, #leaderboards .indicator-list-row .list-name-container .indicator-link {
color:#9e91c6;
}

div#find_participant div.list-component-body div.list-component-cell-column-donate a {
background-color: #9e91c6;
    background-image: none;
    border: 1px solid #ffffff;
    border-radius: 0;
    color: #ffffff;
    cursor: pointer;
    display: inline-block;
    min-width: 132px;
    padding: 5px 7px;
    text-align: center;
    text-decoration: none;
}

.donor-wall-link, .donor-wall-link:link, .donor-wall-link:visited {
color:#ffffff !important;
}

/*************** Calendar Events ***************/

.fieldContainer label { color: #555; }
th.lc_Heading, th.lc_HeadingSort { background-color: #9e91c6; color: #fff; }
th.lc_Heading p { color: #fff; }
#lo-additional-gift-value-container { margin-bottom:1.5em; }
.navDateArrow { float:left; }
#cal_event_calendar .eventDetailPopupBox { left: 25% !important; top:25% !important; }
div.lo-EventBorderContainer, div.lo-BorderContainer { border:0px; }
@media screen and (max-width: 768px) {
#cal_event_calendar .eventDetailPopupBox { left: 0 !important; top:0 !important; }
}
--></style>
<p>
[[?x[[S334:view]]x::xTicketsx::
</p>
<style type="text/css"><!--
#sponsors {
display: none; 
}
--></style>
<p>
::]]
[[?x[[S334:view]]x::xDetailx::
</p>
<style type="text/css"><!--
#sponsors {
display: none; 
}
--></style>
<p>
::]]
[[?x[[S8]]x::utype::
</p>
<style type="text/css"><!--
div.manageable-content {
position: relative; 
width: 300px;
}
--></style>
<p>::]]
</p>
<!--[if gte IE 9]>
  <mce:style type="text/css"><! 
    .gradient {
       filter: none;
    }
  
-->
<!--[endif] -->