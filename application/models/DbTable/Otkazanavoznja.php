<?php

class Application_Model_DbTable_Otkazanavoznja extends Zend_Db_Table_Abstract
{
    protected $_name = 'otkazanavoznja';
    protected $_primary = 'idOtkazanaVoznja';
     protected $_referenceMap=array(
        'Trasa'=>array(
            'columns'=>array('idTrasa'),
            'refTableClass'=>'Application_Model_DbTable_Trasa',
            'refColumns'=>array('idTrasa')
        )
    );
}

