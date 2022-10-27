/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.GrupoNo2.Controller;

import com.GrupoNo2.Entity.Clientes;
import com.GrupoNo2.Entity.Factura;
import com.GrupoNo2.Entity.Productos;
import com.GrupoNo2.service.FacturasService;
import java.util.List;
import java.util.Optional;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

/**
 *
 * @author Axel
 */
@RestController
@RequestMapping("/api/facturas")
public class FacturasController {
    @Autowired
    private FacturasService facServic;
    
    @PostMapping
    public Factura insertar(@RequestBody Factura empo){
    return facServic.Ingresar(empo);
    }
    
    @GetMapping
    public List<Factura> Listar () {
    return  facServic.buscarId();
    }
}
