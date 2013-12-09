<?php

class Application_Model_Karta
{
    protected $_idKarta;
    protected $_idTrasa;
    protected $_idStanicaPolaska;
    protected $_idStanicaDolaska;
    protected $_vremePolaska;
    protected $_idPopust;
    protected $_naznakaPopusta;
    protected $_povratna;
    protected $_cena;
    protected $_aktivnost;
    
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

