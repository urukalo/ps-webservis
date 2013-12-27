<?php

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * Description of Admin
 * 
 * @author Boske
 */
class Ekarta_Admin {

    private $_popust, $_karta, $_stanica, $_trasa, $_redVoznje, $_otkazanaVoznja, $_trasaStanica;

    /**
     * 
     */
    function Ekarta_Admin() {
        $this->_popust = new Application_Model_Popust();
        $this->_karta = new Application_Model_Karta();
        $this->_stanica = new Application_Model_Stanica();
        $this->_trasa = new Application_Model_Trasa();
        $this->_redVoznje = new Application_Model_Redvoznje();
        $this->_otkazanaVoznja = new Application_Model_Otkazanavoznja();
        $this->_trasaStanica = new Application_Model_TrasaStanica();
    }

    #---------------------------- Popust ----------------------------#

    /**
     * 
     * @param string $object
     */
    public function setPopust($object) {
        $array= explode('_', $object);
        $this->_popust->setId();
        $this->_popust->setNaziv();
        $this->_popust->setProcenat();
        $mapper = new Application_Model_PopustMapper();
        $mapper->save($this->_popust);
    }
    /**
     * 
     * @param int $id
     * @return string
     */
    public function getPopust($id) {
        $mapper = new Application_Model_PopustMapper();
        if ($id == 0) {
            return $mapper->dohvatiSve();
        }
        return $mapper->dohvatiJedan($id);
    }
    /**
     * 
     * @param Application_Model_Popust $object
     */
    public function unsetPopust($object) {
        $mapper = new Application_Model_PopustMapper();
        $mapper->delete($object->idPopust);
    }

    #---------------------------- Karta ----------------------------#

    /**
     * 
     * @param string $object
     * @return string
     */
    public function setKarta($object) {
        $array= explode('_', $object);
        $vreme= explode('-', $array[4]);
        $vremePolaska=  mktime($vreme[3], $vreme[4], 0, $vreme[1], $vreme[0], $vreme[2]);
        $this->_karta->setTrasa($array[0])
                ->setPopust($array[1])
                ->setStanicaPolaska($array[2])
                ->setStanicaDolaska($array[3])
                ->setVremePolaska($vremePolaska)
                ->setPovratna($array[5])
                ->setAktivnost(1)
                ->setCena($array[6]);
        $mapper = new Application_Model_KartaMapper();
        return $mapper->save($this->_karta);
    }

    /**
     * 
     * @param int $id
     * @return string
     */
    public function getKarta($id) {
        $mapper = new Application_Model_KartaMapper();
        return $mapper->dohvatiJedan($id);
    }

    /**
     * 
     * @param int $idKarta
     */
    public function unsetKarta($idKarta) {
        $mapper = new Application_Model_KartaMapper();
        $mapper->delete($idKarta);
    }

    /**
     * 
     * @param int $id
     */
    public function deactivate($id) {
        $mapper = new Application_Model_KartaMapper();
        $mapper->deaktiviraj($id);
    }
    /**
     * 
     * @param int $id
     */
    public function activate($id) {
        $mapper = new Application_Model_KartaMapper();
        $mapper->aktiviraj($id);
    }
    /**
     * 
     * @param int $idTrasa
     * @param int $idPolazneStanice
     * @param int $idDolazneStanice
     * @param int $idPopust
     * @param int $povratna
     * @return string
     */
    public function izracunajCenuKarte($idTrasa,$idPolazneStanice,$idDolazneStanice,$idPopust,$povratna){
        $mapper = new Application_Model_KartaMapper();
        return (string)$mapper->izracunajCenu($idTrasa,$idPolazneStanice,$idDolazneStanice,$idPopust,$povratna);
    }

    #---------------------------- Stanica ----------------------------#

    /**
     * 
     * @param string $object
     * @return int laste inserted id
     */
    public function setStanica($object) {
        $array= explode('_', $object);
        $this->_stanica->setNaziv($array[0]);
        if($array[1]!=0){
            $this->_stanica->setId($array[1]);
        }
        $mapper = new Application_Model_StanicaMapper();
        $lastId=$mapper->save($this->_stanica);
        return $lastId;
    }

    /**
     * Dohvata sve stanice
     * @return string
     */
    public function getStanice() {
        $mapper = new Application_Model_StanicaMapper();
        return $mapper->dohvatiSveAdmin();
    }
    /**
     * 
     * @param int $id
     * @return Application_Model_Stanica
     */
    public function getStanicu($id) {
        $mapper = new Application_Model_StanicaMapper();
        return json_encode($mapper->dohvatiJedan($id));
    }
    
    /**
     * 
     * @param int $id
     */
    public function unsetStanica($id) {
        $mapper = new Application_Model_StanicaMapper();
        $mapper->delete($id);
    }

    #---------------------------- Trasa ----------------------------#

    /**
     * 
     * @param string $object
     */
    public function setTrasa($object) {
        $array= explode("_", $object);
        if(!empty($array[3])){
            $this->_trasa->setId($array[3]);
        }
        $this->_trasa->setStanicaPolaska($array[0]);
        $this->_trasa->setStanicaDolaska($array[1]);
        $this->_trasa->setUkupnoKm($array[2]);
        $mapper = new Application_Model_TrasaMapper();
        $mapper->save($this->_trasa);
    }
    /**
     * 
     * @return string
     */
    public function getTrase() {
        $mapper = new Application_Model_TrasaMapper();
        return $mapper->dohvatiSveAdmin();
    }
    
