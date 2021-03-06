# ExpoSoft

## Clases de equivalencia

||LOGIN||
| :--: | :--: | :--: |
| **Condiciones de entrada** | **Clase de equivalencia válida** | **Clase de equivalencia no válida** |
| **Email:** Debe cumplir con el formato  | 1. "text@text"  | 2. null </br> 3. no cumple con el formato |
| **Contraseña:** Debe tener mínimo 8 caracteres y máximo 15 caracteres.  | 4. 8 caracteres ≤ contraseña ≤  15 caracteres  | 5. null </br> 6. contraseña < 8 caracteres </br> 7. contraseña > 15 caracteres |

||REGISTRO||
| :--: | :--: | :--: |
| **Condiciones de entrada** | **Clase de equivalencia válida** | **Clase de equivalencia no válida** |
| **Email:** Debe cumplir con el formato establecido | 9. "text@text"  | 10. null</br>11. no cumple con el formato |
| **Confirmar email:** Debe cumplir con el formato establecido | 12. "text@text"  | 13. null</br>14. no cumple con el formato |
| **Contraseña:** Debe tener mínimo 8 caracteres y máximo 15 caracteres. | 15. 8 caracteres ≤ contraseña ≤  15 caracteres  | 16. null</br>17. contraseña < 8 caracteres</br>18. contraseña > 15 caracteres |
| **Confirmar contraseña:** Debe tener mínimo 8 caracteres y máximo 15 caracteres. | 19. 8 caracteres ≤ confirmar contraseña ≤  15 caracteres | 20. null</br>21. confirmar contraseña < 8 caracteres</br>22. confirmar contraseña > 15 caracteres |
| **Nombre de la empresa:** Debe tener mínimo 3 caracteres y máximo 100 caracteres | 23. 3 caracteres ≤ nombre de la empresa ≤ 100 caracteres | 24. null</br>25. nombre de la empresa < 3 caracteres</br>26. nombre de la empresa > 30 caracteres |
| **Nit:** Debe cumplir con el formato. | 27. "XXX.XXX.XXX - Y"  | 28. null</br>29. no cumple con el formato|

||COMPLETAR EL REGISTRO||
| :--: | :--: | :--: |
| **Condiciones de entrada** | **Clase de equivalencia válida** | **Clase de equivalencia no válida** |
| **Nombre:** Debe tener mínimo 3 letras y máximo 30 letras  | 1. 3 letras ≤ nombre ≤ 30 letras  | 2. null </br> 3. nombre < 3 letras </br> 4. nombre > 30 letras |
| **Apellidos:** Debe tener mínimo 3 letras y máximo 30 letras | 5. 3 letras ≤ apellidos ≤ 30 letras  | 6. null</br>7. apellidos < 3 letras</br>8. apellidos > 30 letras |
| **Tipo de empresa:** Debe encontrarse dentro de las opciones válidas.  | 1. "Sociedad limitada (LTDA)"</br>2. "Sociedad anónima (S.A)"</br>3. "Empresa unipersonal (E.U)"</br>4. "Sociedad colectiva (S.C)"</br>5. "Empresa asociativa de trabajo (EAT)"</br>6. "Sociedad por acciones simplificada (S.A.S)"  | 7. null </br>8. no se encuentra dentro de las opciones válidas|
| **Teléfono celular:** Debe tener exactamente 10 dígitos.  | 9. teléfono celular = 10 dígitos  | 10. null </br> 11. teléfono celular ≠ 10 dígitos |
| **Teléfono fijo:** Debe tener exactamente 7 dígitos.  | 12. teléfono fijo = 7 dígitos  | 13. null</br>14. teléfono fijo ≠ 7 dígitos |
| **Departamento:** Debe encontrarse dentro de las opciones válidas. | 15. "Amazonas"</br>16. "Antioquia"</br>17. "Arauca"</br>18. "Atlántico"</br>19. "Bolívar"</br>20. "Boyacá"</br>21. "Caldas"</br>22. "Caquetá"</br>23. "Casanare"</br>24. "Cauca"</br>25. "Cesar"</br>26. "Chocó"</br>27. "Cundinamarca"</br>28. "Córdoba"</br>29. "Guainía"</br>30. "Guaviare"</br>31. "Huila"</br>2. "La Guajira"</br>33. "Magdalena"</br>34. "Meta"</br>35. "Nariño"</br>36. "Norte de Santander"</br>37. "Putumayo"</br>38. "Quindío"</br>39. "Risaralda"</br>40. "San Andrés y Providencia"</br>41. "Santander"</br>42. "Sucre"</br>43. "Tolima"</br>44. "Valle del Cauca"</br>45. "Vaupés"</br>46. "Vichada" | 47. null</br>48. no se encuentra dentro de las opciones válidas |

## Valores límites

|**Dato de entrada**||
|:--:|:--:|
|**Contraseña**|"123...7"</br>"123...8"</br>"123…15"</br>"123..16"</br>|

|**Dato de entrada**||
|:--:|:--:|
|**Confirmar contraseña**|"123...7"</br>"123...8"</br>"123…15"</br>"123..16"|

|**Dato de entrada**||
|:--:|:--:|
|**Nombre**|"as"</br>"asd"</br>"asd..30"</br>"asd..31"|

|**Dato de entrada**||
|:--:|:--:|
|**Apellidos**|"as"</br>"asd"</br>"asd..30"</br>"asd..31"|

|**Dato de entrada**||
|:--:|:--:|
|**Nombre de la empresa**|"as"</br>"asd"</br>"asd..100"</br>"asd..101"|

|**Dato de entrada**||
|:--:|:--:|
|**Teléfono celular**|"123...9"</br>"123...10"</br>"123…15"</br>"123..11"</br>|

|**Dato de entrada**||
|:--:|:--:|
|**Teléfono fijo**|"123...6"</br>"123...7"</br>"123…15"</br>"123..8"</br>|
