import 'dart:io';
import 'package:barcode_printer/pdf.dart';
import 'package:pdf/pdf.dart';
import 'package:pdf/widgets.dart';
import 'package:printing/printing.dart';

class PdfInvoiceApi {
  // ignore: always_specify_types
  static Future<File> generate(context) async {
    final Document pdf = Document(version: PdfVersion.pdf_1_4, compress: true);
    pdf.addPage(
      Page(
        pageFormat: const PdfPageFormat(
            4.00 * PdfPageFormat.cm, 2.00 * PdfPageFormat.cm),
        orientation: PageOrientation.landscape,
        build: (Context context) => buildPdf(),
      ),
    );
    return PdfApi.saveDocument(
        name: 'Ramzan Hospital', pdf: pdf, context: context);
  }

  static Widget buildPdf() {
    return Container(
      width: 4.00 * PdfPageFormat.cm,
      height: 2.00 * PdfPageFormat.cm,
      decoration: BoxDecoration(border: Border.all()),
      child: Column(
        children: [
          Text('Dev Markaz 2.0'),
          Text('Name : 112222'),
        ],
      ),
    );
  }
}
