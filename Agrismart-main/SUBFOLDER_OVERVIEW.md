# AgriSmart Main Subfolders Overview

This document describes the main subfolders in the `Agrismart-main` project, summarizing their purpose, how they work, and how to test their functionality.

---

## AgriSmart.AgronomicProcess
- **Purpose:** Background services for agronomic calculations, raw data processing, and irrigation.
- **How it works:** Injects configuration and API clients, runs business logic in background tasks, logs actions.
- **How to test:** Provide configuration and API credentials. Start each service and check logs/results. Input: configuration, API. Output: processed data, logs.

---

## AgriSmart.Api.Agronomic
- **Purpose:** API for agronomic data and operations.
- **How it works:** Exposes controllers for agronomic endpoints, processes requests, interacts with business logic and data models.
- **How to test:** Send API requests to endpoints, verify responses and data changes. Input: HTTP requests. Output: API responses.

---

## AgriSmart.Api.Iot
- **Purpose:** API for IoT device data and operations.
- **How it works:** Exposes controllers for IoT endpoints, processes device data, interacts with business logic.
- **How to test:** Send API requests with device data, verify responses and data storage. Input: HTTP requests. Output: API responses.

---

## AgriSmart.Application.Agronomic
- **Purpose:** Application layer for agronomic logic, commands, queries, handlers, and validation.
- **How it works:** Implements CQRS pattern, processes commands/queries, validates and maps data.
- **How to test:** Call commands/queries with sample data, verify results and validation. Input: command/query objects. Output: processed results.

---

## AgriSmart.Application.Iot
- **Purpose:** Application layer for IoT logic, commands, queries, handlers, and services.
- **How it works:** Implements CQRS pattern, processes IoT commands/queries, manages device logic.
- **How to test:** Call commands/queries with sample device data, verify results. Input: command/query objects. Output: processed results.

---

## AgriSmart.Calculator
- **Purpose:** Background calculations for agronomic processes and fertilizer needs.
- **How it works:** Runs calculation logic in background services, provides calculation methods.
- **How to test:** Start service, call calculation methods with sample inputs, verify outputs. Input: configuration, sample data. Output: calculation results.

---

## AgriSmart.Core
- **Purpose:** Core entities, interfaces, and logic for agronomic and IoT processes.
- **How it works:** Defines entities (Crop, Fertilizer, Water, Measurement, User), interfaces for calculations, and core business logic.
- **How to test:** Create entity instances, call interface methods, verify outputs. Input: entity properties, method parameters. Output: object state, calculation results.

---

## AgriSmart.DB
- **Purpose:** Database project for schema, tables, stored procedures, and scripts.
- **How it works:** Defines database structure and logic for data storage and retrieval.
- **How to test:** Run scripts and procedures, verify data changes and integrity. Input: SQL scripts. Output: database state.

---

## AgriSmart.Infrastructure
- **Purpose:** Infrastructure logic and services for the application.
- **How it works:** Provides supporting services and configuration for other layers.
- **How to test:** Use infrastructure services in application, verify correct operation. Input: service calls. Output: service results.

---

## AgriSmart.OnDemandIrrigation
- **Purpose:** Background service for on-demand irrigation processes.
- **How it works:** Injects configuration, validates settings, executes irrigation logic in a background service.
- **How to test:** Provide valid configuration and API credentials. Start the service and check logs for irrigation actions. Input: configuration, API. Output: log entries, irrigation actions.

---

## AgriSmart.Tools.Desktop
- **Purpose:** Desktop tools and forms for agronomic and irrigation management.
- **How it works:** Implements Windows Forms for user interaction, data input, and visualization.
- **How to test:** Run desktop application, interact with forms, verify data entry and results. Input: user actions. Output: UI changes, data updates.

---

## Agrismart.MQTTBroker
- **Purpose:** MQTT broker logic for IoT device communication.
- **How it works:** Manages MQTT connections, message routing, and device data exchange.
- **How to test:** Connect devices, send/receive MQTT messages, verify communication. Input: MQTT messages. Output: broker logs, device data.

---

## OnDemandIrrigation
- **Purpose:** Additional logic and services for on-demand irrigation.
- **How it works:** Supports irrigation scheduling and execution.
- **How to test:** Run irrigation logic, verify scheduling and execution. Input: irrigation requests. Output: irrigation actions.

---

## Shiny
- **Purpose:** (Not enough context; likely related to notifications or background tasks.)
- **How it works:** (Not enough context.)
- **How to test:** (Not enough context.)

---

*For more details on any subfolder or class, please specify which one you want to explore further.*
