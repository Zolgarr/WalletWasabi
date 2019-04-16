﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WalletWasabi.Hwi
{
	public static class UdevRules
	{
		// Source: https://github.com/LedgerHQ/udev-rules/blob/master/20-hw1.rules
		public static readonly string[] Ledger =
		{
			"SUBSYSTEMS==\"usb\", ATTRS{idVendor}==\"2581\", ATTRS{idProduct}==\"1b7c\", TAG+=\"uaccess\"",
			"SUBSYSTEMS==\"usb\", ATTRS{idVendor}==\"2581\", ATTRS{idProduct}==\"2b7c\", TAG+=\"uaccess\"",
			"SUBSYSTEMS==\"usb\", ATTRS{idVendor}==\"2581\", ATTRS{idProduct}==\"3b7c\", TAG+=\"uaccess\"",
			"SUBSYSTEMS==\"usb\", ATTRS{idVendor}==\"2581\", ATTRS{idProduct}==\"4b7c\", TAG+=\"uaccess\"",
			"SUBSYSTEMS==\"usb\", ATTRS{idVendor}==\"2581\", ATTRS{idProduct}==\"1807\", TAG+=\"uaccess\"",
			"SUBSYSTEMS==\"usb\", ATTRS{idVendor}==\"2581\", ATTRS{idProduct}==\"1808\", TAG+=\"uaccess\"",
			"SUBSYSTEMS==\"usb\", ATTRS{idVendor}==\"2c97\", ATTRS{idProduct}==\"0000\", TAG+=\"uaccess\"",
			"SUBSYSTEMS==\"usb\", ATTRS{idVendor}==\"2c97\", ATTRS{idProduct}==\"0001\", TAG+=\"uaccess\"",
			"SUBSYSTEMS==\"usb\", ATTRS{idVendor}==\"2c97\", ATTRS{idProduct}==\"0004\", TAG+=\"uaccess\""
		};

		// Source: https://github.com/Coldcard/ckcc-protocol/blob/master/51-coinkite.rules
		public static readonly string[] Coldcard =
		{
			// probably not needed:
			"SUBSYSTEMS==\"usb\", ATTRS{idVendor}==\"d13e\", ATTRS{idProduct}==\"cc10\", GROUP=\"plugdev\", MODE=\"0666\"",
			// required:
			// from <https://github.com/signal11/hidapi/blob/master/udev/99-hid.rules>
			"KERNEL==\"hidraw*\", ATTRS{idVendor}==\"d13e\", ATTRS{idProduct}==\"cc10\", GROUP=\"plugdev\", MODE=\"0666\""
		};

		// Source: https://shiftcrypto.ch/start_linux
		public static readonly string[] BitBox =
		{
			"SUBSYSTEM==\"usb\", TAG+=\"uaccess\", TAG+=\"udev-acl\", SYMLINK+=\"dbb%n\", ATTRS{idVendor}==\"03eb\", ATTRS{idProduct}==\"2402\"",
			"KERNEL==\"hidraw*\", SUBSYSTEM==\"hidraw\", ATTRS{idVendor}==\"03eb\", ATTRS{idProduct}==\"2402\", TAG+=\"uaccess\", TAG+=\"udev-acl\", SYMLINK+=\"dbbf%n\""
		};

		// Source: https://github.com/trezor/trezor-common/blob/master/udev/51-trezor.rules
		public static readonly string[] Trezor =
		{
			// TREZOR
			"SUBSYSTEM==\"usb\", ATTR{idVendor}==\"534c\", ATTR{idProduct}==\"0001\", MODE=\"0660\", GROUP=\"plugdev\", TAG+=\"uaccess\", TAG+=\"udev-acl\", SYMLINK+=\"trezor%n\"",
			"KERNEL==\"hidraw*\", ATTRS{idVendor}==\"534c\", ATTRS{idProduct}==\"0001\",  MODE=\"0660\", GROUP=\"plugdev\", TAG+=\"uaccess\", TAG+=\"udev-acl\"",
			"SUBSYSTEM==\"usb\", ATTR{idVendor}==\"1209\", ATTR{idProduct}==\"53c0\", MODE=\"0660\", GROUP=\"plugdev\", TAG+=\"uaccess\", TAG+=\"udev-acl\", SYMLINK+=\"trezor%n\"",
			// TREZOR v2
			"SUBSYSTEM==\"usb\", ATTR{idVendor}==\"1209\", ATTR{idProduct}==\"53c1\", MODE=\"0660\", GROUP=\"plugdev\", TAG+=\"uaccess\", TAG+=\"udev-acl\", SYMLINK+=\"trezor%n\"",
			"KERNEL==\"hidraw*\", ATTRS{idVendor}==\"1209\", ATTRS{idProduct}==\"53c1\",  MODE=\"0660\", GROUP=\"plugdev\", TAG+=\"uaccess\", TAG+=\"udev-acl\""
		};

		// Source: https://github.com/keepkey/udev-rules/blob/master/51-usb-keepkey.rules
		public static readonly string[] KeepKey =
		{
			// KeepKey HID Firmware/Bootloader
			"SUBSYSTEM==\"usb\", ATTR{idVendor}==\"2b24\", ATTR{idProduct}==\"0001\", MODE=\"0666\", GROUP=\"plugdev\", TAG+=\"uaccess\", TAG+=\"udev-acl\", SYMLINK+=\"keepkey%n\"",
			"KERNEL==\"hidraw*\", ATTRS{idVendor}==\"2b24\", ATTRS{idProduct}==\"0001\",  MODE=\"0666\", GROUP=\"plugdev\", TAG+=\"uaccess\", TAG+=\"udev-acl\"",
			// KeepKey WebUSB Firmware/Bootloader
			"SUBSYSTEM==\"usb\", ATTR{idVendor}==\"2b24\", ATTR{idProduct}==\"0002\", MODE=\"0666\", GROUP=\"plugdev\", TAG+=\"uaccess\", TAG+=\"udev-acl\", SYMLINK+=\"keepkey%n\"",
			"KERNEL==\"hidraw*\", ATTRS{idVendor}==\"2b24\", ATTRS{idProduct}==\"0002\",  MODE=\"0666\", GROUP=\"plugdev\", TAG+=\"uaccess\", TAG+=\"udev-acl\""
		};
	}
}
