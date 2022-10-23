/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.GrupoNo2.repo;

import com.GrupoNo2.Entity.Factura;
import org.springframework.data.jpa.repository.JpaRepository;

/**
 *
 * @author Axel
 */
public interface facturasRepo extends JpaRepository <Factura, Integer> {
    
}
