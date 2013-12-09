<?php

class Application_Model_DbTable_Karta extends Zend_Db_Table_Abstract
{
    protected $_name = 'karta';
    protected $_primary = 'idKarta';
    protected $_referenceMap=array(
        'Trasa'=>array(
            'columns'=>array('idTrasa'),
            'refTableClass'=>'Application_Model_DbTable_Trasa',
            'refColumns'=>array('idTrasa')
        ),
        'Trasastanica'=>array(
            'columns'=>array('idStanicaPolaska','idStanicaDolaska'),
            'refTableClass'=>'Application_Model_DbTable_Trasastanica',
            'refColumns'=>array('idTrasaStanica')
        ),
        'Popust'=>array(
            'columns'=>array('idPopust'),
            'refTableClass'=>'Application_Model_DbTable_Popust',
            'refColumns'=>array('idPopust')
        )
    );
}

