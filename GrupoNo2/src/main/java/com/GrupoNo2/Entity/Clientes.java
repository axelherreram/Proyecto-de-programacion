/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.GrupoNo2.Entity;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table (name = "Clientes")
public class Clientes {
    @Id
    private Integer nit;
    private String nombreClient;
    private String direccion;
    private String gmail;
    private String numtelefono;

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

    public String getGmail() {
        return gmail;
    }

    public void setGmail(String gmail) {
        this.gmail = gmail;
    }

    public String getNumtelefono() {
        return numtelefono;
    }

    public void setNumtelefono(String numtelefono) {
        this.numtelefono = numtelefono;
    }
    
    
}
