/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.GrupoNo2.Controller;
import com.GrupoNo2.Entity.Productos;
import com.GrupoNo2.service.ProductosService;
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



/**
 *
 * @author Axel
 */
@RestController
@RequestMapping("/api/productos")
public class productosController {
     
    @Autowired
    private ProductosService productosSer;
    
    @PostMapping
    public Productos insertar(@RequestBody Productos empo){
    return productosSer.IngresarProd(empo);
    }
    
    @GetMapping
    public Optional<Productos> ListarID(@RequestParam Integer idPro){
    return productosSer.buscarId(idPro);
    }
    
    @DeleteMapping
    public void eliminar(@RequestParam Integer idPro){
    productosSer.eliminarId(idPro);
    }
    
    @PutMapping
    public Productos actualizar(@RequestBody Productos empo){
    return productosSer.actualizarProd(empo);
    }
    
}
