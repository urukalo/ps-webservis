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
    $klijent->setWsdlCache(false);
    $admin = new Zend_Soap_Client(null, $opcije_admin);

    $stanicaIzlazna = $klijent->stanicaIzlazna(1);
    //  print_r("<br/><pre>".$klijent->getLastResponse()."</pre><br/>");
    var_dump($stanicaIzlazna);
    foreach ($stanicaIzlazna as $stanica) {
        $izlazneStanice[$stanica->_idStanica] = $stanica->_naziv;
    }
    echo"<br>";
    var_dump($izlazneStanice);


    echo"<br> === voznje -===<br/>";
    $idUlazna = 1;
    $idIzlazna = 2;
    $dan = 1; //radni dan
    $trase = $klijent->pronadjiRutu($idUlazna, $idIzlazna, $dan);
    //print_r("<br/><pre>".$klijent->getLastResponse()."</pre><br/>");
    var_dump($trase);


    echo"<br> === jedna voznja -===<br/>";
    $idVoznje = 1;

    $voznja = $klijent->getVoznja($idVoznje);

    var_dump($voznja);

    echo"<br> === popusti -===<br/>";


    $popusti = $klijent->popusti();

    var_dump($popusti);

    echo"<br> === cuvanje karte -===<br/>";
    $datum = "26/12/2013";
    $date = date_parse_from_format('d/m/Y', $datum);
    $vremePolaska = mktime(0, 0, 0, $date['month'], $date['day'], $date['year']);

    $data = array(
        // 'idKarta' => 1,
        'idTrasa' => $idVoznje,
        'idPopust' => $popusti[0]->_idPopust,
        'idStanicaPolaska' => 1,
        'idStanicaDolaska' => $stanicaIzlazna[1]->_idStanica,
        'vremePolaska' => $vremePolaska,
        'cena' => 500,
        'aktivnost' => 1,
        'povratna' => 1
    );
    $karta = (object) $data;

    echo "<br/> nova karta: ";
    print_r($karta);

    echo "<br/> sacuvaj kartu: ";
    print_r($klijent->sacuvajKartu($karta));
    echo "<br/> pronadji kartu: ";
    print_r($klijent->pronadjiKartu(1));
     echo "<br/> cena karte: ";
    print_r($klijent->izracunajCenuKarte(1, 1, 3, 1, 1));
    //print_r($klijent->nazivStanice(1));

//    foreach ($trase as $value) {
//        var_dump($value);
//    }
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

    echo "<br/> red voznje: ";
    $r = $admin->deactivate(16);
    print_r($r);
} catch (SoapFault $s) {
    die('Error[' . $s->faultcode . ']' . $s->faultstring);
} catch (Exception $e) {
    die('Error:' . $e->getMessage());
}
?>
