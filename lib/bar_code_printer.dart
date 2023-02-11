import 'package:barcode_printer/uthaya_hova_code.dart';
import 'package:barcode_widget/barcode_widget.dart';
import 'package:flutter/material.dart';

import 'pdf_show.dart';

class BarCodePage extends StatelessWidget {
  const BarCodePage({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Column(
        children: [
          SizedBox(
            height: 60,
            width: 100,
            child: BarcodeWidget(
              barcode: Barcode.code128(),
              data: 'Dev markaz',
            ),
          ),
          ElevatedButton(
              onPressed: () async {
                await GenratePrint().generatePdf('title', context);
              },
              child: Text('Print'))
        ],
      ),
    );
  }
}
