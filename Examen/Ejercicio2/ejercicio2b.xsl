<!-- archivo_transformacion_ul.xslt -->
<xsl:stylesheet version="1.0"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

    <xsl:template match="/">
        <html>
            <body>
                <xsl:apply-templates select="//producto"/>
            </body>
        </html>
    </xsl:template>

    <xsl:template match="producto">
        <ul>
            <li>
                <xsl:value-of select="concat('Elemento ', @codigo)"/>
                <ul>
                    <li>
                        <xsl:value-of select="concat('Nombre: ', nombre)"/>
                    </li>
                    <li>
                        <xsl:value-of select="concat('Peso: ', peso, ' ', peso/@unidad)"/>
                    </li>
                </ul>
            </li>
        </ul>
    </xsl:template>

</xsl:stylesheet>
