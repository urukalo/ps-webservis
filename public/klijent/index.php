<?php

require_once 'Zend/Loader.php';
Zend_Loader::loadClass('Zend_Soap_Client');

$opcije = array(
    'location' => 'http://ps/Index/soap',
    'uri' => 'http://ps/Index/soap'
);
$opcije_admin = array(
    'location' => 'http://ps/Admin/soap',
    'uri' => 'http://ps/Admin/soap'
);
try {
    $klijent = new Zend_Soap_Client(null, $opcije);
    $admin = new Zend_Soap_Client(null, $opcije_admin);

    $result = $klijent->stanicaIzlazna(1);
    var_dump($result);
    foreach ($result as $stanica) {
        $izlazneStanice[$stanica->_idStanica] = $stanica->_naziv;
    }
    echo"<br>";
    var_dump($izlazneStanice);
    
    
    echo"<br> === voznje -===<br/>";
    $trase = $klijent->pronadjiRutu(1,2,"28/12/2013");
    var_dump($trase);
    

//    echo "<br/><br/> uzmi kartu ";
//    $karta = $klijent->getKarta();
//    print_r($karta);
//
//    echo "<br/><br/> ulazne stanice ";
//    var_dump($klijent->stanicaUlazna());
//
//    
//    $data = array(
//        'idKarta' => 1,
//        'idTrasa' => 0,
//        'idStanicaPolaska' => 0,
//        'idStanicaDolaska' => 0,
//        'vremePolaska' => 0,
//        'cena' => 0,
//        'aktivnost' => 0
//    );
//    $karta = (object) $data;
//    
//    echo "<br/> nova karta: ";
//    print_r($karta);
//
//    echo "<br/> sacuvaj kartu: ";
//    print_r($klijent->sacuvajKartu($karta));
//
//    echo "<br/> pronadji kartu: ";
//    print_r($klijent->pronadjiKartu(5));
//    
//    echo "<br/> daj popuste: ";
//    print_r($klijent->popusti());
//    echo "<br/> red voznje: ";
//    $r=$admin->getOtkazanaVoznja(1);
//    print_r($r);
} catch (SoapFault $s) {
    die('Error[' . $s->faultcode . ']' . $s->faultstring);
} catch (Exception $e) {
    die('Error:' . $e->getMessage());
}
?>