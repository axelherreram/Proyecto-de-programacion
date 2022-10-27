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
/**
 *
 * @author Axel
 */
@Entity
@Table (name = "Facturas")
public class Factura {
        @Id
        @GeneratedValue(strategy = GenerationType.IDENTITY)
        private int idFac;    
        private String nomEmpresa;    
        private String ubicacion;    
        private String fechaEmision;
        private String horaEmision;
         
        //info cliente
        private Integer nit;
        private String nombreClient;
        private String direccion;
        
        private int codPro;
        private double precio;
        private int cantPro;
        private String descrip;

    public int getCodPro() {
        return codPro;
    }

    public void setCodPro(int codPro) {
        this.codPro = codPro;
    }

    public double getPrecio() {
        return precio;
    }

    public void setPrecio(double precio) {
        this.precio = precio;
    }

    public int getCantPro() {
        return cantPro;
    }

    public void setCantPro(int cantPro) {
        this.cantPro = cantPro;
    }

    public String getDescrip() {
        return descrip;
    }

    public void setDescrip(String descrip) {
        this.descrip = descrip;
    }
        
    
       
    public String getFechaEmision() {
        return fechaEmision;
    }

    public void setFechaEmision(String fechaEmision) {
        this.fechaEmision = fechaEmision;
    }
    public String getHoraEmision() {
        return horaEmision;
    }

    public void setHoraEmision(String horaEmision) {
        this.horaEmision = horaEmision;
    }

    public String getDireccion() {
        return direccion;
    }

    public void setDireccion(String direccion) {
        this.direccion = direccion;
    }
        
    public String getNomEmpresa() {
        return nomEmpresa;
    }

    public void setNomEmpresa(String nomEmpresa) {
        this.nomEmpresa = nomEmpresa;
    }


    public int getIdFac() {
        return idFac;
    }

    public void setIdFac(int idFac) {
        this.idFac = idFac;
    }    

    public String getUbicacion() {
        return ubicacion;
    }

    public void setUbicacion(String ubicacion) {
        this.ubicacion = ubicacion;
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
}
