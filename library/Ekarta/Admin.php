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
class Ekarta_Admin{
    
    private $_popust, $_karta, $_stanica, $_trasa, $_redVoznje, $_otkazanaVoznja, $_trasaStanica;
    
    function Ekarta_Admin() {
        $this->_popust=new Application_Model_Popust();
        $this->_karta=new Application_Model_Karta();
        $this->_stanica=new Application_Model_Stanica();
        $this->_trasa=new Application_Model_Trasa();
        $this->_redVoznje=new Application_Model_Redvoznje();
        $this->_otkazanaVoznja=new Application_Model_Otkazanavoznja();
        $this->_trasaStanica=new Application_Model_TrasaStanica();
    }
    
    #---------------------------- Popust ----------------------------#
    
    public function setPopust($object){
        $this->_popust->setId($object->idPopust);
        $this->_popust->setNaziv($object->naziv);
        $this->_popust->setProcenat($object->procenat);
        $mapper= new Application_Model_PopustMapper();
        $mapper->save($popust);
    }
    public function getPopust($id=0){
        $mapper= new Application_Model_PopustMapper();
        if($id===0){
            return $mapper->dohvatiSve();
        }
        return $mapper->dohvatiJedan($id);
    }
    public function unsetPopust($object){
        $mapper= new Application_Model_PopustMapper();
        $mapper->delete($object->id);
    }
  
    #---------------------------- Karta ----------------------------#
    public function setKarta($object){
        $this->_karta= new Application_Model_Karta();
        #---- Stavio sam u tri reda samo zbog preglednosti u NetBeans-u ----#
        $this->_karta->setId($object->idKarta)->setTrasa($object->idTrasa)->setStanicaPolaska($object->idStanicaPolaska);
        $this->_karta->setStanicaDolaska($object->idStanicaDolaska)->setVremePolaska($object->vremePolaska)->setCena($object->cena);
        $this->_karta->setPopust($object->idPopust)->setNaznakaPopust($object->naznakaPopusta)->setAktivnost($object->aktivnost);
        $mapper= new Application_Model_KartaMapper();
        $mapper->save($this->_karta);
    }
    public function getKarta($id=0){
        $mapper= new Application_Model_KartaMapper();
        if($id===0){
            return $mapper->dohvatiSve();
        }
        return $mapper->dohvatiJedan($id);
    }
    public function unsetKarta($object){
        $mapper= new Application_Model_KartaMapper();
        $mapper->delete($object->id);
    }
    public function deactivate($id){
        $mapper= new Application_Model_KartaMapper();
        $mapper->deaktiviraj($id);
    }
    
    #---------------------------- Stanica ----------------------------#
    
    public function setStanica($object) {
        $this->_stanica->setId($object->idStanica);
        $this->_stanica->setNaziv($object->naziv);
        $mapper= new Application_Model_StanicaMapper();
        $mapper->save($this->_stanica);
    }
    public function getStanica($id) {
         $mapper= new Application_Model_StanicaMapper();
         if($id===0){
             return $mapper->dohvatiSve();
         }
         return $mapper->dohvatiJedan($id);
    }
    public function unsetStanica($object){
        $mapper= new Application_Model_StanicaMapper();
        $mapper->delete($object->id);
    }
    #---------------------------- Trasa ----------------------------#
    
    public function setTrasa($object) {
        $this->_trasa->setId($object->idTrasa);
        $this->_trasa->setStanicaPolaska($object->stanicaPolaska);
        $this->_trasa->setStanicaDolaska($object->stanicaDolaska);
        $this->_trasa->setUkupnoKm($object->ukupnoKm);
        $mapper= new Application_Model_TrasaMapper();
        $mapper->save($this->_trasa);
    }
    public function getTrasa($id=0) {
        $trasaMapper= new Application_Model_TrasaMapper();
        if($id===0){
            return $mapper->dohvatiSve();
        }
        return $mapper->dohvatiJedan($id);
    }
    public function unsetTrasa($object) {
        $mapper= new Application_Model_TrasaMapper();
        $mapper->delete($object->id);
    }
    
    #---------------------------- Red voznje ----------------------------#
    
    public function setRedVoznje($object) {
        $this->_redVoznje->setId($object->idRedVoznje);
        $this->_redVoznje->setTrasa($object->idTrasa);
        $this->_redVoznje->setDan($object->dan);
        $this->_redVoznje->setVremePolaska($object->vremePolaska);
        $mapper= new Application_Model_RedvoznjeMapper();
        $mapper->save($this->_redVoznje);
    }
    public function getRedVoznje($id=0) {
        $mapper= new Application_Model_RedvoznjeMapper();
        if($id===0){
            return $mapper->dohvatiSve();
        }
        return $mapper->dohvatiJedan($id);
    }
    public function unsetRedVoznje($object){
        $mapper= new Application_Model_RedvoznjeMapper();
        $mapper->delete($object->id);
    }
    
    #---------------------------- Otkazana voznja ----------------------------#
    
    public function setOtkazanaVoznja($object) {
        $this->_otkazanaVoznja->setId($object->idOtkazanaVoznja);
        $this->_otkazanaVoznja->setTrasa($object->idTrasa);
        $this->_otkazanaVoznja->setDatum($object->datum);
        $this->_otkazanaVoznja->setVreme($object->vreme);
        $mapper= new Application_Model_OtkazanavoznjaMapper();
        $mapper->save($this->_otkazanaVoznja);
    }
    public function getOtkazanaVoznja($id=0) {
        $mapper= new Application_Model_OtkazanavoznjaMapper();
        if($id===0){
            return $mapper->dohvatiSve();
        }
        return $mapper->dohvatiJedan($id);
    }
    public function unsetOtkazanaVoznja($object) {
        $mapper= new Application_Model_OtkazanavoznjaMapper();
        $mapper->delete($object->id);
    }
    
    #---------------------------- Trasa stanica ----------------------------#
    
    public function setTrasaStanica($object) {
        $this->_trasaStanica->setId($object->idTrasastanica);
        $this->_trasaStanica->setTrasa($object->idTrasa);
        $this->_trasaStanica->setStanica($object->idStanica);
        $this->_trasaStanica->setKmOd($object->kmOd);
        $this->_trasaStanica->setKmDo($object->kmDo);
        $mapper= new Application_Model_TrasastanicaMapper();
        $mapper->save($this->_trasaStanica);
    }
    public function getTrasaStanica($id=0) {
        $mapper= new Application_Model_TrasastanicaMapper();
        if($id===0){
            return $mapper->dohvatiSve();
        }
        return $mapper->dohvatiJedan($id);
    }
    public function unsetTrasaStanica($object) {
        $mapper= new Application_Model_TrasastanicaMapper();
        $mapper->delete($object->id);
    }
}