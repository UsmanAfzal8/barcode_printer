import 'dart:io';

import 'package:barcode_printer/pdf.dart';
import 'package:flutter/material.dart';
import 'package:pdf/pdf.dart';
import 'package:pdf/widgets.dart' as pw;
import 'dart:typed_data';

class GenratePrint {
  Future<Future<File>> generatePdf( String title,BuildContext context) async {
    final pdf = pw.Document(version: PdfVersion.pdf_1_4, compress: true);

    pdf.addPage(
      pw.Page(
        orientation: pw.PageOrientation.landscape,
        pageFormat: const PdfPageFormat(
            4.00 * PdfPageFormat.cm, 2.00 * PdfPageFormat.cm),
        build: (context) {
          return pw.Container(
            width: 4.00 * PdfPageFormat.cm,
            height: 2.00 * PdfPageFormat.cm,
            decoration: pw.BoxDecoration(border: pw.Border.all()),
            child: pw.Column(
              crossAxisAlignment: pw.CrossAxisAlignment.start,
              children: [
                pw.Text('Dev Markaz 2.0'),
                pw.Text('Name : 112222'),
              ],
            ),
          );
        },
      ),
           
    );
return  PdfApi.saveDocument(
        name: 'Ramzan Hospital', pdf: pdf, context: context);
    //return pdf.save();
  }
}
