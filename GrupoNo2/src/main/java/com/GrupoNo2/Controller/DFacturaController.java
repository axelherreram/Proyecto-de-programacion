/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.GrupoNo2.Controller;

import com.GrupoNo2.Entity.DFactura;
import com.GrupoNo2.Entity.Factura;
import com.GrupoNo2.service.DFacturaService;
import java.util.List;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

/**
 *
 * @author falla
 */
@RestController
@RequestMapping("/api/detallef")
public class DFacturaController {
    @Autowired
    private DFacturaService dfactService;
    
    @PostMapping
    public DFactura insertar(@RequestBody DFactura empo){
    return dfactService.Ingresar(empo);
    }
    
    @GetMapping
    public List<DFactura> Listar () {
    return  dfactService.buscarId();
    }
}
