<?php
require_once 'Zend/Loader.php';
Zend_Loader::loadClass('Zend_Soap_Client');

$opcije=array(
   'location'=>'http://ps/Index/soap',
   'uri'=>'http://ps/Index/soap'
);
try{
  $klijent=new Zend_Soap_Client(null,$opcije);
  
  $karta = $klijent->getKarta();
  print_r($karta);
  
  print_r($klijent->sacuvajKartu($karta));
  
  print_r($klijent->pronadjiKartu(5));
   print_r($klijent->popusti());
  
  
}catch(SoapFault $s){
   die('Error['.$s->faultcode.']'.$s->faultstring);
}catch(Exception $e){
  die('Error:'.$e->getMessage());
}
?>