<?php
require_once 'class.phpmailer.php';

$mail = new PHPMailer(true); //defaults to using php "mail()"; the true param means it will throw exceptions on errors, which we need to catch

try {
  $mail->AddAddress('communitydevelopment@antaraseniorliving.com', 'Antara');
  //$mail->AddCC('sumit.rajora@gmail.com', 'Antara');
  $mail->SetFrom('communitydevelopment@antaraseniorliving.com', 'Antara Community');
  //$mail->AddReplyTo('sumit.rajora@gmail.com', 'First Last');
  $mail->Subject = 'Subscription of user';
  $mail->AltBody = 'To view the message, please use an HTML compatible email viewer!'; // optional - MsgHTML will create an alternate automatically
 //mail format
  $mailBody='<div><table align="center" cellpadding="0" cellspacing="0" style="font-family:Calibri;font-size:13px;font-style:normal;font-variant:normal;font-weight:normal;letter-spacing:normal;line-height:normal;text-align:start;text-indent:0px;text-transform:none;white-space:normal;word-spacing:0px;background-color:#5A3300;border:1px solid rgb(52,36,0)"><tbody><tr><td valign="top" align="left" style="padding:15px"><table border="0" cellspacing="0" cellpadding="0"><tbody><tr><td align="center" valign="top"><img src="http://webgrips.com/images/logo.png" alt="" border="0" style="display:block" class="CToWUd"></td></tr><tr><td align="left" valign="top" style="background-color:rgb(248,248,248);font-family:Arial;font-size:13px;color:rgb(51,51,51);line-height:22px;border-left-width:1px;border-left-style:solid;border-left-color:rgb(190,190,190);border-right-width:1px;border-right-style:solid;border-right-color:rgb(190,190,190);padding:15px;background-repeat:initial initial"><table width="545" border="0" cellspacing="0" cellpadding="0"><tbody><tr><td align="left" valign="top"><p>Hi,<br><br>User has opted for subscription</p><p><br>Email:&nbsp;<span>&nbsp;</span><a href="mailto:'.$_POST["txtEmail"].'" target="_blank">'.$_POST["txtEmail"].'</a></p></td></tr></tbody></table></td></tr><tr><td align="left" valign="top"> </td></tr></tbody></table></td></tr></tbody></table></div>';

$mail->MsgHTML($mailBody);
  //$mail->MsgHTML("<html><head><title>PHPMailer - Mail() advanced test</title><link rel='shortcut icon' href='favicon.ico' /></head><body>'".$_POST["txtTitle"]."");
  //$mail->AddAttachment('images/phpmailer.gif');      // attachment
  //$mail->AddAttachment('images/phpmailer_mini.gif'); // attachment
  $mail->Send();
  $autoReply= '<div><table align="center" cellpadding="0" cellspacing="0" style="font-family:Calibri;font-size:13px;font-style:normal;font-variant:normal;font-weight:normal;letter-spacing:normal;line-height:normal;text-align:start;text-indent:0px;text-transform:none;white-space:normal;word-spacing:0px;background-color:#5A3300;border:1px solid rgb(52,36,0)"><tbody><tr><td valign="top" align="left" style="padding:15px"><table border="0" cellspacing="0" cellpadding="0"><tbody><tr><td align="center" valign="top"><img src="http://webgrips.com/images/logo.png" alt="" border="0" style="display:block" class="CToWUd"></td></tr><tr><td align="left" valign="top" style="background-color:rgb(248,248,248);font-family:Arial;font-size:13px;color:rgb(51,51,51);line-height:22px;border-left-width:1px;border-left-style:solid;border-left-color:rgb(190,190,190);border-right-width:1px;border-right-style:solid;border-right-color:rgb(190,190,190);padding:15px;background-repeat:initial initial"><table width="545" border="0" cellspacing="0" cellpadding="0"><tbody><tr><td align="left" valign="top"><p>Dear Subscriber,<br/><br>Thank you for signing up for my blog updates. I look forward to sharing my experiences with you as we build the Antara community for you. And we\'ll love to hear from you too so do write in.</p><p>Best,<br/>Tara Singh Vachani</p></td></tr></tbody></table></td></tr><tr><td align="left" valign="top"> </td></tr></tbody></table></td></tr></tbody></table></div>';
 $mail->AddAddress($_POST["txtEmail"], 'User');
  $mail->SetFrom('communitydevelopment@antaraseniorliving.com', 'Subscription Info');
  //$mail->AddReplyTo('sumit.rajora@gmail.com', 'First Last');
  $mail->Subject = 'Thank you for signing up';
  $mail->AltBody = 'To view the message, please use an HTML compatible email viewer!'; // optional - MsgHTML will create an alternate automatically

$mail->MsgHTML($autoReply);
$mail->Send();
} catch (phpmailerException $e) {
  echo $e->errorMessage(); //Pretty error messages from PHPMailer
} catch (Exception $e) {
  echo $e->getMessage(); //Boring error messages from anything else!
}
?>
