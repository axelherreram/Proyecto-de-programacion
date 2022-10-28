/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.GrupoNo2.Entity;

import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;



@Entity
@Table (name = "DetalleFacturas")
public class DFactura {
    
    //info cliente
        @Id
        private int idFac; 
        private Integer nit;
        private String nombreClient;
        private String direccion;
        
    //Info producto
        private int cantidad;    
        private String descripcion;
        private double precioU;
        private double iva;
        private double total;
        private double sobtotalT;
        private double sobtotal;

    public double getSobtotalT() {
        return sobtotalT;
    }

    public void setSobtotalT(double sobtotalT) {
        this.sobtotalT = sobtotalT;
    }

    public Integer getNit() {
        return nit;
    }

    public void setNit(Integer nit) {
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

    public double getPrecioU() {
        return precioU;
    }

    public void setPrecioU(double precioU) {
        this.precioU = precioU;
    }

    public double getIva() {
        return iva;
    }

    public void setIva(double iva) {
        this.iva = iva;
    }

    public double getTotal() {
        return total;
    }

    public void setTotal(double total) {
        this.total = total;
    }

    public double getSobtotal() {
        return sobtotal;
    }

    public void setSobtotal(double sobtotal) {
        this.sobtotal = sobtotal;
    }
        
}
