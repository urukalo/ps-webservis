<?php

class Application_Model_DbTable_Popust extends Zend_Db_Table_Abstract
{
    protected $_name = 'popusti';
    protected $_primary = 'idPopust';
    protected $_dependentTables=array('Application_Model_DbTable_Karta');
}

