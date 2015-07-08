<?php
require_once 'class.phpmailer.php';

$mail = new PHPMailer(true); //defaults to using php "mail()"; the true param means it will throw exceptions on errors, which we need to catch

try {
  $mail->AddAddress('sumit.rajora@gmail.com', 'sumit');
  $mail->SetFrom('sumit.rajora@gmail.com', 'Hi from sumit');
  $mail->AddReplyTo('sumit.rajora@gmail.com', 'First Last');
  $mail->Subject = 'mail test';
  $mail->AltBody = 'To view the message, please use an HTML compatible email viewer!'; // optional - MsgHTML will create an alternate automatically
 //mail format
  $mailBody='<div><table align="center" cellpadding="0" cellspacing="0" style="font-family:Calibri;font-size:13px;font-style:normal;font-variant:normal;font-weight:normal;letter-spacing:normal;line-height:normal;text-align:start;text-indent:0px;text-transform:none;white-space:normal;word-spacing:0px;background-color:rgb(0,0,0);border:1px solid rgb(52,36,0)"><tbody><tr><td valign="top" align="left" style="padding:15px"><table border="0" cellspacing="0" cellpadding="0"><tbody><tr><td align="center" valign="top"><img src="https://ci5.googleusercontent.com/proxy/k9AK2nHPpFUYN66Tk8vQuPrdakHEYrjdDgBtKLjcb9ahj9-xAEmSy59iv2B57yixptZNN-kwdWwa-HeAlQIeWLq-2SD1NSWhGxwIEu4=s0-d-e1-ft#http://www.grasimfashion.com/assets/images/m-header.jpg" alt="Antara" border="0" style="display:block" class="CToWUd"></td></tr><tr><td align="left" valign="top" style="background-color:rgb(248,248,248);font-family:Arial;font-size:13px;color:rgb(51,51,51);line-height:22px;border-left-width:1px;border-left-style:solid;border-left-color:rgb(190,190,190);border-right-width:1px;border-right-style:solid;border-right-color:rgb(190,190,190);padding:15px;background-repeat:initial initial"><table width="545" border="0" cellspacing="0" cellpadding="0"><tbody><tr><td align="left" valign="top"><p>Hi,<br><br>User has submitted below information</p><p><br>Contact Name:&nbsp; '. $_POST["txtTitle"] ." ". $_POST["txtFirstName"]. " ". $_POST["txtLastName"] .'<br>Email:&nbsp;<span>&nbsp;</span><a href="mailto:'.$_POST["txtEmail"].'" target="_blank">'.$_POST["txtEmail"].'</a><br><br>Phone Number:&nbsp; '.$_POST["txtPhone"].'<br>State:&nbsp; '.$_POST["txtState"].'<br>Country:&nbsp; '.$_POST["txtCountry"].'</p><p><br>Thanks<br>Antara Team<br>&nbsp;</p></td></tr></tbody></table></td></tr><tr><td align="left" valign="top"><img src="https://ci4.googleusercontent.com/proxy/B6D52uIBg0QKbbkWUNGaK0zYuFXSjo882IeRU2b7E53zGtciDa1jSAChwxnWFWr1AuqYyPxCZpHsYeVpmoFreeM-6Ves6Y2054OEMQQ=s0-d-e1-ft#http://www.grasimfashion.com/assets/images/m-footer.jpg" alt="Copyright © 2014 Antara. All rights reserved." border="0" style="display:block" class="CToWUd"></td></tr></tbody></table></td></tr></tbody></table></div>';

$mail->MsgHTML($mailBody);
  //$mail->MsgHTML("<html><head><title>PHPMailer - Mail() advanced test</title><link rel='shortcut icon' href='favicon.ico' /></head><body>'".$_POST["txtTitle"]."");
  //$mail->AddAttachment('images/phpmailer.gif');      // attachment
  //$mail->AddAttachment('images/phpmailer_mini.gif'); // attachment
  $mail->Send();
  echo "Dear ".$_POST["txtTitle"]. " ".$_POST["txtFirstName"]. " Thank you for showing interest in us.<br/> We will contact you soon</p>\n";
} catch (phpmailerException $e) {
  echo $e->errorMessage(); //Pretty error messages from PHPMailer
} catch (Exception $e) {
  echo $e->getMessage(); //Boring error messages from anything else!
}
?>
