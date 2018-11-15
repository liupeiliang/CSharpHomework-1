<?xml version="1.0" encoding="utf-8" ?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
	<xsl:template match="/ArrayOfOrder">
		<html>
			<head>
				<title>Orders</title>
			</head>
			<body>
				<ul>
					<xsl:for-each select="Order">
						<li>订单号
							<xsl:value-of select="id" />
						</li>
            <li>客户电话
              <xsl:value-of select="client" />
            </li>
            <li>商品名
              <xsl:value-of select="name" />
            </li>  
            <li>价格
              <xsl:value-of select="price" />
            </li>
            <br></br>
					</xsl:for-each>
				</ul>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>