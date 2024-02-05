<!-- archivo_transformacion.xslt -->
<xsl:stylesheet version="1.0"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

    <xsl:template match="/">
        <html>
            <body>
                <h2>Edificio A</h2>
                <table border="1">

                    <xsl:apply-templates select="//producto[lugar/@edificio='A']"/>
                </table>

                <h2>Edificio B</h2>
                <table border="1">

                    <xsl:apply-templates select="//producto[lugar/@edificio='B']"/>
                </table>
            </body>
        </html>
    </xsl:template>

    <xsl:template match="producto">
        <tr>
            <td>
                <xsl:value-of select="nombre"/>
            </td>
            <td>
                <xsl:value-of select="concat(peso, ' ', peso/@unidad)"/>
            </td>
            <td>
                <xsl:value-of select="concat(lugar/@edificio, lugar/aula)"/>
            </td>
        </tr>
    </xsl:template>

</xsl:stylesheet>
