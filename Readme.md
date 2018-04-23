# How to handle exceptions when importing data from an iCalendar file


<p>This example demonstrates how to handle exceptions which occur when importing data from an iCalendar file and terminate the import process.</p>


<h3>Description</h3>

<p>When an exception is thrown by the <strong>iCalendarImporter</strong> class, the<strong> OnException</strong> event occurs. The <strong>OriginalException</strong> property of the <strong>ExchangeExceptionEventArgs</strong> event arguments object is used to show an error message.<br />
The <strong>AppointmentExchanger.Terminate</strong> method is called to terminate the import process.<br />
The <strong>Handled</strong> property is set to <strong>true</strong> to prevent an exception from being thrown.</p><p>This approach can be helpful for export and import operations involving MS Outlook Calendar, iCalendar and vCalendar data.</p>

<br/>


