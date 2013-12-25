<?php

class AdminController extends Zend_Controller_Action
{

    public function init()
    {
        /* Initialize action controller here */
    }

    public function indexAction(){
        // action body
        $this->soapAction();
    }

    public function soapAction() {
        // action body
        $this->_helper->viewRenderer->setNoRender(true);
        //$this->_helper->layout()->disableLayout();

        $server = new Zend_Soap_Server(null, array('uri' => 'http://ps/admin'));

        $server->setClass('Ekarta_Admin');
        $server->registerFaultException(array('Ekarta_Exception'));

        $server->handle();
    }

    public function wsdlAction() {
        // action body
        $this->_helper->viewRenderer->setNoRender(true);
        //$this->_helper->layout()->disableLayout();
        $wsdl = new Zend_Soap_AutoDiscover('Zend_Soap_Wsdl_Strategy_ArrayOfTypeComplex');
        //$wsdl = new Zend_Soap_AutoDiscover(new Zend_Soap_Wsdl_Strategy_ArrayOfTypeComplex());
//        $wsdl->setOperationBodyStyle(array('use' => 'literal'));
//        $wsdl->setBindingStyle(array('style' => 'document'));

        $wsdl->setClass('Ekarta_Admin');
        
        $wsdl->setUri('http://ps/Admin');

        $wsdl->handle();
    }

}





