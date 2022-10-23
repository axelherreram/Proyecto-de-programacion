/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.GrupoNo2.service;

import com.GrupoNo2.Entity.Clientes;
import com.GrupoNo2.Entity.Factura;
import com.GrupoNo2.repo.facturasRepo;
import java.util.List;
import java.util.Optional;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

/**
 *
 * @author Axel
 */
@Service
public class FacturasService {
     @Autowired
    private facturasRepo factRepo;
     
    public Factura Ingresar(Factura emp){
        return factRepo.save(emp);
    }
    public List <Factura> buscarId (){
        return factRepo.findAll();
    }
}
