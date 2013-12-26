<?php

class Application_Model_Stanica
{
    /**
     *
     * @var int
     */
    public $idStanica;
    /**
     *
     * @var string
     */
    public $naziv;
    
    public function getId() {
        return $this->idStanica;
    }
    public function setId($data) {
        $this->idStanica=$data;
        return $this;
    }
	
    public function getNaziv() {
        return $this->naziv;
    }
    public function setNaziv($data) {
        $this->naziv=$data;
        return $this;
    }
}

