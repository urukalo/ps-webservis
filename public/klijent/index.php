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
    $admin= new Zend_Soap_Client(null, $opcije_admin);
    echo "<br/><br/> uzmi kartu ";
    $karta = $klijent->getKarta();
    print_r($karta);

    echo "<br/><br/> ulazne stanice ";
    var_dump($klijent->stanicaUlazna());

    
    $data = array(
        'idKarta' => 1,
        'idTrasa' => 0,
        'idStanicaPolaska' => 0,
        'idStanicaDolaska' => 0,
        'vremePolaska' => 0,
        'cena' => 0,
        'aktivnost' => 0
    );
    $karta = (object) $data;
    
    echo "<br/> nova karta: ";
    print_r($karta);

    echo "<br/> sacuvaj kartu: ";
    print_r($klijent->sacuvajKartu($karta));

    echo "<br/> pronadji kartu: ";
    print_r($klijent->pronadjiKartu(5));
    
    echo "<br/> daj popuste: ";
    print_r($klijent->popusti());
    
    echo "<br/> red voznje: ";
    print_r($admin->getRedVoznje());
} catch (SoapFault $s) {
    die('Error[' . $s->faultcode . ']' . $s->faultstring);
} catch (Exception $e) {
    die('Error:' . $e->getMessage());
}
?>