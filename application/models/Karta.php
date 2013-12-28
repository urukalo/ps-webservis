<?php

class Application_Model_Karta
{
    /**
     *
     * @var int
     */
    public $_idKarta;
    /**
     *
     * @var int
     */
    public $_idTrasa;
    /**
     *
     * @var int
     */
    public $_idStanicaPolaska;
    /**
     *
     * @var int
     */
    public $_idStanicaDolaska;
    /**
     *
     * @var int
     */
    public $_vremePolaska;
    /**
     *
     * @var int
     */
    public $_idPopust;
    /**
     *
     * @var string
     */
    public $_naznakaPopusta;
    /**
     *
     * @var int
     */
    public $_povratna;
    /**
     *
     * @var int
     */
    public $_cena;
    /**
     *
     * @var int
     */
    public $_aktivnost;
    
    public function getId() {
        return $this->_idKarta;
    }
    public function setId($data) {
        $this->_idKarta=$data;
        return $this;
    }
	
    public function getTrasa() {
        return $this->_idTrasa;
    }
    public function setTrasa($data) {
        $this->_idTrasa=$data;
        return $this;
    }
	
    public function getStanicaPolaska() {
        return $this->_idStanicaPolaska;
    }
    public function setStanicaPolaska($data) {
        $this->_idStanicaPolaska=$data;
        return $this;
    }
	
    public function getStanicaDolaska() {
        return $this->_idStanicaDolaska;
    }
    public function setStanicaDolaska($data) {
        $this->_idStanicaDolaska=$data;
        return $this;
    }
	
    public function getVremePolaska() {
        return $this->_vremePolaska;
    }
    public function setVremePolaska($data) {
        $this->_vremePolaska=$data;
        return $this;
    }
	
    public function getPopust() {
        return $this->_idPopust;
    }
    public function setPopust($data) {
        $this->_idPopust=$data;
        return $this;
    }
	
    public function getNaznakaPopust() {
        return $this->_naznakaPopusta;
    }
    public function setNaznakaPopust($data) {
        $this->_naznakaPopusta=$data;
        return $this;
    }
	
    public function getPovratna() {
        return $this->_povratna;
    }
    public function setPovratna($data) {
        $this->_povratna=$data;
        return $this;
    }
	
    public function getCena() {
        return $this->_cena;
    }
    public function setCena($data) {
        $this->_cena=$data;
        return $this;
    }
	
    public function getAktivnost() {
        return $this->_aktivnost;
    }
    public function setAktivnost($data) {
        $this->_aktivnost=$data;
        return $this;
    }
}