    /**
     * 
     * @param int $id
     * @return string
     */
    public function getTrasu($id) {
        $mapper = new Application_Model_TrasaMapper();
        return $mapper->dohvatiJedanAdmin($id);
    }
    
    /**
     * 
     * @param int $id
     */
    public function unsetTrasa($id) {
        $mapper = new Application_Model_TrasaMapper();
        $mapper->delete($id);
        $mapperTrasaStanica= new Application_Model_TrasastanicaMapper();
        $mapperTrasaStanica->delete($id);
    }

    #---------------------------- Red voznje ----------------------------#

    /**
     * 
     * @param string $object
     */
    public function setRedVoznje($object) {
        $array= explode("_", $object);
        
        $this->_redVoznje->setTrasa($array[0]);
        $this->_redVoznje->setDan($array[1]);
        $vreme=$array[2].":".$array[3];
        $this->_redVoznje->setVremePolaska($vreme);
        if(!empty($array[4])){
            $this->_redVoznje->setId($array[4]);
        }
        $mapper = new Application_Model_RedvoznjeMapper();
        $mapper->save($this->_redVoznje);
    }
    /**
     * 
     * @return string
     */
    public function getRedVoznje() {
        $mapper = new Application_Model_RedvoznjeMapper();
        return $mapper->dohvatiSveAdmin();
    }
    /**
     * 
     * @param int $id
     * @return string
     */
    public function getJedanRedVoznje($id) {
        $mapper = new Application_Model_RedvoznjeMapper();
        return $mapper->dohvatiJedanAdmin($id);
    }
    /**
     * 
     * @param int $idTrasa
     * @param int $dan
     * @param string $vreme
     * @return boolean
     */
    public function proveraDaLiPostoji($idTrasa,$dan,$vreme) {
        $mapper = new Application_Model_RedvoznjeMapper();
        return $mapper->proveriDaLiPostoji($idTrasa, $dan, $vreme);
    }
    /**
     * 
     * @param int $id
     */
    public function unsetRedVoznje($id) {
        $mapper = new Application_Model_RedvoznjeMapper();
        $mapper->delete($id);
    }

    #---------------------------- Otkazana voznja ----------------------------#

    /**
     * 
     * @param string $object
     */
    public function setOtkazanaVoznja($object) {
        $array= explode("_", $object);
        if(!empty($array[6])){
            $this->_otkazanaVoznja->setId($array[6]);
        }
        $this->_otkazanaVoznja->setTrasa($array[0]);
        $this->_otkazanaVoznja->setDatum(mktime(0, 0, 0, $array[2], $array[1], $array[3]));
        $this->_otkazanaVoznja->setVreme($array[4].":".$array[5]);
        $mapper = new Application_Model_OtkazanavoznjaMapper();
        $mapper->save($this->_otkazanaVoznja);
    }
    /**
     *  
     * @return string
     */
    public function getOtkazaneVoznje() {
        $mapper = new Application_Model_OtkazanavoznjaMapper();
        return $mapper->dohvatiSveAdmin();
    }
    /**
     * 
     * @param int $id
     * @return string
     */
    public function getOtkazanaVoznja($id) {
        $mapper = new Application_Model_OtkazanavoznjaMapper();
        return $mapper->dohvatiJedanAdmin($id);
    }
    /**
     * 
     * @param int $id
     */
    public function unsetOtkazanaVoznja($id) {
        $mapper = new Application_Model_OtkazanavoznjaMapper();
        $mapper->delete($id);
    }

    #---------------------------- Trasa stanica ----------------------------#

    /**
     * 
     * @param string $object
     */
    public function setTrasaStanica($object) {
        $array= explode("_", $object);
        $idStanica=$this->setStanica($array[0]."_".$array[4]);
        $this->_trasaStanica->setTrasa($array[1]);
        $this->_trasaStanica->setStanica($idStanica);
        $this->_trasaStanica->setKmOd($array[2]);
        $this->_trasaStanica->setKmDo($array[3]);
        $this->_trasaStanica->setId($array[5]);
        $mapper = new Application_Model_TrasastanicaMapper();
        $mapper->save($this->_trasaStanica);
    }
    /**
     * 
     * @return string
     */
    public function getTrasaStanice() {
        $mapper = new Application_Model_TrasastanicaMapper();
        return $mapper->dohvatiSveAdmin();
    }
    /**
     * 
     * @param int $id
     * @return string
     */
    public function getTrasaStanica($id) {
        $mapper = new Application_Model_TrasastanicaMapper();
        return $mapper->dohvatiJedanAdmin($id);
    }
    /**
     * 
     * @param int $id
     */
    public function unsetTrasaStanica($id) {
        $mapper = new Application_Model_TrasastanicaMapper();
        $mapper->delete($id);
    }
    /**
     * 
     * @param int $idTrasa
     * @return string
     */
    public function getStaniceZaTrasu($idTrasa){
        $mapper= new Application_Model_TrasastanicaMapper();
        return $mapper->dohvatiSveNaTrasi($idTrasa);
    }
    /**
     * 
     * @param int $idTrasa
     * @param int $idStanica
     * @return string
     */
    public function getStaniceZaTrasuPosle($idTrasa,$idStanica){
        $mapper= new Application_Model_TrasastanicaMapper();
        return $mapper->dohvatiSveNaTrasiPosle($idTrasa,$idStanica);
    }
    /**
     * 
     * @param string $object
     * @return string
     */
    public function getVremeZaDatum($object) {
        $array= explode('_', $object);
        $mapper= new Application_Model_RedvoznjeMapper();
        return $mapper->dohvatiZaStanice($array[0],$array[1],$array[2],$array[3]);
    }
}
