<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

<!--
<xsl:template match="/">
  <html>
  <body>
  <h2>Tabla</h2>
  <table border="1">
    <xsl:for-each select="ies/ciclos/ciclo">
    <tr>
      <td><xsl:value-of select="nombre"/></td>
    </tr>
    </xsl:for-each>
  </table>
  </body>
  </html>
</xsl:template>
-->

<!--
<xsl:template match="/">
  <html>
  <body>
  <h2>Datos</h2>
    <xsl:for-each select="ies/ciclos/ciclo">
      <xsl:value-of select="nombre"/>
    </xsl:for-each>
  </body>
  </html>
</xsl:template>
-->

<!--
<xsl:template match="/">
  <html>
  <body>
  <h2>Lista sin ordenar</h2>
  <ul>
    <xsl:for-each select="ies/ciclos/ciclo">
      <li><xsl:value-of select="nombre"/></li>
    </xsl:for-each>
    </ul>
  </body>
  </html>
</xsl:template>
-->

<xsl:template match="/">
  <html>
  <body>
  <h2>Párrafos</h2>
    <xsl:for-each select="ies/ciclos/ciclo">
      <p><xsl:value-of select="nombre"/></p>
    </xsl:for-each>
  </body>
  </html>
</xsl:template>

</xsl:stylesheet>