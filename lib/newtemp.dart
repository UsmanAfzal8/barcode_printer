import 'package:barcode_flutter/barcode_flutter.dart';
import 'package:flutter/material.dart';

import 'bar_code.dart';

class MyWidget extends StatelessWidget {
  const MyWidget({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: MyHomePage(barcodes: [
        BarCodeItem(
          description: "Code39 with text",
          image: BarCodeImage(
            params: Code39BarCodeParams(
              "CODE39",
              withText: true,
            ),
          ),
        ),
      ]),
    );
  }
}
