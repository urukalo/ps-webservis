<?php

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */


try {
    $wsdl_url = 'http://ps/Index/wsdl';
    $client = new SOAPClient($wsdl_url);
    $params = array(
    );
    $return = $client->getKarta($params);
    var_dump($return);
} catch (Exception $e) {
    echo "Exception occured: " . $e;
}

try {
    $wsdl_url = 'http://ps/Index/wsdl';
    $client = new SOAPClient($wsdl_url);
    $params = array(
    );
    $return = $client->getRedVoznje($params);
    print_r($return);
} catch (Exception $e) {
    echo "Exception occured: " . $e;
}

try {
    $wsdl_url = 'http://ps/Index/wsdl';
    $client = new SOAPClient($wsdl_url);
    $params = array(
    );
    $return = $client->popusti($params);
    print_r($return);
} catch (Exception $e) {
    echo "Exception occured: " . $e;
}

try {
    $wsdl_url = 'http://ps/Index/wsdl';
    $client = new SOAPClient($wsdl_url);
    $params = array(
        'id' => "0",
    );
    $return = $client->pronadjiKartu($params);
    print_r($return);
} catch (Exception $e) {
    echo "Exception occured: " . $e;
}

try {
    $wsdl_url = 'http://ps/Index/wsdl';
    $client = new SOAPClient($wsdl_url);
    $params = array(
        'string' => "",
    );
    $return = $client->proveriVoznju($params);
    print_r($return);
} catch (Exception $e) {
    echo "Exception occured: " . $e;
}

try {
    $wsdl_url = 'http://ps/Index/wsdl';
    $client = new SOAPClient($wsdl_url);
    $params = array(
    );
    $return = $client->stanicaUlazna($params);
    print_r($return);
} catch (Exception $e) {
    echo "Exception occured: " . $e;
}
