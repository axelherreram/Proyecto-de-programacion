/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.GrupoNo2.service;

import com.GrupoNo2.Entity.DFactura;
import com.GrupoNo2.repo.DFacturaRepo;
import java.util.List;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

/**
 *
 * @author falla
 */

@Service
public class DFacturaService {
     @Autowired
    private DFacturaRepo dfactRepo;
     
    public DFactura Ingresar(DFactura emp){
        return dfactRepo.save(emp);
    }
    public List <DFactura> buscarId (){
        return dfactRepo.findAll();
    }
    
}
