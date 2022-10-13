/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.GrupoNo2.service;
import com.GrupoNo2.Entity.Productos;
import com.GrupoNo2.repo.ProductosRepo;
import java.util.List;
import java.util.Optional;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;



@Service
public class ProductosService {
    @Autowired
    private ProductosRepo productosRepo;
    
    //Guardar
    public Productos IngresarProd(Productos emp){
        return productosRepo.save(emp);
    }
    //Actualizar
     public Productos actualizarProd(Productos emp){
        return productosRepo.save( emp);
    }
     //Borrar por id
      public void eliminarId(Integer id){
        productosRepo.deleteById(id);
    }
    //Buscar ID  
    public Optional <Productos> buscarId (Integer id){
    return productosRepo.findById(id);
    }
    
    
    
}
