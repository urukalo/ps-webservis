<?php


/**
 *  OVO TREBA PREBACITI U ORM !!!
 *
 * @author Miki
 */
class Ekarta_Karta {
    //put your code here
    
    /**
     *
     * @var int 
     */
    public $id;
    /**
     *
     * @var int 
     */
    public $datumVoznje;
    /**
     *
     * @var string 
     */
    public $status;
    
    /**
     * konstruktor
     */
    public function Ekarta_Karta()
    {
        $this->status = "nova karta";
        
    }
    /**
     * Vraca id karte
     * @return int
     */
    public function getId(){
        return $this->id;
    }

    /**
     * 
     * @return Ekarta_ddlData[]
     */
    public function getPopust() {
//        $a = new stdClass();
//        $a->a = "student";
//        $a->b = "penzioner";
        //$a = array("a" => "student", "b" => "penzioner");
        //$a = "student#penzioner";
        $a[]=new Ekarta_ddlData("0", 'student');
        return $a;
    }
    
    /**
     * vraca objekat tipa karte
     * @return Ekarta_Karta
     */
    public function kreirajKartu(){
        
        return new Ekarta_Karta();
    }

    /**
     * Cuva kartu na osnovu niza podataka
     * @param Ekarta_Karta $karta
     * @return boolean
     */
    public function sacuvajKartu($karta) {
        $karta->status = "sacuvano";
        return true;
    }
   /**
    * Pronalazi kartu na osnovu id-a
    * @param int $id
    * @return object
    */
    public function pronadjiKartu($id) {
        $this->id=$id;
        return $this;
    }
   
    /**
     * 
     * @param int $id
     * @return boolean
     */
    public function otkaziKartu($id){
        return true;
    }
}
