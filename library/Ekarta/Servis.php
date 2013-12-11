<?php

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * Description of Servis
 *
 * @author Miki
 */
class Ekarta_Servis {
    //put your code here

    /**
     *
     * @var Application_Model_Karta
     */
    public $karta;

    /**
     *
     * @var Application_Model_Redvoznje
     */
    public $redVoznje;

    /**
     *
     * @var Application_Model_Stanica
     */
    public $stanica;

    /**
     *
     * @var Application_Model_Popusti
     */
    public $popusti;

    /**
     *
     * @var Application_Model_Trasa
     */
    public $trasa;
    private $kartaMaper, $stanicaMaper, $redVoznjeMaper;

    public function Ekarta_Servis() {
        $this->karta = new Application_Model_Karta();
        $this->redVoznje = new Application_Model_Redvoznje();
        $this->stanica = new Application_Model_Stanica();
        $this->popusti = new Application_Model_Popust();
        $this->trasa = new Application_Model_Trasa();

        $this->kartaMaper = new Application_Model_KartaMapper();
    }

    // ============= RAD SA KARTOM ==================   

    /**
     * 
     * @return Application_Model_Karta
     */
    public function getKarta() {
        return $this->karta;
    }

    /**
     * 
     * @param Application_Model_Karta $object
     */
    public function sacuvajKartu($object) {
        $this->_karta = new Application_Model_Karta();
        #---- Stavio sam u tri reda samo zbog preglednosti u NetBeans-u ----#
        $this->_karta->setId($object->idKarta)
                ->setTrasa($object->idTrasa)
                ->setStanicaPolaska($object->idStanicaPolaska)
                ->setStanicaDolaska($object->idStanicaDolaska)
                ->setVremePolaska($object->vremePolaska)
                ->setCena($object->cena)
                ->setPopust($object->idPopust)
                ->setNaznakaPopust($object->naznakaPopusta)
                ->setAktivnost($object->aktivnost);
        $mapper = new Application_Model_KartaMapper();
        
        try {
            $mapper->save($this->_karta);
        } catch (Exception $exc) {
            throw new Ekarta_Exception("Nije uspelo cuvanje karte: ". $exc->getMessage());
        }
        
    }

    /**
     * 
     * @param int $id
     * @return Application_Model_Karta $karta
     */
    public function pronadjiKartu($id) {
        if (!Zend_Validate::is($id, 'Int')) {
            throw new Ekarta_Exception('Invalid input');
        }
        return $this->kartaMaper->dohvatiJedan($id);
    }

    /**
     * 
     * @param int $id
     */
    public function otkaziKartu($id) {
        $this->kartaMaper->delete($id);
    }

// ============= RAD SA Popustima ==================   

    /**
     * 
     * @return string
     */
    public function popusti() {
        $popusti = "studenski#penzionerski#invalidski";
        return $popusti;
    }

    /**
     * 
     * @return Application_Model_Redvoznje
     */
    public function getRedVoznje() {
        return $this->redVoznje;
    }

    /**
     * 
     * @param string $string
     * @return boolean
     */
    public function proveriVoznju($string) {
        if ("otkazana" == true)
            return false;
        return true;
    }

}
