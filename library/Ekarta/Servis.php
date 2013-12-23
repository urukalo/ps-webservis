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
    private $karta, $redVoznje, $stanica, $popusti, $trasa;
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
     * Vraca objekat karte
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
            return $mapper->save($this->_karta);
        } catch (Exception $exc) {
            throw new Ekarta_Exception("Nije uspelo cuvanje karte: " . $exc->getMessage());
        }
    }

    /**
     * Pronalazi kartu za dati idKarte i vraca objekat iste
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
     * Proglasava kartu neaktivnom
     * @param int $id
     */
    public function otkaziKartu($id) {
        $this->kartaMaper->deaktiviraj($id);
    }

// ============= RAD SA Popustima ==================   

    /**
     * vraca niz sa svim popustima
     * @return Application_Model_Popust[]
     */
    public function popusti() {
        $maper = new Application_Model_PopustMapper();
        try {
            $popusti = $maper->dohvatiSve();
        } catch (Exception $exc) {
            throw new Ekarta_Exception("Ne mogu da pokupim listu popusta" . $exc->getMessage());
        }

        //$popusti = "studenski#penzionerski#invalidski";
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
        //ajde samo da definisemo koje funkcije imamo i sta tacno rade,
        // ali to cemo na vezbama danas
        if ("otkazana" == true)
            return false;
        return true;
    }

    /**
     * 
     * @return Application_Model_Stanica[]
     */
    public function stanicaUlazna() {
        $maper = new Application_Model_StanicaMapper();
        try {
            //ako shvatam funkciju treba da se izlistaju samo pocetne stanice, tako da sam napravio f-ju u maperu
            // $idTrasa dolazi kroz funkciju
            //$sveStanice = $maper->dohvatiPocetne($idTrasa);
            $sveStanice = $maper->dohvatiSve();
        } catch (Exception $exc) {
            throw new Ekarta_Exception("Ne mogu da pokupim listu stanica" . $exc->getMessage());
        }

        return $sveStanice;
    }

    /**
     * @param int $ulaznaId
     * @return Application_Model_Stanica[]
     */
    public function stanicaIzlazna($ulaznaId) {
        $maper = new Application_Model_StanicaMapper();
        $trasastanicaMaper = new Application_Model_TrasastanicaMapper();
        $idTrasa = $trasastanicaMaper->dohvatiTrasu($ulaznaId);
        $stanice = $trasastanicaMaper->dohvatiSveNaTrasi($idTrasa);


        $stanice = $this->stanicaUlazna(); //privremeno  
        return $stanice;
    }

    public function pronadjiRutu(){
        
        
    }
}
