﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pcAmerica.DesktopPOS.API.Client.SalesService;

namespace pcAmerica.DesktopPOS.API.Client
{
    public class SalesAPI
    {
        /// <summary>
        /// Retrieves the summary of Net Sales, Total Tax, and Grand Total between date/times
        /// </summary>
        /// <param name="startDateTime">The period start date/time</param>
        /// <param name="endDateTime">The period end date/time</param>
        /// <returns>A SalesTotals object containing sales data</returns>
        public SalesTotals GetTotals(DateTime startDateTime, DateTime endDateTime)
        {
            using (SalesServiceClient client = new SalesServiceClient())
            {
                client.Open();
                return client.GetTotals(startDateTime, endDateTime);
            }
        }
        /// <summary>
        /// Retrieves a list of invoice number, item name, item number, cashier, date sold, price, quantity, and discount amounts for each item record
        /// </summary>
        /// <param name="startDateTime">The period start date/time</param>
        /// <param name="endDateTime">The period end date/time</param>
        /// <returns>A list of ItemSale objects</returns>
        public List<ItemSale> GetItemsSold(DateTime startDateTime, DateTime endDateTime)
        {
            using (SalesServiceClient client = new SalesServiceClient())
            {
                client.Open();
                return new List<ItemSale>(client.GetItemsSold(startDateTime, endDateTime));
            }
        }
        /// <summary>
        /// Retrieves a list of Invoice Numbers, Grand Total, CashierId, OnHoldID for a specified Cashier/Employee
        /// </summary>
        /// <param name="context">The store id, station id, and cashier id the information should be restricted to.</param>
        /// <returns>A list of OnHoldInfo</returns>
        public List<OnHoldInfo> GetOnHoldInvoicesForCashier(Context context)
        {
            using (SalesServiceClient client = new SalesServiceClient())
            {
                client.Open();
                return new List<OnHoldInfo>(client.GetOnHoldInvoicesForCashier(context));
            }
        }
        /// <summary>
        /// Retrieves a list of Invoice Numbers, Grand Total, CashierId, OnHoldID for the whole store/restaurant
        /// </summary>
        /// <param name="context">The store id, station id, and cashier id the information should be restricted to.</param>
        /// <returns>A list of OnHoldInfo</returns>
        public List<OnHoldInfo> GetAllOnHoldInvoices(Context context)
        {
            using (SalesServiceClient client = new SalesServiceClient())
            {
                client.Open();
                return new List<OnHoldInfo>(client.GetAllOnHoldInvoices(context));
            }
        }
        /// <summary>
        /// Begins a new invoice, saving it with the specified onHoldID, and automatically "locks" it so other devices cannot modify it.
        /// Always unlock the invoice when you are finished working with/modifying it.
        /// </summary>
        /// <param name="context">The store id, station id, and cashier id the information should be restricted to.</param>
        /// <param name="onHoldID">The ID that should represent an invoice.  If the ID matches a Table Number, the table will become reserved.</param>
        /// <returns>An Invoice object with the newly assigned invoiceNumber, used for future API calls</returns>
        public Invoice StartNewInvoice(Context context, String onHoldID)
        {
            using (SalesServiceClient client = new SalesServiceClient())
            {
                client.Open();
                return client.StartNewInvoice(context, onHoldID);
            }
        }
        /// <summary>
        /// Retrieves the invoice header and line item details for a specified invoice number in context.
        /// </summary>
        /// <param name="context">The store id, station id, and cashier id the information should be restricted to.</param>
        /// <param name="invoiceNumber">The number of the invoice that should be returned</param>
        /// <returns>An Invoice object with LineItem details</returns>
        public Invoice GetInvoice(Context context, long invoiceNumber)
        {
            using (SalesServiceClient client = new SalesServiceClient())
            {
                client.Open();
                return client.GetInvoice(context, invoiceNumber);
            }
        }
        /// <summary>
        /// Retrieves only the invoice header for a specified invoice number in context.
        /// </summary>
        /// <param name="context">The store id, station id, and cashier id the information should be restricted to.</param>
        /// <param name="invoiceNumber">The number of the invoice that should be returned</param>
        /// <returns>An Invoice header object, and an empty line item detail list</returns>
        public Invoice GetInvoiceHeader(Context context, long invoiceNumber)
        {
            using (SalesServiceClient client = new SalesServiceClient())
            {
                client.Open();
                return client.GetInvoiceHeader(context, invoiceNumber);
            }
        }
        /// <summary>
        /// Locks an invoice so no other devices will attempt to open or modify it.
        /// </summary>
        /// <param name="context">The store id, station id, and cashier id the information should be restricted to.</param>
        /// <param name="invoiceNumber">The number of the invoice that should be locked</param>
        /// <returns>The success or failure of the lock request</returns>
        public bool LockInvoice(Context context, long invoiceNumber)
        {
            using (SalesServiceClient client = new SalesServiceClient())
            {
                client.Open();
                return client.LockInvoice(context, invoiceNumber);
            }
        }
        /// <summary>
        /// Unlocks an invoice to make it available for other devices to open and work on it.  Unlock should always be called when 
        /// done working on an invoice on your device.
        /// </summary>
        /// <param name="context">The store id, station id, and cashier id the information should be restricted to.</param>
        /// <param name="invoiceNumber">The number of the invoice that should be unlocked</param>
        /// <returns>The success or failure of the unlock request</returns>
        public bool UnLockInvoice(Context context, long invoiceNumber)
        {
            using (SalesServiceClient client = new SalesServiceClient())
            {
                client.Open();
                return client.UnLockInvoice(context, invoiceNumber);
            }
        }
        /// <summary>
        /// Modifies an invoice to change the line item details based on EntityState. Items can be added/deleted/modified/unchanged.
        /// The API matches the line item id with the ObjectID in the CRE/RPE invoice, and does the specified operation to it.
        /// Line items with a modified status can change quantity and price.
        /// Deleted line items will remove the item from the invoice. Deleting an item that has child details will also remove the children.
        /// When adding a new line item, assign your own GUID as an id, and associate it as the parent to modifier items.
        /// </summary>
        /// <param name="context">The store id, station id, and cashier id the information should be restricted to.</param>
        /// <param name="invoiceNumber">The number of the invoice that should be modified</param>
        /// <param name="items">The list of modified items</param>
        /// <returns>An Invoice object with LineItem details after making the specified modifications</returns>
        public Invoice ModifyItems(Context context, long invoiceNumber, List<LineItem> items)
        {
            using (SalesServiceClient client = new SalesServiceClient())
            {
                client.Open();
                return client.ModifyItems(context, invoiceNumber, items);
            }
        }
        /// <summary>
        /// Prints a receipt to the configured printer for the store id, station id
        /// </summary>
        /// <param name="context">The store id, station id, and cashier id the information should be restricted to.</param>
        /// <param name="invoiceNumber">The number of the invoice that should be printed</param>
        /// <returns>The success/failure of the print request</returns>
        public bool PrintReceipt(Context context, long invoiceNumber)
        {
            using (SalesServiceClient client = new SalesServiceClient())
            {
                client.Open();
                return client.PrintReceipt(context, invoiceNumber);
            }
        }
        /// <summary>
        /// Prints a receipt for a specific split check to the configured printer for the store id, station id
        /// </summary>
        /// <param name="context">The store id, station id, and cashier id the information should be restricted to.</param>
        /// <param name="invoiceNumber">The number of the invoice that should be printed</param>
        /// <param name="splitCheckNumber">The split check number, 0-based</param>
        /// <returns>The success/failure of the print request</returns>
        public bool PrintReceiptForSplitCheck(Context context, long invoiceNumber, int splitCheckNumber)
        {
            using (SalesServiceClient client = new SalesServiceClient())
            {
                client.Open();
                return client.PrintReceiptForSplitCheck(context, invoiceNumber, splitCheckNumber);
            }
        }
        /// <summary>
        /// Emails a receipt to the specified email address
        /// </summary>
        /// <param name="context">The store id, station id, and cashier id the information should be restricted to.</param>
        /// <param name="invoiceNumber">The number of the invoice that should be emailed</param>
        /// <param name="emailAddress">The email address to send the receipt to</param>
        /// <returns>The success/failure of the email request</returns>
        public bool EmailReceipt(Context context, long invoiceNumber, string emailAddress)
        {
            using (SalesServiceClient client = new SalesServiceClient())
            {
                client.Open();
                return client.EmailReceipt(context, invoiceNumber, emailAddress);
            }
        }
        /// <summary>
        /// Emails a receipt for a specific split check to the specified email address
        /// </summary>
        /// <param name="context">The store id, station id, and cashier id the information should be restricted to.</param>
        /// <param name="invoiceNumber">The number of the invoice that should be emailed</param>
        /// <param name="splitCheckNumber">The split check number, 0-based</param>
        /// <param name="emailAddress">The email address to send the receipt to</param>
        /// <returns>The success/failure of the email request</returns>
        public bool EmailReceiptForSplitCheck(Context context, long invoiceNumber, int splitCheckNumber, string emailAddress)
        {
            using (SalesServiceClient client = new SalesServiceClient())
            {
                client.Open();
                return client.EmailReceiptForSplitCheck(context, invoiceNumber, splitCheckNumber, emailAddress);
            }
        }
        /// <summary>
        /// Directs the API to send the order to the kitchen at this time. Only the items that have not previously been printed in the kitchen are printed.
        /// </summary>
        /// <param name="context">The store id, station id, and cashier id the information should be restricted to.</param>
        /// <param name="invoiceNumber">The number of the invoice that should be sent the kitchen</param>
        /// <returns>The success of failure of the kitchen print request</returns>
        public bool SendToKitchen(Context context, long invoiceNumber)
        {
            using (SalesServiceClient client = new SalesServiceClient())
            {
                client.Open();
                return client.SendToKitchen(context, invoiceNumber);
            }
        }
        /// <summary>
        /// Applies a credit card payment to the specified invoice
        /// </summary>
        /// <param name="context">The store id, station id, and cashier id the information should be restricted to.</param>
        /// <param name="invoiceNumber">The number of the invoice that should be paid</param>
        /// <param name="response">Provides the details of the card payment</param>
        /// <returns>An object that contains the success/failure of the request</returns>
        public AppliedPaymentResponse ApplyCardPayment(Context context, long invoiceNumber, SalesService.PaymentResponse response)
        {
            using (SalesServiceClient client = new SalesServiceClient())
            {
                client.Open();
                return client.ApplyCardPayment(context, invoiceNumber, response);
            }
        }
        /// <summary>
        /// Applies a credit card payment to the specified split check on the invoice
        /// </summary>
        /// <param name="context">The store id, station id, and cashier id the information should be restricted to.</param>
        /// <param name="invoiceNumber">The number of the invoice that should be paid</param>
        /// <param name="splitCheckNumber">The split check number, 0-based.</param>
        /// <param name="response">Provides the details of the card payment</param>
        /// <returns>An object that contains the success/failure of the request</returns>
        public AppliedPaymentResponse ApplyCardPaymentToSplitCheck(Context context, long invoiceNumber, int splitCheckNumber, SalesService.PaymentResponse response)
        {
            using (SalesServiceClient client = new SalesServiceClient())
            {
                client.Open();
                return client.ApplyCardPaymentToSplitCheck(context, invoiceNumber, splitCheckNumber, response);
            }
        }
        /// <summary>
        /// Splits the invoice evenly into the specified number of ways
        /// </summary>
        /// <param name="context">The store id, station id, and cashier id the information should be restricted to.</param>
        /// <param name="invoiceNumber">The number of the invoice that should be split</param>
        /// <param name="numberOfWays">The number of ways to split the check. E.g. Provide 2 to split the check 2 ways.</param>
        /// <returns>The success or failure of the split request</returns>
        public bool SplitInvoice(Context context, long invoiceNumber, int numberOfWays)
        {
            using (SalesServiceClient client = new SalesServiceClient())
            {
                client.Open();
                return client.SplitInvoice(context, invoiceNumber, numberOfWays);
            }
        }
        /// <summary>
        /// Splits the invoice evenly among the assigned guests
        /// </summary>
        /// <param name="context">The store id, station id, and cashier id the information should be restricted to.</param>
        /// <param name="invoiceNumber">The number of the invoice that should be split</param>
        /// <returns>The success or failure of the split request</returns>
        public bool SplitInvoiceByGuest(Context context, long invoiceNumber)
        {
            using (SalesServiceClient client = new SalesServiceClient())
            {
                client.Open();
                return client.SplitInvoiceByGuest(context, invoiceNumber);
            }
        }
        /// <summary>
        /// Combines the unpaid split checks back into a single check.
        /// </summary>
        /// <param name="context">The store id, station id, and cashier id the information should be restricted to.</param>
        /// <param name="invoiceNumber">The number of the invoice that should be combined</param>
        /// <returns>The success or failure of the combine request</returns>
        public bool CombineSplits(Context context, long invoiceNumber)
        {
            using (SalesServiceClient client = new SalesServiceClient())
            {
                client.Open();
                return client.CombineSplits(context, invoiceNumber);
            }
        }
        /// <summary>
        /// Marks the specified invoice as complete, only if it's fully paid. Also sends the order to the kitchen if it has not been printed yet.
        /// </summary>
        /// <param name="context">The store id, station id, and cashier id the information should be restricted to.</param>
        /// <param name="invoiceNumber">The number of the invoice that should be ended</param>
        /// <returns>The success or failure of the EndInvoice request</returns>
        public bool EndInvoice(Context context, long invoiceNumber)
        {
            using (SalesServiceClient client = new SalesServiceClient())
            {
                client.Open();
                return client.EndInvoice(context, invoiceNumber);
            }
        }
        /// <summary>
        /// Applies a cash payment to the specified invoice
        /// </summary>
        /// <param name="context">The store id, station id, and cashier id the information should be restricted to.</param>
        /// <param name="invoiceNumber">The number of the invoice that should be paid</param>
        /// <param name="amount">The cash amount being applied</param>
        /// <returns>An object that contains the success/failure of the request, and the change due (if any)</returns>
        public AppliedPaymentResponse ApplyCashPayment(Context context, long invoiceNumber, decimal amount)
        {
            using (SalesServiceClient client = new SalesServiceClient())
            {
                client.Open();
                return client.ApplyCashPayment(context, invoiceNumber, amount);
            }
        }
        /// <summary>
        /// Applies a cash payment to the specified split check on the invoice
        /// </summary>
        /// <param name="context">The store id, station id, and cashier id the information should be restricted to.</param>
        /// <param name="invoiceNumber">The number of the invoice that should be paid</param>
        /// <param name="splitCheckNumber">The split check number, 0-based</param>
        /// <param name="amount">The cash amount being applied</param>
        /// <returns>An object that contains the success/failure of the request, and the change due (if any)</returns>
        public AppliedPaymentResponse ApplyCashPaymentToSplitCheck(Context context, long invoiceNumber, int splitCheckNumber, decimal amount)
        {
            using (SalesServiceClient client = new SalesServiceClient())
            {
                client.Open();
                return client.ApplyCashPaymentToSplitCheck(context, invoiceNumber, splitCheckNumber, amount);
            }
        }
    }
}
