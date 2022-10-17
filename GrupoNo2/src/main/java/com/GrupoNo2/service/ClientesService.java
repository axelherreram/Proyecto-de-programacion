/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.GrupoNo2.service;

import com.GrupoNo2.Entity.Clientes;
import com.GrupoNo2.repo.ClientesRepo;
import java.util.Optional;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class ClientesService {
    @Autowired
    private ClientesRepo clientesrepo;
    
    //Guardar
    public Clientes Ingresar(Clientes emp){
        return clientesrepo.save(emp);
    }
    //Actualizar
     public Clientes actualizar(Clientes emp){
        return clientesrepo.save(emp);
    }
     //Borrar por id
      public void eliminar(Integer nit){
        clientesrepo.deleteById(nit);
    }
    //Buscar ID  
    public Optional <Clientes> buscarId (Integer id){
    return clientesrepo.findById(id);
    }
    
    
    
}