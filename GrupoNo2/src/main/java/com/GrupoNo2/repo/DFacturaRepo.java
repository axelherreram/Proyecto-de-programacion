/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.GrupoNo2.repo;

import com.GrupoNo2.Entity.DFactura;
import org.springframework.data.jpa.repository.JpaRepository;


/**
 *
 * @author falla
 */

public interface DFacturaRepo extends JpaRepository <DFactura, Integer> {
    
}
