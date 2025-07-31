# EventEase - Event Management Platform

## Goal
A comprehensive Blazor WebAssembly application for corporate and social event management, built as part of the .NET learning path assessment.

## Description
EventEase is a modern event management platform that allows users to browse events, view detailed information, and register for corporate conferences, team building retreats, networking mixers, and social gatherings. The application demonstrates advanced Blazor concepts including routing, form validation, and state management.

## Key Features
- **Event Browsing**: View all available events in a responsive card-based layout
- **Event Details**: Comprehensive event information with date, location, pricing, and attendance tracking
- **Registration System**: Complete registration forms with validation and error handling
- **Session Management**: Track user sessions and registration history
- **Responsive Design**: Mobile-friendly Bootstrap interface with professional styling
- **Navigation**: Seamless routing between event list, details, and registration pages
- **Real-time Updates**: Dynamic attendance tracking with visual progress indicators

## Pages & Components
- **Home Page**: Welcome landing page with EventEase branding
- **Event List**: Browse all available events with filtering capabilities
- **Event Details**: Detailed view with full event information and registration links
- **Registration Form**: Validated form with name, email, phone, and terms acceptance
- **EventCard Component**: Reusable event display component
- **Navigation Bar**: Professional header with EventEase branding

## Technical Implementation
- **Framework**: Blazor WebAssembly (.NET 9.0)
- **Architecture**: Component-based with dependency injection
- **Validation**: Data annotations with client-side validation
- **State Management**: Session service for user tracking
- **Styling**: Bootstrap 5 with custom EventEase theming
- **Routing**: Parameter-based routing for event details and registration

## Assessment Grading Criteria

### ✅ GitHub Repository
- Repository created and maintained on GitHub
- Complete commit history with meaningful messages
- All source code and documentation available

### ✅ Event Card Component with Two-Way Data Binding
- **EventCard Component** (`Components/EventCard.razor`) with required fields:
  - Event name, date, location display
  - Price and attendance information
  - Two-way data binding for dynamic updates
  - Progress bars for attendance tracking

### ✅ Routing Implementation and Debugging
- Multiple route configurations implemented:
  - `/events` - Event listing page
  - `/events/{id}` - Event details page  
  - `/register/{id}` - Registration page
- Navigation between pages with breadcrumbs and buttons
- Parameter-based routing with error handling

### ✅ Performance Optimization and Error Handling
- **Input Validation**: Data annotations on all models
- **Routing Errors**: Graceful handling of invalid event IDs
- **User Feedback**: Loading states, error messages, success confirmations
- **Performance**: Responsive design and efficient rendering

### ✅ Advanced Features Implementation
- **Registration Form**: Complete form with validation (name, email, phone)
- **State Management**: SessionService for user session tracking
- **Attendance Tracker**: Real-time attendance monitoring with visual indicators
- **Validation**: Client-side validation with error handling  

## Target Audience
.NET developers learning Blazor WebAssembly, corporate event managers, and students completing the .NET learning path assessment.

---

*Built with Blazor WebAssembly for the EventEase event management platform.*
