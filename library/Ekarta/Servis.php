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
     * @var Ekarta_karta
     */
    public $karta;
    
    /**
     *
     * @var Ekarta_RedVoznje
     */
    public $redVoznje;
    
    /**
     *
     * @var Ekarta_Admin
     */
    public $admin;
    
        
    public function Ekarta_Servis() {
        $this->karta = new Ekarta_Karta();
        $this->redVoznje = new Ekarta_RedVoznje();
        $this->admin = new Ekarta_Admin();
    }
    
    /**
     * 
     * @return Ekarta_karta
     */
    public function getKarta(){
        return $this->karta;
    }
    
    /**
     * 
     * @param Ekarta_karta $karta
     * @return boolean
     */
    public function sacuvajKartu($karta){
        return $this->karta->sacuvajKartu($karta);
    }
    
    /**
     * 
     * @param int $id
     * @return Ekarta_karta
     */
    public function pronadjiKartu($id){
        return $this->karta->pronadjiKartu($id);
    }

    /**
     * 
     * @param int $id
     * @return boolean
     */
    public function otkaziKartu($id){
        
        return true;
    }
    
    /**
     * 
     * @return string Ekarta_ddlData
     */
    public function popusti(){
        //$popusti = new Ekarta_ddlData('0','studentski');
        $popusti = "studenski#penzionerski#invalidski";
        return $popusti;
    }
    
    /**
     * 
     * @return Ekarta_RedVoznje
     */
    public function getRedVoznje(){
        return $this->redVoznje;
    }
    
    /**
     * 
     * @param string $string
     * @return boolean
     */
    public function proveriVoznju($string){
        if("otkazana" == true)
            return false;
        return true;
    }
    
    
    
}
