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
     * @return Application_Model_Popust[]
     */
//    public function getPopust($id = 0) {
//        $mapper = new Application_Model_PopustMapper();
//        if ($id === 0) {
//            return $mapper->dohvatiSve();
//        }
//        return array($mapper->dohvatiJedan($id));
//    }
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
     * @param Application_Model_Karta $object
     */
    public function setKarta($object) {
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
        $mapper->save($this->_karta);
    }

    /**
     * 
     * @param int $id
     * @return Application_Model_Karta[]
     */
//    public function getKarta($id = 0) {
//        $mapper = new Application_Model_KartaMapper();
//        if ($id === 0) {
//            return $mapper->dohvatiSve();
//        }
//        return array($mapper->dohvatiJedan($id));
//    }

    /**
     * 
     * @param Application_Model_Karta $object
     */
    public function unsetKarta($object) {
        $mapper = new Application_Model_KartaMapper();
        $mapper->delete($object->idKarta);
    }

    /**
     * 
     * @param int $id
     */
    public function deactivate($id) {
        $mapper = new Application_Model_KartaMapper();
        $mapper->deaktiviraj($id);
    }

    #---------------------------- Stanica ----------------------------#

    /**
     * 
     * @param string $object
     */
    public function setStanica($object) {
        $array= explode('_', $object);
        //$this->_stanica->setId($object->idStanica);
        $this->_stanica->setNaziv($array[0]);
        $mapper = new Application_Model_StanicaMapper();
        $lastId=$mapper->save($this->_stanica);
        $object->idStanica=$lastId;
        //$this->setTrasaStanica($array);
    }

    /**
     * 
     * @param int $id
     * @return Application_Model_Stanica[]
     */
//    public function getStanica($id) {
//        $mapper = new Application_Model_StanicaMapper();
//        if ($id === 0) {
//            return $mapper->dohvatiSve();
//        }
//        return array($mapper->dohvatiJedan($id));
//    }

    /**
     * 
     * @param Application_Model_Stanica $object
     */
    public function unsetStanica($object) {
        $mapper = new Application_Model_StanicaMapper();
        $mapper->delete($object->idStanica);
        $this->unsetStanica($object);
    }

    #---------------------------- Trasa ----------------------------#

    /**
     * 
     * @param string $object
     */
    public function setTrasa($object) {
        $array= explode("_", $object);
        $this->_trasa->setId($object->idTrasa);
        $this->_trasa->setStanicaPolaska($object->stanicaPolaska);
        $this->_trasa->setStanicaDolaska($object->stanicaDolaska);
        $this->_trasa->setUkupnoKm($object->ukupnoKm);
        $mapper = new Application_Model_TrasaMapper();
        $mapper->save($this->_trasa);
    }
    /**
     * 
     * @param int $id
     * @return Application_Model_Trasa[]
     */
//    public function getTrasa($id = 0) {
//        $mapper = new Application_Model_TrasaMapper();
//        if ($id === 0) {
//            return $mapper->dohvatiSve();
//        }
//        return array($mapper->dohvatiJedan($id));
//    }
    /**
     * 
     * @param Application_Model_Trasa $object
     */
    public function unsetTrasa($object) {
        $mapper = new Application_Model_TrasaMapper();
        $mapper->delete($object->idTrasa);
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
        $this->_redVoznje->setVremePolaska($array[2].":".$array[3]);
        if(!empty($array[4])){
            $this->_redVoznje->setId($array[4]);
        }
        $mapper = new Application_Model_RedvoznjeMapper();
        $mapper->save($this->_redVoznje);
    }
    /**
     * 
     * @return Application_Model_Redvoznje[]
     */
//    public function getRedVoznje($id) {
//        $mapper = new Application_Model_RedvoznjeMapper();
//        return $mapper->dohvatiSve();
//    }
    /**
     * 
     * @param int $id
     * @return Application_Model_Redvoznje
     */
    public function getJedanRedVoznje($id) {
        $mapper = new Application_Model_RedvoznjeMapper();
        return $mapper->dohvatiJedan($id);
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
     * @param Application_Model_Redvoznje $object
     */
    public function unsetRedVoznje($object) {
        $mapper = new Application_Model_RedvoznjeMapper();
        $mapper->delete($object->idRedVoznje);
    }

    #---------------------------- Otkazana voznja ----------------------------#

    /**
     * 
     * @param string $object
     */
    public function setOtkazanaVoznja($object) {
        $array= explode("_", $object);
        $this->_otkazanaVoznja->setId($object->idOtkazanaVoznja);
        $this->_otkazanaVoznja->setTrasa($object->idTrasa);
        $this->_otkazanaVoznja->setDatum($object->datum);
        $this->_otkazanaVoznja->setVreme($object->vreme);
        $mapper = new Application_Model_OtkazanavoznjaMapper();
        $mapper->save($this->_otkazanaVoznja);
    }
    /**
     * 
     * @param int $id
     * @return Application_Model_Otkazanavoznja[]
     */
//    public function getOtkazanaVoznja($id = 0) {
//        $mapper = new Application_Model_OtkazanavoznjaMapper();
//        if ($id === 0) {
//            return $mapper->dohvatiSve();
//        }
//        return array($mapper->dohvatiJedan($id));
//    }
    /**
     * 
     * @param Application_Model_Otkazanavoznja $object
     */
    public function unsetOtkazanaVoznja($object) {
        $mapper = new Application_Model_OtkazanavoznjaMapper();
        $mapper->delete($object->idOtkazanaVoznja);
    }

    #---------------------------- Trasa stanica ----------------------------#

    /**
     * 
     * @param string $object
     */
    private function setTrasaStanica($object) {
        $array= explode("_", $object);
        $this->_trasaStanica->setId($object->idTrasastanica);
        $this->_trasaStanica->setTrasa($object->idTrasa);
        $this->_trasaStanica->setStanica($object->idStanica);
        $this->_trasaStanica->setKmOd($object->kmOd);
        $this->_trasaStanica->setKmDo($object->kmDo);
        $mapper = new Application_Model_TrasastanicaMapper();
        $mapper->save($this->_trasaStanica);
    }
    /**
     * 
     * @param int $id
     * @return Application_Model_Trasastanica[]
     */
//    public function getTrasaStanica($id = 0) {
//        $mapper = new Application_Model_TrasastanicaMapper();
//        if ($id === 0) {
//            return $mapper->dohvatiSve();
//        }
//        return array($mapper->dohvatiJedan($id));
//    }
    /**
     * 
     * @param Application_Model_Trasastanica $object
     */
    public function unsetTrasaStanica($object) {
        $mapper = new Application_Model_TrasastanicaMapper();
        $mapper->delete($object->idTrasaStanica);
    }

}
