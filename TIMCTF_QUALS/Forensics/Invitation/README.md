---
layout:      post
title:       Timisoara CTF QUALS
date:        20 Avril 2018
comments:    true
categories:  Forensics
auteur:      f00fc7c8
---

===== INFOS ===== 
Filename                 Invitation

File format              pdf

Architecture             x86/x64

Author                   0xcpu 

===== Info =======

Yes! Our school is invited to a cool competition... now we need to
prepare and work hard to be among the best! Let's do it!

===== End of Info ======


====== Solve ========

We recive a pdf as an invitation.We opened it with Text Editor Linux or Notepad from Windows or whatever editor you like, we see the following code snippet:

void create_PDFWithFormValidation\(\) {
         PDFDocument doc = new PDFDocument\(PDFOne_License.KEY);
         doc.OpenAfterCreate = true;
         doc.MeasurementUnit = PDFMeasurementUnit.Inches;
         PDFFormTextField tf = new PDFFormTextField(new RectangleF(1f, 1f, 1f, 0.3f));
         tf.FieldName = "FullName";    tf.BackgroundColor = Color.LightGray;    tf.NameAsUnicode = false;    
         Create a push button form field   
         PDFFormPushButton pb = new PDFFormPushButton(new RectangleF(1f, 2f, 1f, 0.3f));
         pb.FieldName = "SubmitButton";    pb.ActionType = PDFFormFieldActionType.Javascript_Action;   
         pb.NormalCaption = "Submit";
         pb.JavaScript = "var oNameField = this.getField('FullName'); " + \n\t"
	 if (oNameField.valueAsString.length > 2)
	 { " + \n\t"  var arFields = new Array\('FullName'\); " +\n\t"  this.submitForm\({ " +\n\t"      cURL: 'http://www.gnostice.com/newsletters/demos/200804/forms_test.asp', " +\n\t"      aFields: arFields, " +\n\t"      cSubmitAs: 'HTML', " + \n\t"    }\); " +\n\t"  // if validation is ok..." +\n\t"  // then this at the end, somehow... don't click or access, wait until I learn JS and how it works in PDF!!!!!!!!!" +\n\t"   var dlink = 'https://gist.github.com/0xcpu/de7c4c11b59c947bc247ae6d71c9348f';" +\n\t"} else { " + \n\t"   app.alert\('Nhyet! Nhyet! Nhyet!'\);" + \n\t"}";\n    \n    // Add form fields to the document\n    doc.AddFormField\(tf\);\n    doc.AddFormField\(pb\);\n    \n    doc.Save\("form.pdf"\);\n    doc.Close\(\);\n}\n) 	 

	Yeap i know i dunno how to ident it,thats it which essencialy leads a to 0xcpu git https://gist.github.com/0xcpu/de7c4c11b59c947bc247ae6d71c9348f, there we see the title panda_gif and == indicate that it's something b64 encoded, we reverse it and then decode it and then we get an image with the flag
