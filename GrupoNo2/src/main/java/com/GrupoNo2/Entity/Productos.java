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
@Table (name = "Productos")
public class Productos {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer idPro;
    private String nombreProd;
    private double precioProd;
    private String ram;
    private String procesador;
    private int stock;
    private String almacenamiento;
    private String fotoPro;

    public String getFotoPro() {
        return fotoPro;
    }

    public void setFotoPro(String fotoPro) {
        this.fotoPro = fotoPro;
    }
    
    
    //Get and set de las propiedades
    public String getAlmacenamiento() {
        return almacenamiento;
    }
    public void setAlmacenamiento(String almacenamiento) {    
        this.almacenamiento = almacenamiento;
    }

    public Integer getIdPro() {
        return idPro;
    }
    
    public void setIdPro(Integer idPro) {
        this.idPro = idPro;
    }
    public String getRam() {
        return ram;
    }

    public void setRam(String ram) {
        this.ram = ram;
    }

    public String getProcesador() {
        return procesador;
    }

    public void setProcesador(String procesador) {
        this.procesador = procesador;
    }

    public int getStock() {
        return stock;
    }

    public void setStock(int stock) {
        this.stock = stock;
    }

    public String getNombreProd() {
        return nombreProd;
    }

    public void setNombreProd(String nombreProd) {
        this.nombreProd = nombreProd;
    }

    public double getPrecioProd() {
        return precioProd;
    }

    public void setPrecioProd(double precioProd) {
        this.precioProd = precioProd;
    }
}
