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
     * @return Ekarta_ddlData
     */
    public function popusti(){
        $popusti = new Ekarta_ddlData('0','studentski');
        return $popusti;
    }
}
