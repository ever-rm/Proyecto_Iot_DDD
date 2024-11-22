# **Proyecto IoT - Plataforma con Enfoque DDD**

## **Descripción General**
Este proyecto consiste en el desarrollo de una plataforma IoT para la gestión de dispositivos, notificaciones, sensores y transacciones.  
La arquitectura sigue un enfoque **Domain-Driven Design (DDD)** para mantener una estructura modular y escalable.  
Utilizamos tecnologías modernas como **.NET 8**, **Swagger** para la documentación interactiva de la API, **MySQL** como base de datos y **RabbitMQ** para la comunicación asincrónica.

---

## **Avances y Componentes Implementados**

### **1. Arquitectura Basada en DDD**
- Separación del proyecto en **Bounded Contexts**:
  - `Devices`
  - `Notifications`
  - `Sensors`
  - `Transactions`
- Cada contexto incluye:
  - **Application**: Lógica de comandos, validadores y consultas.
  - **Domain**: Modelos, eventos de dominio y repositorios.
  - **Infrastructure**: Configuración de persistencia y acceso a datos.
  - **Interfaces**: Controladores REST y servicios ACL para comunicación externa.

### **2. API Documentada con Swagger**
- Swagger permite visualizar y probar los endpoints de la API.
- Endpoints principales:
  - **GET /api/Devices**
  - **POST /api/Devices**
  - **GET /api/Notifications**
  - **POST /api/Notifications**
  - **GET /api/Sensors**
  - **POST /api/Sensors**
  - **GET /api/Transactions**
  - **POST /api/Transactions**

### **3. Base de Datos MySQL**
- Configurada una instancia de MySQL para almacenar los datos del sistema.
- Tablas correspondientes a cada contexto: Dispositivos, Sensores, Notificaciones y Transacciones.
- Se utilizó **Entity Framework Core (EFC)** para la persistencia y mapeo de datos.

### **4. RabbitMQ**
- Integración de un sistema de mensajería para la comunicación asincrónica entre servicios.
- Uso de eventos de dominio para notificar cambios en los contextos (`Notifications`, `Devices`, etc.).

### **5. Docker**
- **Dockerfile** configurado para ejecutar la aplicación en un contenedor.
- **docker-compose.yml** para levantar servicios como MySQL y RabbitMQ junto con la aplicación IoT.

---

## **Requisitos Previos**
- **.NET 8 SDK** instalado.
- **Docker y Docker Compose**.
- **MySQL** instalado localmente o en un contenedor.
- **RabbitMQ** configurado (ya sea en Docker o como servicio externo).

---

## **Cómo Ejecutar**
1. **Clonar el repositorio**:
   ```bash
   git clone https://github.com/ever-rm/Proyecto_Iot_DDD.git
   cd Proyecto_Iot_DDD
