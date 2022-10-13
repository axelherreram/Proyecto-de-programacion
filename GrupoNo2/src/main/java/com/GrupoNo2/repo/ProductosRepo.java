/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.GrupoNo2.repo;

import com.GrupoNo2.Entity.Productos;
import org.springframework.data.jpa.repository.JpaRepository;

public interface ProductosRepo extends JpaRepository <Productos, Integer> {
    
}
