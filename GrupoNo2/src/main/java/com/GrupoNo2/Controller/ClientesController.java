/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.GrupoNo2.Controller;

import com.GrupoNo2.Entity.Clientes;
import com.GrupoNo2.Entity.Productos;
import com.GrupoNo2.service.ClientesService;
import com.GrupoNo2.service.ProductosService;
import java.util.List;
import java.util.Optional;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/api/clientes")
public class ClientesController {
     
    @Autowired
    private ClientesService clientesSer;
    
    @PostMapping
    public Clientes insertar(@RequestBody Clientes empo){
    return clientesSer.IngresarClie(empo);
    }
    
    @GetMapping
    public Optional<Clientes> ListarID(@RequestParam Integer NIT){
    return clientesSer.buscarId(NIT);
    }
    
    @DeleteMapping
    public void eliminar(@RequestParam Integer NIT){
    clientesSer.eliminarId(NIT);
    }
    
    @PutMapping
    public Clientes actualizar(@RequestBody Clientes empo){
    return clientesSer.actualizarClie(empo);
    }
    
}

