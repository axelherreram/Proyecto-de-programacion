/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.GrupoNo2.Entity;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;



@Entity
@Table (name = "DetalleFacturas")
public class DFactura {
    
    //info cliente
        @Id
        @GeneratedValue(strategy = GenerationType.IDENTITY)
        private int idFac; 
        private int nit;
        private String nombreClient;
        private String direccion;
        
    //Info producto
        private int cantidad;    
        private String descripcion;
        private String precioU;
        private String iva;
        private String total;
        private String sobtotalT;
        private String sobtotal;

    public int getIdFac() {
        return idFac;
    }

    public void setIdFac(int idFac) {
        this.idFac = idFac;
    }

    public String getSobtotalT() {
        return sobtotalT;
    }

    public void setSobtotalT(String sobtotalT) {
        this.sobtotalT = sobtotalT;
    }

    public int getNit() {
        return nit;
    }

    public void setNit(int nit) {
        this.nit = nit;
    }

    public String getNombreClient() {
        return nombreClient;
    }

    public void setNombreClient(String nombreClient) {
        this.nombreClient = nombreClient;
    }

    public String getDireccion() {
        return direccion;
    }

    public void setDireccion(String direccion) {
        this.direccion = direccion;
    }

    public int getCantidad() {
        return cantidad;
    }

    public void setCantidad(int cantidad) {
        this.cantidad = cantidad;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public String getPrecioU() {
        return precioU;
    }

    public void setPrecioU(String precioU) {
        this.precioU = precioU;
    }

    public String getIva() {
        return iva;
    }

    public void setIva(String iva) {
        this.iva = iva;
    }

    public String getTotal() {
        return total;
    }

    public void setTotal(String total) {
        this.total = total;
    }

    public String getSobtotal() {
        return sobtotal;
    }

    public void setSobtotal(String sobtotal) {
        this.sobtotal = sobtotal;
    }
        
}
