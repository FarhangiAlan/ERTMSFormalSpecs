
using XmlBooster;
using System.IO;
using System.Collections;
using System;

/// <remarks>XMLBooster-generated code (Version 2.20.1.0)
/// This code is generated automatically. It is not meant
/// to be maintained or even read. As it is generated, 
/// it does not follow any coding standard. Please refrain
/// from performing any change directly on this generated 
/// code, as it might be overwritten anytime.
/// This documentation is provided for information purposes
/// only, in order to make the generated API somewhat more
/// understandable. It is meant to be a maintenance guide,
/// as this code is not meant to be maintained at all.</remarks>
namespace DataDictionary.Generated{
public abstract partial class Namable
: ModelElement
{
public  override  bool find(Object search){
if (search is String ) {
if(getName().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.NamableController.alertChange(aLock, this);
}
private   string  aName;

public   string  getName() { return aName;}
public  void setName( string  v) {
  aName = v;
  __setDirty(true);
  NotifyControllers(null);
}

public Namable()
{
Namable obj = this;
aName=(null);
}

public void copyTo(Namable other)
{
other.aName = aName;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl101;
bool fl102;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl101 = false ; 
fl102 = true ; 
while (fl102) { // BeginLoop 
if (ctxt.lookAheadString("Name=")){
indicator = 101;
} else {
indicator = 103;
} // If
switch (indicator) {
case 101: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl101){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl101 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 103: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl102 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<Namable";
  endingTag = "</Namable>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"Namable\"");
} // If
pw.Write('\n');
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write("/>");
pw.Write('\n');
unParseBody(pw);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
}

}
public abstract partial class ReferencesParagraph
: DataDictionary.Namable
{
public  override  bool find(Object search){
if (search is String ) {
if(getComment().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.ReferencesParagraphController.alertChange(aLock, this);
}
private System.Collections.ArrayList aRequirements;

/// <summary>Part of the list interface for Requirements</summary>
/// <returns>a collection of all the elements in Requirements</returns>
public System.Collections.ArrayList allRequirements()
  {
if (aRequirements == null){
    setAllRequirements( new System.Collections.ArrayList() );
} // If
    return aRequirements;
  }

/// <summary>Part of the list interface for Requirements</summary>
/// <returns>a collection of all the elements in Requirements</returns>
private System.Collections.ArrayList getRequirements()
  {
    return allRequirements();
  }

/// <summary>Part of the list interface for Requirements</summary>
/// <param name="coll">a collection of elements which replaces 
///        Requirements's current content.</param>
public void setAllRequirements(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aRequirements = coll;
    NotifyControllers(null);
  }
public void setAllRequirements(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aRequirements = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Requirements</summary>
/// <param name="el">a ReqRef to add to the collection in 
///           Requirements</param>
/// <seealso cref="appendRequirements(ICollection)"/>
public void appendRequirements(ReqRef el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allRequirements().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendRequirements(Lock aLock,ReqRef el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allRequirements().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Requirements</summary>
/// <param name="coll">a collection ofReqRefs to add to the collection in 
///           Requirements</param>
/// <seealso cref="appendRequirements(ReqRef)"/>
public void appendRequirements(ICollection coll)
  {
  __setDirty(true);
  allRequirements().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendRequirements(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allRequirements().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Requirements
/// This insertion function inserts a new element in the
/// collection in Requirements</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertRequirements(int idx, ReqRef el)
  {
  __setDirty(true);
  allRequirements().Insert (idx, el);
NotifyControllers(null);
  }

public void insertRequirements(int idx, ReqRef el,Lock aLock)
  {
  __setDirty(true);
  allRequirements().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Requirements
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfRequirements(IXmlBBase el)
  {
  return allRequirements().IndexOf (el);
  }

/// <summary>Part of the list interface for Requirements
/// This deletion function removes an element from the
/// collection in Requirements</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteRequirements(int idx)
  {
  __setDirty(true);
  allRequirements().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteRequirements(int idx,Lock aLock)
  {
  __setDirty(true);
  allRequirements().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Requirements
/// This deletion function removes an element from the
/// collection in Requirements
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeRequirements(IXmlBBase obj)
  {
  int idx = indexOfRequirements(obj);
  if (idx >= 0) { deleteRequirements(idx);
NotifyControllers(null);
   }
  }

public void removeRequirements(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfRequirements(obj);
  if (idx >= 0) { deleteRequirements(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Requirements</summary>
/// <returns>the number of elements in Requirements</returns>
public int countRequirements()
  {
  return allRequirements().Count;
  }

/// <summary>Part of the list interface for Requirements
/// This function returns an element from the
/// collection in Requirements based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public ReqRef getRequirements(int idx)
{
  return (ReqRef) ( allRequirements()[idx]);
}

private   string  aComment;

public   string  getComment() { return aComment;}
public  void setComment( string  v) {
  aComment = v;
  __setDirty(true);
  NotifyControllers(null);
}

public ReferencesParagraph()
{
ReferencesParagraph obj = this;
aRequirements=(null);
aComment=(null);
}

public void copyTo(ReferencesParagraph other)
{
base.copyTo(other);
other.aRequirements = aRequirements;
other.aComment = aComment;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
ReqRef fl106;
bool fl117;

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
// Repeat
ctxt.skipWhiteSpace();
fl106 = null;
while(ctxt.lookAheadOpeningTag ("<ReqRef")) {
fl106 = acceptor.lAccept_ReqRef(ctxt, null);
appendRequirements(fl106);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Comment")){
ctxt.skipWhiteSpace();
fl117 = true ; 
while (fl117) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl117 = false ; 
} // If
} // While
ctxt.accept('>');
// Indicator
// Parse PC data
this.setComment(acceptor.lAcceptPcData(ctxt, -1, '<',XmlBContext.WS_PRESERVE));
// Regexp
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Comment>");
} // If
// End enclosed
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl118;
bool fl119;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl118 = false ; 
fl119 = true ; 
while (fl119) { // BeginLoop 
if (ctxt.lookAheadString("Name=")){
indicator = 118;
} else {
indicator = 120;
} // If
switch (indicator) {
case 118: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl118){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl118 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 120: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl119 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<ReferencesParagraph";
  endingTag = "</ReferencesParagraph>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"ReferencesParagraph\"");
} // If
pw.Write('\n');
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getRequirements(), false, null, null);
// Unparsing Enclosed
// Testing for empty content: Comment
if (this.getComment() != null){
pw.Write("<Comment>");
// Unparsing PcData
acceptor.unParsePcData(pw, this.getComment());
pw.Write("</Comment>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Comment
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
for (int i = 0; i < countRequirements(); i++) {
  l.Add(getRequirements(i));
}
}

}
public abstract partial class ReqRelated
: DataDictionary.ReferencesParagraph
{
public  override  bool find(Object search){
if (search is String ) {
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.ReqRelatedController.alertChange(aLock, this);
}
private  bool aImplemented;

public  bool getImplemented() { return aImplemented;}
public  void setImplemented(bool v) {
  aImplemented = v;
  __setDirty(true);
  NotifyControllers(null);
}

private  bool aVerified;

public  bool getVerified() { return aVerified;}
public  void setVerified(bool v) {
  aVerified = v;
  __setDirty(true);
  NotifyControllers(null);
}

private  bool aNeedsRequirement;

public  bool getNeedsRequirement() { return aNeedsRequirement;}
public  void setNeedsRequirement(bool v) {
  aNeedsRequirement = v;
  __setDirty(true);
  NotifyControllers(null);
}

public ReqRelated()
{
ReqRelated obj = this;
aImplemented=(false);
aVerified=(false);
aNeedsRequirement=(false);
}

public void copyTo(ReqRelated other)
{
base.copyTo(other);
other.aImplemented = aImplemented;
other.aVerified = aVerified;
other.aNeedsRequirement = aNeedsRequirement;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl122;
bool fl123;
bool fl124;
bool fl125;
bool fl126;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl122 = false ; 
fl123 = false ; 
fl124 = false ; 
fl125 = false ; 
fl126 = true ; 
while (fl126) { // BeginLoop 
switch (ctxt.current()) {
case 'V':
{
ctxt.advance();
if (ctxt.lookAheadString("erified=")){
indicator = 123;
} else {
indicator = 127;
} // If
break;
} // Case
case 'N':
{
ctxt.advance();
switch (ctxt.current()) {
case 'e':
{
ctxt.advance();
if (ctxt.lookAheadString("edsRequirement=")){
indicator = 124;
} else {
indicator = 127;
} // If
break;
} // Case
case 'a':
{
ctxt.advance();
if (ctxt.lookAhead3('m','e','=')){
indicator = 125;
} else {
indicator = 127;
} // If
break;
} // Case
default:
indicator = 127;
break;
} // Switch
break;
} // Case
case 'I':
{
ctxt.advance();
if (ctxt.lookAheadString("mplemented=")){
indicator = 122;
} else {
indicator = 127;
} // If
break;
} // Case
default:
indicator = 127;
break;
} // Switch
switch (indicator) {
case 122: {
// Handling attribute Implemented
// Also handles alien attributes with prefix Implemented
if (fl122){
ctxt.fail ("Duplicate attribute: Implemented");
} // If
fl122 = true ; 
quoteChar = ctxt.acceptQuote();
this.setImplemented(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 123: {
// Handling attribute Verified
// Also handles alien attributes with prefix Verified
if (fl123){
ctxt.fail ("Duplicate attribute: Verified");
} // If
fl123 = true ; 
quoteChar = ctxt.acceptQuote();
this.setVerified(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 124: {
// Handling attribute NeedsRequirement
// Also handles alien attributes with prefix NeedsRequirement
if (fl124){
ctxt.fail ("Duplicate attribute: NeedsRequirement");
} // If
fl124 = true ; 
quoteChar = ctxt.acceptQuote();
this.setNeedsRequirement(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 125: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl125){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl125 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 127: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl122){
this.setImplemented( false);
} // If
if (!fl123){
this.setVerified( false);
} // If
if (!fl124){
this.setNeedsRequirement( true);
} // If
fl126 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<ReqRelated";
  endingTag = "</ReqRelated>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"ReqRelated\"");
} // If
pw.Write('\n');
if (this.getImplemented()){
pw.Write(" Implemented=\"");
acceptor.unParsePcData(pw, this.getImplemented());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getVerified()){
pw.Write(" Verified=\"");
acceptor.unParsePcData(pw, this.getVerified());
pw.Write('"');
pw.Write('\n');
} // If
if (!this.getNeedsRequirement()){
pw.Write(" NeedsRequirement=\"");
acceptor.unParsePcData(pw, this.getNeedsRequirement());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
}

}
public partial class Dictionary
: ModelElement
{
public  override  bool find(Object search){
if (search is String ) {
if(getXsi().CompareTo((String) search) == 0)return true;
if(getXsiLocation().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.DictionaryController.alertChange(aLock, this);
}
private  Specification aSpecification;

public  Specification getSpecification() { return aSpecification;}
public  void setSpecification(Specification v) {
  aSpecification = v;
  if ( v != null ) { 
    v.setFather(this);
  }
  __setDirty(true);
  NotifyControllers(null);
}

private System.Collections.ArrayList aRuleDisablings;

/// <summary>Part of the list interface for RuleDisablings</summary>
/// <returns>a collection of all the elements in RuleDisablings</returns>
public System.Collections.ArrayList allRuleDisablings()
  {
if (aRuleDisablings == null){
    setAllRuleDisablings( new System.Collections.ArrayList() );
} // If
    return aRuleDisablings;
  }

/// <summary>Part of the list interface for RuleDisablings</summary>
/// <returns>a collection of all the elements in RuleDisablings</returns>
private System.Collections.ArrayList getRuleDisablings()
  {
    return allRuleDisablings();
  }

/// <summary>Part of the list interface for RuleDisablings</summary>
/// <param name="coll">a collection of elements which replaces 
///        RuleDisablings's current content.</param>
public void setAllRuleDisablings(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aRuleDisablings = coll;
    NotifyControllers(null);
  }
public void setAllRuleDisablings(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aRuleDisablings = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for RuleDisablings</summary>
/// <param name="el">a RuleDisabling to add to the collection in 
///           RuleDisablings</param>
/// <seealso cref="appendRuleDisablings(ICollection)"/>
public void appendRuleDisablings(RuleDisabling el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allRuleDisablings().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendRuleDisablings(Lock aLock,RuleDisabling el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allRuleDisablings().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for RuleDisablings</summary>
/// <param name="coll">a collection ofRuleDisablings to add to the collection in 
///           RuleDisablings</param>
/// <seealso cref="appendRuleDisablings(RuleDisabling)"/>
public void appendRuleDisablings(ICollection coll)
  {
  __setDirty(true);
  allRuleDisablings().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendRuleDisablings(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allRuleDisablings().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for RuleDisablings
/// This insertion function inserts a new element in the
/// collection in RuleDisablings</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertRuleDisablings(int idx, RuleDisabling el)
  {
  __setDirty(true);
  allRuleDisablings().Insert (idx, el);
NotifyControllers(null);
  }

public void insertRuleDisablings(int idx, RuleDisabling el,Lock aLock)
  {
  __setDirty(true);
  allRuleDisablings().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for RuleDisablings
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfRuleDisablings(IXmlBBase el)
  {
  return allRuleDisablings().IndexOf (el);
  }

/// <summary>Part of the list interface for RuleDisablings
/// This deletion function removes an element from the
/// collection in RuleDisablings</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteRuleDisablings(int idx)
  {
  __setDirty(true);
  allRuleDisablings().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteRuleDisablings(int idx,Lock aLock)
  {
  __setDirty(true);
  allRuleDisablings().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for RuleDisablings
/// This deletion function removes an element from the
/// collection in RuleDisablings
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeRuleDisablings(IXmlBBase obj)
  {
  int idx = indexOfRuleDisablings(obj);
  if (idx >= 0) { deleteRuleDisablings(idx);
NotifyControllers(null);
   }
  }

public void removeRuleDisablings(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfRuleDisablings(obj);
  if (idx >= 0) { deleteRuleDisablings(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for RuleDisablings</summary>
/// <returns>the number of elements in RuleDisablings</returns>
public int countRuleDisablings()
  {
  return allRuleDisablings().Count;
  }

/// <summary>Part of the list interface for RuleDisablings
/// This function returns an element from the
/// collection in RuleDisablings based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public RuleDisabling getRuleDisablings(int idx)
{
  return (RuleDisabling) ( allRuleDisablings()[idx]);
}

private System.Collections.ArrayList aNameSpaces;

/// <summary>Part of the list interface for NameSpaces</summary>
/// <returns>a collection of all the elements in NameSpaces</returns>
public System.Collections.ArrayList allNameSpaces()
  {
if (aNameSpaces == null){
    setAllNameSpaces( new System.Collections.ArrayList() );
} // If
    return aNameSpaces;
  }

/// <summary>Part of the list interface for NameSpaces</summary>
/// <returns>a collection of all the elements in NameSpaces</returns>
private System.Collections.ArrayList getNameSpaces()
  {
    return allNameSpaces();
  }

/// <summary>Part of the list interface for NameSpaces</summary>
/// <param name="coll">a collection of elements which replaces 
///        NameSpaces's current content.</param>
public void setAllNameSpaces(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aNameSpaces = coll;
    NotifyControllers(null);
  }
public void setAllNameSpaces(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aNameSpaces = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for NameSpaces</summary>
/// <param name="el">a NameSpace to add to the collection in 
///           NameSpaces</param>
/// <seealso cref="appendNameSpaces(ICollection)"/>
public void appendNameSpaces(NameSpace el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allNameSpaces().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendNameSpaces(Lock aLock,NameSpace el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allNameSpaces().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for NameSpaces</summary>
/// <param name="coll">a collection ofNameSpaces to add to the collection in 
///           NameSpaces</param>
/// <seealso cref="appendNameSpaces(NameSpace)"/>
public void appendNameSpaces(ICollection coll)
  {
  __setDirty(true);
  allNameSpaces().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendNameSpaces(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allNameSpaces().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for NameSpaces
/// This insertion function inserts a new element in the
/// collection in NameSpaces</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertNameSpaces(int idx, NameSpace el)
  {
  __setDirty(true);
  allNameSpaces().Insert (idx, el);
NotifyControllers(null);
  }

public void insertNameSpaces(int idx, NameSpace el,Lock aLock)
  {
  __setDirty(true);
  allNameSpaces().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for NameSpaces
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfNameSpaces(IXmlBBase el)
  {
  return allNameSpaces().IndexOf (el);
  }

/// <summary>Part of the list interface for NameSpaces
/// This deletion function removes an element from the
/// collection in NameSpaces</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteNameSpaces(int idx)
  {
  __setDirty(true);
  allNameSpaces().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteNameSpaces(int idx,Lock aLock)
  {
  __setDirty(true);
  allNameSpaces().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for NameSpaces
/// This deletion function removes an element from the
/// collection in NameSpaces
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeNameSpaces(IXmlBBase obj)
  {
  int idx = indexOfNameSpaces(obj);
  if (idx >= 0) { deleteNameSpaces(idx);
NotifyControllers(null);
   }
  }

public void removeNameSpaces(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfNameSpaces(obj);
  if (idx >= 0) { deleteNameSpaces(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for NameSpaces</summary>
/// <returns>the number of elements in NameSpaces</returns>
public int countNameSpaces()
  {
  return allNameSpaces().Count;
  }

/// <summary>Part of the list interface for NameSpaces
/// This function returns an element from the
/// collection in NameSpaces based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public NameSpace getNameSpaces(int idx)
{
  return (NameSpace) ( allNameSpaces()[idx]);
}

private System.Collections.ArrayList aTests;

/// <summary>Part of the list interface for Tests</summary>
/// <returns>a collection of all the elements in Tests</returns>
public System.Collections.ArrayList allTests()
  {
if (aTests == null){
    setAllTests( new System.Collections.ArrayList() );
} // If
    return aTests;
  }

/// <summary>Part of the list interface for Tests</summary>
/// <returns>a collection of all the elements in Tests</returns>
private System.Collections.ArrayList getTests()
  {
    return allTests();
  }

/// <summary>Part of the list interface for Tests</summary>
/// <param name="coll">a collection of elements which replaces 
///        Tests's current content.</param>
public void setAllTests(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aTests = coll;
    NotifyControllers(null);
  }
public void setAllTests(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aTests = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Tests</summary>
/// <param name="el">a Frame to add to the collection in 
///           Tests</param>
/// <seealso cref="appendTests(ICollection)"/>
public void appendTests(Frame el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allTests().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendTests(Lock aLock,Frame el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allTests().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Tests</summary>
/// <param name="coll">a collection ofFrames to add to the collection in 
///           Tests</param>
/// <seealso cref="appendTests(Frame)"/>
public void appendTests(ICollection coll)
  {
  __setDirty(true);
  allTests().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendTests(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allTests().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Tests
/// This insertion function inserts a new element in the
/// collection in Tests</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertTests(int idx, Frame el)
  {
  __setDirty(true);
  allTests().Insert (idx, el);
NotifyControllers(null);
  }

public void insertTests(int idx, Frame el,Lock aLock)
  {
  __setDirty(true);
  allTests().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Tests
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfTests(IXmlBBase el)
  {
  return allTests().IndexOf (el);
  }

/// <summary>Part of the list interface for Tests
/// This deletion function removes an element from the
/// collection in Tests</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteTests(int idx)
  {
  __setDirty(true);
  allTests().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteTests(int idx,Lock aLock)
  {
  __setDirty(true);
  allTests().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Tests
/// This deletion function removes an element from the
/// collection in Tests
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeTests(IXmlBBase obj)
  {
  int idx = indexOfTests(obj);
  if (idx >= 0) { deleteTests(idx);
NotifyControllers(null);
   }
  }

public void removeTests(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfTests(obj);
  if (idx >= 0) { deleteTests(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Tests</summary>
/// <returns>the number of elements in Tests</returns>
public int countTests()
  {
  return allTests().Count;
  }

/// <summary>Part of the list interface for Tests
/// This function returns an element from the
/// collection in Tests based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Frame getTests(int idx)
{
  return (Frame) ( allTests()[idx]);
}

private  TranslationDictionary aTranslationDictionary;

public  TranslationDictionary getTranslationDictionary() { return aTranslationDictionary;}
public  void setTranslationDictionary(TranslationDictionary v) {
  aTranslationDictionary = v;
  if ( v != null ) { 
    v.setFather(this);
  }
  __setDirty(true);
  NotifyControllers(null);
}

private  ShortcutDictionary aShortcutDictionary;

public  ShortcutDictionary getShortcutDictionary() { return aShortcutDictionary;}
public  void setShortcutDictionary(ShortcutDictionary v) {
  aShortcutDictionary = v;
  if ( v != null ) { 
    v.setFather(this);
  }
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aXsi;

public   string  getXsi() { return aXsi;}
public  void setXsi( string  v) {
  aXsi = v;
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aXsiLocation;

public   string  getXsiLocation() { return aXsiLocation;}
public  void setXsiLocation( string  v) {
  aXsiLocation = v;
  __setDirty(true);
  NotifyControllers(null);
}

public Dictionary()
{
Dictionary obj = this;
aSpecification=(null);
aRuleDisablings=(null);
aNameSpaces=(null);
aTests=(null);
aTranslationDictionary=(null);
aShortcutDictionary=(null);
aXsi=(null);
aXsiLocation=(null);
}

public void copyTo(Dictionary other)
{
other.aSpecification = aSpecification;
other.aRuleDisablings = aRuleDisablings;
other.aNameSpaces = aNameSpaces;
other.aTests = aTests;
other.aTranslationDictionary = aTranslationDictionary;
other.aShortcutDictionary = aShortcutDictionary;
other.aXsi = aXsi;
other.aXsiLocation = aXsiLocation;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
bool fl134;
RuleDisabling fl136;
bool fl147;
NameSpace fl149;
bool fl160;
Frame fl162;

ctxt.skipWhiteSpace();
// Element Ref : Specification
ctxt.skipWhiteSpace();
// If optional...
if (ctxt.lookAheadOpeningTag("<Specification")){
// Parsing sub element
this.setSpecification(acceptor.lAccept_Specification(ctxt,"</Specification>"));
setSon(this.getSpecification());
// Endif optional...
} // If
ctxt.skipWhiteSpace();
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<RuleDisabling")){
ctxt.skipWhiteSpace();
fl134 = true ; 
while (fl134) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl134 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl136 = null;
while(ctxt.lookAheadOpeningTag ("<RuleDisabling")) {
fl136 = acceptor.lAccept_RuleDisabling(ctxt, "</RuleDisabling>");
appendRuleDisablings(fl136);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</RuleDisabling>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Enclosed
ctxt.acceptString ("<NameSpaces");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
ctxt.skipWhiteSpace();
fl147 = true ; 
while (fl147) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl147 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl149 = null;
while(ctxt.lookAheadOpeningTag ("<NameSpace")) {
fl149 = acceptor.lAccept_NameSpace(ctxt, "</NameSpace>");
appendNameSpaces(fl149);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</NameSpaces>");
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Tests")){
ctxt.skipWhiteSpace();
fl160 = true ; 
while (fl160) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl160 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl162 = null;
while(ctxt.lookAheadOpeningTag ("<Frame")) {
fl162 = acceptor.lAccept_Frame(ctxt, "</Frame>");
appendTests(fl162);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Tests>");
} // If
} // If
// End enclosed
// Element Ref : TranslationDictionary
ctxt.skipWhiteSpace();
// If optional...
if (ctxt.lookAheadOpeningTag("<TranslationDictionary")){
// Parsing sub element
this.setTranslationDictionary(acceptor.lAccept_TranslationDictionary(ctxt,"</TranslationDictionary>"));
setSon(this.getTranslationDictionary());
// Endif optional...
} // If
ctxt.skipWhiteSpace();
// Element Ref : ShortcutDictionary
ctxt.skipWhiteSpace();
// If optional...
if (ctxt.lookAheadOpeningTag("<ShortcutDictionary")){
// Parsing sub element
this.setShortcutDictionary(acceptor.lAccept_ShortcutDictionary(ctxt,"</ShortcutDictionary>"));
setSon(this.getShortcutDictionary());
// Endif optional...
} // If
ctxt.skipWhiteSpace();
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl173;
bool fl174;
bool fl175;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl173 = false ; 
fl174 = false ; 
fl175 = true ; 
while (fl175) { // BeginLoop 
switch (ctxt.current()) {
case 'x':
{
ctxt.advance();
switch (ctxt.current()) {
case 's':
{
ctxt.advance();
if (ctxt.lookAheadString("i:noNamespaceSchemaLocation=")){
indicator = 174;
} else {
indicator = 176;
} // If
break;
} // Case
case 'm':
{
ctxt.advance();
if (ctxt.lookAheadString("lns:xsi=")){
indicator = 173;
} else {
indicator = 176;
} // If
break;
} // Case
default:
indicator = 176;
break;
} // Switch
break;
} // Case
default:
indicator = 176;
break;
} // Switch
switch (indicator) {
case 173: {
// Handling attribute xmlns:xsi
// Also handles alien attributes with prefix xmlns:xsi
if (fl173){
ctxt.fail ("Duplicate attribute: xmlns:xsi");
} // If
fl173 = true ; 
quoteChar = ctxt.acceptQuote();
this.setXsi((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 174: {
// Handling attribute xsi:noNamespaceSchemaLocation
// Also handles alien attributes with prefix xsi:noNamespaceSchemaLocation
if (fl174){
ctxt.fail ("Duplicate attribute: xsi:noNamespaceSchemaLocation");
} // If
fl174 = true ; 
quoteChar = ctxt.acceptQuote();
this.setXsiLocation((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 176: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl173){
ctxt.fail ("Mandatory attribute missing: xmlns:xsi in Dictionary");
} // If
if (!fl174){
ctxt.fail ("Mandatory attribute missing: xsi:noNamespaceSchemaLocation in Dictionary");
} // If
fl175 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString ("</Dictionary>");
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

pw.Write("<Dictionary");
if (typeId){
pw.Write(" xsi:type=\"Dictionary\"");
} // If
pw.Write('\n');
pw.Write(" xmlns:xsi=\"");
acceptor.unParsePcData(pw, this.getXsi());
pw.Write('"');
pw.Write('\n');
pw.Write(" xsi:noNamespaceSchemaLocation=\"");
acceptor.unParsePcData(pw, this.getXsiLocation());
pw.Write('"');
pw.Write('\n');
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write("</Dictionary>");
pw.Write('\n');
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

// Unparsing ElementRef
if (this.getSpecification() != null){
unParse(pw, this.getSpecification(),false,"<Specification","</Specification>");
} // If
// Unparsing Enclosed
// Testing for empty content: RuleDisablings
if (countRuleDisablings() > 0){
pw.Write("<RuleDisabling>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getRuleDisablings(), false, "<RuleDisabling", "</RuleDisabling>");
pw.Write("</RuleDisabling>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: RuleDisablings
// Unparsing Enclosed
pw.Write("<NameSpaces>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getNameSpaces(), false, "<NameSpace", "</NameSpace>");
pw.Write("</NameSpaces>");
// Father is not a mixed
pw.Write('\n');
// Unparsing Enclosed
// Testing for empty content: Tests
if (countTests() > 0){
pw.Write("<Tests>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getTests(), false, "<Frame", "</Frame>");
pw.Write("</Tests>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Tests
// Unparsing ElementRef
if (this.getTranslationDictionary() != null){
unParse(pw, this.getTranslationDictionary(),false,"<TranslationDictionary","</TranslationDictionary>");
} // If
// Unparsing ElementRef
if (this.getShortcutDictionary() != null){
unParse(pw, this.getShortcutDictionary(),false,"<ShortcutDictionary","</ShortcutDictionary>");
} // If
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
l.Add(this.getSpecification());
for (int i = 0; i < countRuleDisablings(); i++) {
  l.Add(getRuleDisablings(i));
}
for (int i = 0; i < countNameSpaces(); i++) {
  l.Add(getNameSpaces(i));
}
for (int i = 0; i < countTests(); i++) {
  l.Add(getTests(i));
}
l.Add(this.getTranslationDictionary());
l.Add(this.getShortcutDictionary());
}

}
public partial class RuleDisabling
: DataDictionary.ReqRelated
{
public  override  bool find(Object search){
if (search is String ) {
if(getRule().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.RuleDisablingController.alertChange(aLock, this);
}
private   string  aRule;

public   string  getRule() { return aRule;}
public  void setRule( string  v) {
  aRule = v;
  __setDirty(true);
  NotifyControllers(null);
}

public RuleDisabling()
{
RuleDisabling obj = this;
aRule=(null);
}

public void copyTo(RuleDisabling other)
{
base.copyTo(other);
other.aRule = aRule;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl181;
bool fl182;
bool fl183;
bool fl184;
bool fl185;
bool fl186;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl181 = false ; 
fl182 = false ; 
fl183 = false ; 
fl184 = false ; 
fl185 = false ; 
fl186 = true ; 
while (fl186) { // BeginLoop 
switch (ctxt.current()) {
case 'V':
{
ctxt.advance();
if (ctxt.lookAheadString("erified=")){
indicator = 183;
} else {
indicator = 187;
} // If
break;
} // Case
case 'R':
{
ctxt.advance();
if (ctxt.lookAheadString("ule=")){
indicator = 181;
} else {
indicator = 187;
} // If
break;
} // Case
case 'N':
{
ctxt.advance();
switch (ctxt.current()) {
case 'e':
{
ctxt.advance();
if (ctxt.lookAheadString("edsRequirement=")){
indicator = 184;
} else {
indicator = 187;
} // If
break;
} // Case
case 'a':
{
ctxt.advance();
if (ctxt.lookAhead3('m','e','=')){
indicator = 185;
} else {
indicator = 187;
} // If
break;
} // Case
default:
indicator = 187;
break;
} // Switch
break;
} // Case
case 'I':
{
ctxt.advance();
if (ctxt.lookAheadString("mplemented=")){
indicator = 182;
} else {
indicator = 187;
} // If
break;
} // Case
default:
indicator = 187;
break;
} // Switch
switch (indicator) {
case 181: {
// Handling attribute Rule
// Also handles alien attributes with prefix Rule
if (fl181){
ctxt.fail ("Duplicate attribute: Rule");
} // If
fl181 = true ; 
quoteChar = ctxt.acceptQuote();
this.setRule((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 182: {
// Handling attribute Implemented
// Also handles alien attributes with prefix Implemented
if (fl182){
ctxt.fail ("Duplicate attribute: Implemented");
} // If
fl182 = true ; 
quoteChar = ctxt.acceptQuote();
this.setImplemented(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 183: {
// Handling attribute Verified
// Also handles alien attributes with prefix Verified
if (fl183){
ctxt.fail ("Duplicate attribute: Verified");
} // If
fl183 = true ; 
quoteChar = ctxt.acceptQuote();
this.setVerified(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 184: {
// Handling attribute NeedsRequirement
// Also handles alien attributes with prefix NeedsRequirement
if (fl184){
ctxt.fail ("Duplicate attribute: NeedsRequirement");
} // If
fl184 = true ; 
quoteChar = ctxt.acceptQuote();
this.setNeedsRequirement(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 185: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl185){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl185 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 187: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl181){
ctxt.fail ("Mandatory attribute missing: Rule in RuleDisabling");
} // If
if (!fl182){
this.setImplemented( false);
} // If
if (!fl183){
this.setVerified( false);
} // If
if (!fl184){
this.setNeedsRequirement( true);
} // If
fl186 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<RuleDisabling";
  endingTag = "</RuleDisabling>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"RuleDisabling\"");
} // If
pw.Write('\n');
pw.Write(" Rule=\"");
acceptor.unParsePcData(pw, this.getRule());
pw.Write('"');
pw.Write('\n');
if (this.getImplemented()){
pw.Write(" Implemented=\"");
acceptor.unParsePcData(pw, this.getImplemented());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getVerified()){
pw.Write(" Verified=\"");
acceptor.unParsePcData(pw, this.getVerified());
pw.Write('"');
pw.Write('\n');
} // If
if (!this.getNeedsRequirement()){
pw.Write(" NeedsRequirement=\"");
acceptor.unParsePcData(pw, this.getNeedsRequirement());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
}

}
public partial class NameSpace
: DataDictionary.Namable
{
public  override  bool find(Object search){
if (search is String ) {
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.NameSpaceController.alertChange(aLock, this);
}
private System.Collections.ArrayList aNameSpaces;

/// <summary>Part of the list interface for NameSpaces</summary>
/// <returns>a collection of all the elements in NameSpaces</returns>
public System.Collections.ArrayList allNameSpaces()
  {
if (aNameSpaces == null){
    setAllNameSpaces( new System.Collections.ArrayList() );
} // If
    return aNameSpaces;
  }

/// <summary>Part of the list interface for NameSpaces</summary>
/// <returns>a collection of all the elements in NameSpaces</returns>
private System.Collections.ArrayList getNameSpaces()
  {
    return allNameSpaces();
  }

/// <summary>Part of the list interface for NameSpaces</summary>
/// <param name="coll">a collection of elements which replaces 
///        NameSpaces's current content.</param>
public void setAllNameSpaces(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aNameSpaces = coll;
    NotifyControllers(null);
  }
public void setAllNameSpaces(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aNameSpaces = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for NameSpaces</summary>
/// <param name="el">a NameSpace to add to the collection in 
///           NameSpaces</param>
/// <seealso cref="appendNameSpaces(ICollection)"/>
public void appendNameSpaces(NameSpace el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allNameSpaces().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendNameSpaces(Lock aLock,NameSpace el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allNameSpaces().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for NameSpaces</summary>
/// <param name="coll">a collection ofNameSpaces to add to the collection in 
///           NameSpaces</param>
/// <seealso cref="appendNameSpaces(NameSpace)"/>
public void appendNameSpaces(ICollection coll)
  {
  __setDirty(true);
  allNameSpaces().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendNameSpaces(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allNameSpaces().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for NameSpaces
/// This insertion function inserts a new element in the
/// collection in NameSpaces</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertNameSpaces(int idx, NameSpace el)
  {
  __setDirty(true);
  allNameSpaces().Insert (idx, el);
NotifyControllers(null);
  }

public void insertNameSpaces(int idx, NameSpace el,Lock aLock)
  {
  __setDirty(true);
  allNameSpaces().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for NameSpaces
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfNameSpaces(IXmlBBase el)
  {
  return allNameSpaces().IndexOf (el);
  }

/// <summary>Part of the list interface for NameSpaces
/// This deletion function removes an element from the
/// collection in NameSpaces</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteNameSpaces(int idx)
  {
  __setDirty(true);
  allNameSpaces().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteNameSpaces(int idx,Lock aLock)
  {
  __setDirty(true);
  allNameSpaces().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for NameSpaces
/// This deletion function removes an element from the
/// collection in NameSpaces
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeNameSpaces(IXmlBBase obj)
  {
  int idx = indexOfNameSpaces(obj);
  if (idx >= 0) { deleteNameSpaces(idx);
NotifyControllers(null);
   }
  }

public void removeNameSpaces(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfNameSpaces(obj);
  if (idx >= 0) { deleteNameSpaces(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for NameSpaces</summary>
/// <returns>the number of elements in NameSpaces</returns>
public int countNameSpaces()
  {
  return allNameSpaces().Count;
  }

/// <summary>Part of the list interface for NameSpaces
/// This function returns an element from the
/// collection in NameSpaces based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public NameSpace getNameSpaces(int idx)
{
  return (NameSpace) ( allNameSpaces()[idx]);
}

private System.Collections.ArrayList aRanges;

/// <summary>Part of the list interface for Ranges</summary>
/// <returns>a collection of all the elements in Ranges</returns>
public System.Collections.ArrayList allRanges()
  {
if (aRanges == null){
    setAllRanges( new System.Collections.ArrayList() );
} // If
    return aRanges;
  }

/// <summary>Part of the list interface for Ranges</summary>
/// <returns>a collection of all the elements in Ranges</returns>
private System.Collections.ArrayList getRanges()
  {
    return allRanges();
  }

/// <summary>Part of the list interface for Ranges</summary>
/// <param name="coll">a collection of elements which replaces 
///        Ranges's current content.</param>
public void setAllRanges(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aRanges = coll;
    NotifyControllers(null);
  }
public void setAllRanges(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aRanges = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Ranges</summary>
/// <param name="el">a Range to add to the collection in 
///           Ranges</param>
/// <seealso cref="appendRanges(ICollection)"/>
public void appendRanges(Range el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allRanges().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendRanges(Lock aLock,Range el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allRanges().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Ranges</summary>
/// <param name="coll">a collection ofRanges to add to the collection in 
///           Ranges</param>
/// <seealso cref="appendRanges(Range)"/>
public void appendRanges(ICollection coll)
  {
  __setDirty(true);
  allRanges().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendRanges(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allRanges().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Ranges
/// This insertion function inserts a new element in the
/// collection in Ranges</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertRanges(int idx, Range el)
  {
  __setDirty(true);
  allRanges().Insert (idx, el);
NotifyControllers(null);
  }

public void insertRanges(int idx, Range el,Lock aLock)
  {
  __setDirty(true);
  allRanges().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Ranges
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfRanges(IXmlBBase el)
  {
  return allRanges().IndexOf (el);
  }

/// <summary>Part of the list interface for Ranges
/// This deletion function removes an element from the
/// collection in Ranges</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteRanges(int idx)
  {
  __setDirty(true);
  allRanges().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteRanges(int idx,Lock aLock)
  {
  __setDirty(true);
  allRanges().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Ranges
/// This deletion function removes an element from the
/// collection in Ranges
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeRanges(IXmlBBase obj)
  {
  int idx = indexOfRanges(obj);
  if (idx >= 0) { deleteRanges(idx);
NotifyControllers(null);
   }
  }

public void removeRanges(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfRanges(obj);
  if (idx >= 0) { deleteRanges(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Ranges</summary>
/// <returns>the number of elements in Ranges</returns>
public int countRanges()
  {
  return allRanges().Count;
  }

/// <summary>Part of the list interface for Ranges
/// This function returns an element from the
/// collection in Ranges based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Range getRanges(int idx)
{
  return (Range) ( allRanges()[idx]);
}

private System.Collections.ArrayList aEnumerations;

/// <summary>Part of the list interface for Enumerations</summary>
/// <returns>a collection of all the elements in Enumerations</returns>
public System.Collections.ArrayList allEnumerations()
  {
if (aEnumerations == null){
    setAllEnumerations( new System.Collections.ArrayList() );
} // If
    return aEnumerations;
  }

/// <summary>Part of the list interface for Enumerations</summary>
/// <returns>a collection of all the elements in Enumerations</returns>
private System.Collections.ArrayList getEnumerations()
  {
    return allEnumerations();
  }

/// <summary>Part of the list interface for Enumerations</summary>
/// <param name="coll">a collection of elements which replaces 
///        Enumerations's current content.</param>
public void setAllEnumerations(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aEnumerations = coll;
    NotifyControllers(null);
  }
public void setAllEnumerations(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aEnumerations = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Enumerations</summary>
/// <param name="el">a Enum to add to the collection in 
///           Enumerations</param>
/// <seealso cref="appendEnumerations(ICollection)"/>
public void appendEnumerations(Enum el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allEnumerations().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendEnumerations(Lock aLock,Enum el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allEnumerations().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Enumerations</summary>
/// <param name="coll">a collection ofEnums to add to the collection in 
///           Enumerations</param>
/// <seealso cref="appendEnumerations(Enum)"/>
public void appendEnumerations(ICollection coll)
  {
  __setDirty(true);
  allEnumerations().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendEnumerations(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allEnumerations().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Enumerations
/// This insertion function inserts a new element in the
/// collection in Enumerations</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertEnumerations(int idx, Enum el)
  {
  __setDirty(true);
  allEnumerations().Insert (idx, el);
NotifyControllers(null);
  }

public void insertEnumerations(int idx, Enum el,Lock aLock)
  {
  __setDirty(true);
  allEnumerations().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Enumerations
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfEnumerations(IXmlBBase el)
  {
  return allEnumerations().IndexOf (el);
  }

/// <summary>Part of the list interface for Enumerations
/// This deletion function removes an element from the
/// collection in Enumerations</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteEnumerations(int idx)
  {
  __setDirty(true);
  allEnumerations().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteEnumerations(int idx,Lock aLock)
  {
  __setDirty(true);
  allEnumerations().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Enumerations
/// This deletion function removes an element from the
/// collection in Enumerations
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeEnumerations(IXmlBBase obj)
  {
  int idx = indexOfEnumerations(obj);
  if (idx >= 0) { deleteEnumerations(idx);
NotifyControllers(null);
   }
  }

public void removeEnumerations(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfEnumerations(obj);
  if (idx >= 0) { deleteEnumerations(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Enumerations</summary>
/// <returns>the number of elements in Enumerations</returns>
public int countEnumerations()
  {
  return allEnumerations().Count;
  }

/// <summary>Part of the list interface for Enumerations
/// This function returns an element from the
/// collection in Enumerations based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Enum getEnumerations(int idx)
{
  return (Enum) ( allEnumerations()[idx]);
}

private System.Collections.ArrayList aStructures;

/// <summary>Part of the list interface for Structures</summary>
/// <returns>a collection of all the elements in Structures</returns>
public System.Collections.ArrayList allStructures()
  {
if (aStructures == null){
    setAllStructures( new System.Collections.ArrayList() );
} // If
    return aStructures;
  }

/// <summary>Part of the list interface for Structures</summary>
/// <returns>a collection of all the elements in Structures</returns>
private System.Collections.ArrayList getStructures()
  {
    return allStructures();
  }

/// <summary>Part of the list interface for Structures</summary>
/// <param name="coll">a collection of elements which replaces 
///        Structures's current content.</param>
public void setAllStructures(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aStructures = coll;
    NotifyControllers(null);
  }
public void setAllStructures(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aStructures = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Structures</summary>
/// <param name="el">a Structure to add to the collection in 
///           Structures</param>
/// <seealso cref="appendStructures(ICollection)"/>
public void appendStructures(Structure el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allStructures().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendStructures(Lock aLock,Structure el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allStructures().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Structures</summary>
/// <param name="coll">a collection ofStructures to add to the collection in 
///           Structures</param>
/// <seealso cref="appendStructures(Structure)"/>
public void appendStructures(ICollection coll)
  {
  __setDirty(true);
  allStructures().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendStructures(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allStructures().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Structures
/// This insertion function inserts a new element in the
/// collection in Structures</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertStructures(int idx, Structure el)
  {
  __setDirty(true);
  allStructures().Insert (idx, el);
NotifyControllers(null);
  }

public void insertStructures(int idx, Structure el,Lock aLock)
  {
  __setDirty(true);
  allStructures().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Structures
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfStructures(IXmlBBase el)
  {
  return allStructures().IndexOf (el);
  }

/// <summary>Part of the list interface for Structures
/// This deletion function removes an element from the
/// collection in Structures</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteStructures(int idx)
  {
  __setDirty(true);
  allStructures().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteStructures(int idx,Lock aLock)
  {
  __setDirty(true);
  allStructures().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Structures
/// This deletion function removes an element from the
/// collection in Structures
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeStructures(IXmlBBase obj)
  {
  int idx = indexOfStructures(obj);
  if (idx >= 0) { deleteStructures(idx);
NotifyControllers(null);
   }
  }

public void removeStructures(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfStructures(obj);
  if (idx >= 0) { deleteStructures(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Structures</summary>
/// <returns>the number of elements in Structures</returns>
public int countStructures()
  {
  return allStructures().Count;
  }

/// <summary>Part of the list interface for Structures
/// This function returns an element from the
/// collection in Structures based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Structure getStructures(int idx)
{
  return (Structure) ( allStructures()[idx]);
}

private System.Collections.ArrayList aCollections;

/// <summary>Part of the list interface for Collections</summary>
/// <returns>a collection of all the elements in Collections</returns>
public System.Collections.ArrayList allCollections()
  {
if (aCollections == null){
    setAllCollections( new System.Collections.ArrayList() );
} // If
    return aCollections;
  }

/// <summary>Part of the list interface for Collections</summary>
/// <returns>a collection of all the elements in Collections</returns>
private System.Collections.ArrayList getCollections()
  {
    return allCollections();
  }

/// <summary>Part of the list interface for Collections</summary>
/// <param name="coll">a collection of elements which replaces 
///        Collections's current content.</param>
public void setAllCollections(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aCollections = coll;
    NotifyControllers(null);
  }
public void setAllCollections(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aCollections = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Collections</summary>
/// <param name="el">a Collection to add to the collection in 
///           Collections</param>
/// <seealso cref="appendCollections(ICollection)"/>
public void appendCollections(Collection el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allCollections().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendCollections(Lock aLock,Collection el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allCollections().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Collections</summary>
/// <param name="coll">a collection ofCollections to add to the collection in 
///           Collections</param>
/// <seealso cref="appendCollections(Collection)"/>
public void appendCollections(ICollection coll)
  {
  __setDirty(true);
  allCollections().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendCollections(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allCollections().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Collections
/// This insertion function inserts a new element in the
/// collection in Collections</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertCollections(int idx, Collection el)
  {
  __setDirty(true);
  allCollections().Insert (idx, el);
NotifyControllers(null);
  }

public void insertCollections(int idx, Collection el,Lock aLock)
  {
  __setDirty(true);
  allCollections().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Collections
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfCollections(IXmlBBase el)
  {
  return allCollections().IndexOf (el);
  }

/// <summary>Part of the list interface for Collections
/// This deletion function removes an element from the
/// collection in Collections</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteCollections(int idx)
  {
  __setDirty(true);
  allCollections().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteCollections(int idx,Lock aLock)
  {
  __setDirty(true);
  allCollections().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Collections
/// This deletion function removes an element from the
/// collection in Collections
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeCollections(IXmlBBase obj)
  {
  int idx = indexOfCollections(obj);
  if (idx >= 0) { deleteCollections(idx);
NotifyControllers(null);
   }
  }

public void removeCollections(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfCollections(obj);
  if (idx >= 0) { deleteCollections(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Collections</summary>
/// <returns>the number of elements in Collections</returns>
public int countCollections()
  {
  return allCollections().Count;
  }

/// <summary>Part of the list interface for Collections
/// This function returns an element from the
/// collection in Collections based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Collection getCollections(int idx)
{
  return (Collection) ( allCollections()[idx]);
}

private System.Collections.ArrayList aStateMachines;

/// <summary>Part of the list interface for StateMachines</summary>
/// <returns>a collection of all the elements in StateMachines</returns>
public System.Collections.ArrayList allStateMachines()
  {
if (aStateMachines == null){
    setAllStateMachines( new System.Collections.ArrayList() );
} // If
    return aStateMachines;
  }

/// <summary>Part of the list interface for StateMachines</summary>
/// <returns>a collection of all the elements in StateMachines</returns>
private System.Collections.ArrayList getStateMachines()
  {
    return allStateMachines();
  }

/// <summary>Part of the list interface for StateMachines</summary>
/// <param name="coll">a collection of elements which replaces 
///        StateMachines's current content.</param>
public void setAllStateMachines(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aStateMachines = coll;
    NotifyControllers(null);
  }
public void setAllStateMachines(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aStateMachines = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for StateMachines</summary>
/// <param name="el">a StateMachine to add to the collection in 
///           StateMachines</param>
/// <seealso cref="appendStateMachines(ICollection)"/>
public void appendStateMachines(StateMachine el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allStateMachines().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendStateMachines(Lock aLock,StateMachine el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allStateMachines().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for StateMachines</summary>
/// <param name="coll">a collection ofStateMachines to add to the collection in 
///           StateMachines</param>
/// <seealso cref="appendStateMachines(StateMachine)"/>
public void appendStateMachines(ICollection coll)
  {
  __setDirty(true);
  allStateMachines().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendStateMachines(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allStateMachines().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for StateMachines
/// This insertion function inserts a new element in the
/// collection in StateMachines</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertStateMachines(int idx, StateMachine el)
  {
  __setDirty(true);
  allStateMachines().Insert (idx, el);
NotifyControllers(null);
  }

public void insertStateMachines(int idx, StateMachine el,Lock aLock)
  {
  __setDirty(true);
  allStateMachines().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for StateMachines
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfStateMachines(IXmlBBase el)
  {
  return allStateMachines().IndexOf (el);
  }

/// <summary>Part of the list interface for StateMachines
/// This deletion function removes an element from the
/// collection in StateMachines</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteStateMachines(int idx)
  {
  __setDirty(true);
  allStateMachines().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteStateMachines(int idx,Lock aLock)
  {
  __setDirty(true);
  allStateMachines().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for StateMachines
/// This deletion function removes an element from the
/// collection in StateMachines
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeStateMachines(IXmlBBase obj)
  {
  int idx = indexOfStateMachines(obj);
  if (idx >= 0) { deleteStateMachines(idx);
NotifyControllers(null);
   }
  }

public void removeStateMachines(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfStateMachines(obj);
  if (idx >= 0) { deleteStateMachines(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for StateMachines</summary>
/// <returns>the number of elements in StateMachines</returns>
public int countStateMachines()
  {
  return allStateMachines().Count;
  }

/// <summary>Part of the list interface for StateMachines
/// This function returns an element from the
/// collection in StateMachines based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public StateMachine getStateMachines(int idx)
{
  return (StateMachine) ( allStateMachines()[idx]);
}

private System.Collections.ArrayList aFunctions;

/// <summary>Part of the list interface for Functions</summary>
/// <returns>a collection of all the elements in Functions</returns>
public System.Collections.ArrayList allFunctions()
  {
if (aFunctions == null){
    setAllFunctions( new System.Collections.ArrayList() );
} // If
    return aFunctions;
  }

/// <summary>Part of the list interface for Functions</summary>
/// <returns>a collection of all the elements in Functions</returns>
private System.Collections.ArrayList getFunctions()
  {
    return allFunctions();
  }

/// <summary>Part of the list interface for Functions</summary>
/// <param name="coll">a collection of elements which replaces 
///        Functions's current content.</param>
public void setAllFunctions(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aFunctions = coll;
    NotifyControllers(null);
  }
public void setAllFunctions(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aFunctions = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Functions</summary>
/// <param name="el">a Function to add to the collection in 
///           Functions</param>
/// <seealso cref="appendFunctions(ICollection)"/>
public void appendFunctions(Function el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allFunctions().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendFunctions(Lock aLock,Function el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allFunctions().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Functions</summary>
/// <param name="coll">a collection ofFunctions to add to the collection in 
///           Functions</param>
/// <seealso cref="appendFunctions(Function)"/>
public void appendFunctions(ICollection coll)
  {
  __setDirty(true);
  allFunctions().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendFunctions(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allFunctions().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Functions
/// This insertion function inserts a new element in the
/// collection in Functions</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertFunctions(int idx, Function el)
  {
  __setDirty(true);
  allFunctions().Insert (idx, el);
NotifyControllers(null);
  }

public void insertFunctions(int idx, Function el,Lock aLock)
  {
  __setDirty(true);
  allFunctions().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Functions
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfFunctions(IXmlBBase el)
  {
  return allFunctions().IndexOf (el);
  }

/// <summary>Part of the list interface for Functions
/// This deletion function removes an element from the
/// collection in Functions</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteFunctions(int idx)
  {
  __setDirty(true);
  allFunctions().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteFunctions(int idx,Lock aLock)
  {
  __setDirty(true);
  allFunctions().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Functions
/// This deletion function removes an element from the
/// collection in Functions
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeFunctions(IXmlBBase obj)
  {
  int idx = indexOfFunctions(obj);
  if (idx >= 0) { deleteFunctions(idx);
NotifyControllers(null);
   }
  }

public void removeFunctions(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfFunctions(obj);
  if (idx >= 0) { deleteFunctions(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Functions</summary>
/// <returns>the number of elements in Functions</returns>
public int countFunctions()
  {
  return allFunctions().Count;
  }

/// <summary>Part of the list interface for Functions
/// This function returns an element from the
/// collection in Functions based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Function getFunctions(int idx)
{
  return (Function) ( allFunctions()[idx]);
}

private System.Collections.ArrayList aProcedures;

/// <summary>Part of the list interface for Procedures</summary>
/// <returns>a collection of all the elements in Procedures</returns>
public System.Collections.ArrayList allProcedures()
  {
if (aProcedures == null){
    setAllProcedures( new System.Collections.ArrayList() );
} // If
    return aProcedures;
  }

/// <summary>Part of the list interface for Procedures</summary>
/// <returns>a collection of all the elements in Procedures</returns>
private System.Collections.ArrayList getProcedures()
  {
    return allProcedures();
  }

/// <summary>Part of the list interface for Procedures</summary>
/// <param name="coll">a collection of elements which replaces 
///        Procedures's current content.</param>
public void setAllProcedures(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aProcedures = coll;
    NotifyControllers(null);
  }
public void setAllProcedures(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aProcedures = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Procedures</summary>
/// <param name="el">a Procedure to add to the collection in 
///           Procedures</param>
/// <seealso cref="appendProcedures(ICollection)"/>
public void appendProcedures(Procedure el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allProcedures().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendProcedures(Lock aLock,Procedure el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allProcedures().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Procedures</summary>
/// <param name="coll">a collection ofProcedures to add to the collection in 
///           Procedures</param>
/// <seealso cref="appendProcedures(Procedure)"/>
public void appendProcedures(ICollection coll)
  {
  __setDirty(true);
  allProcedures().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendProcedures(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allProcedures().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Procedures
/// This insertion function inserts a new element in the
/// collection in Procedures</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertProcedures(int idx, Procedure el)
  {
  __setDirty(true);
  allProcedures().Insert (idx, el);
NotifyControllers(null);
  }

public void insertProcedures(int idx, Procedure el,Lock aLock)
  {
  __setDirty(true);
  allProcedures().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Procedures
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfProcedures(IXmlBBase el)
  {
  return allProcedures().IndexOf (el);
  }

/// <summary>Part of the list interface for Procedures
/// This deletion function removes an element from the
/// collection in Procedures</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteProcedures(int idx)
  {
  __setDirty(true);
  allProcedures().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteProcedures(int idx,Lock aLock)
  {
  __setDirty(true);
  allProcedures().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Procedures
/// This deletion function removes an element from the
/// collection in Procedures
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeProcedures(IXmlBBase obj)
  {
  int idx = indexOfProcedures(obj);
  if (idx >= 0) { deleteProcedures(idx);
NotifyControllers(null);
   }
  }

public void removeProcedures(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfProcedures(obj);
  if (idx >= 0) { deleteProcedures(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Procedures</summary>
/// <returns>the number of elements in Procedures</returns>
public int countProcedures()
  {
  return allProcedures().Count;
  }

/// <summary>Part of the list interface for Procedures
/// This function returns an element from the
/// collection in Procedures based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Procedure getProcedures(int idx)
{
  return (Procedure) ( allProcedures()[idx]);
}

private System.Collections.ArrayList aVariables;

/// <summary>Part of the list interface for Variables</summary>
/// <returns>a collection of all the elements in Variables</returns>
public System.Collections.ArrayList allVariables()
  {
if (aVariables == null){
    setAllVariables( new System.Collections.ArrayList() );
} // If
    return aVariables;
  }

/// <summary>Part of the list interface for Variables</summary>
/// <returns>a collection of all the elements in Variables</returns>
private System.Collections.ArrayList getVariables()
  {
    return allVariables();
  }

/// <summary>Part of the list interface for Variables</summary>
/// <param name="coll">a collection of elements which replaces 
///        Variables's current content.</param>
public void setAllVariables(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aVariables = coll;
    NotifyControllers(null);
  }
public void setAllVariables(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aVariables = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Variables</summary>
/// <param name="el">a Variable to add to the collection in 
///           Variables</param>
/// <seealso cref="appendVariables(ICollection)"/>
public void appendVariables(Variable el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allVariables().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendVariables(Lock aLock,Variable el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allVariables().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Variables</summary>
/// <param name="coll">a collection ofVariables to add to the collection in 
///           Variables</param>
/// <seealso cref="appendVariables(Variable)"/>
public void appendVariables(ICollection coll)
  {
  __setDirty(true);
  allVariables().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendVariables(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allVariables().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Variables
/// This insertion function inserts a new element in the
/// collection in Variables</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertVariables(int idx, Variable el)
  {
  __setDirty(true);
  allVariables().Insert (idx, el);
NotifyControllers(null);
  }

public void insertVariables(int idx, Variable el,Lock aLock)
  {
  __setDirty(true);
  allVariables().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Variables
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfVariables(IXmlBBase el)
  {
  return allVariables().IndexOf (el);
  }

/// <summary>Part of the list interface for Variables
/// This deletion function removes an element from the
/// collection in Variables</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteVariables(int idx)
  {
  __setDirty(true);
  allVariables().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteVariables(int idx,Lock aLock)
  {
  __setDirty(true);
  allVariables().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Variables
/// This deletion function removes an element from the
/// collection in Variables
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeVariables(IXmlBBase obj)
  {
  int idx = indexOfVariables(obj);
  if (idx >= 0) { deleteVariables(idx);
NotifyControllers(null);
   }
  }

public void removeVariables(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfVariables(obj);
  if (idx >= 0) { deleteVariables(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Variables</summary>
/// <returns>the number of elements in Variables</returns>
public int countVariables()
  {
  return allVariables().Count;
  }

/// <summary>Part of the list interface for Variables
/// This function returns an element from the
/// collection in Variables based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Variable getVariables(int idx)
{
  return (Variable) ( allVariables()[idx]);
}

private System.Collections.ArrayList aRules;

/// <summary>Part of the list interface for Rules</summary>
/// <returns>a collection of all the elements in Rules</returns>
public System.Collections.ArrayList allRules()
  {
if (aRules == null){
    setAllRules( new System.Collections.ArrayList() );
} // If
    return aRules;
  }

/// <summary>Part of the list interface for Rules</summary>
/// <returns>a collection of all the elements in Rules</returns>
private System.Collections.ArrayList getRules()
  {
    return allRules();
  }

/// <summary>Part of the list interface for Rules</summary>
/// <param name="coll">a collection of elements which replaces 
///        Rules's current content.</param>
public void setAllRules(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aRules = coll;
    NotifyControllers(null);
  }
public void setAllRules(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aRules = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Rules</summary>
/// <param name="el">a Rule to add to the collection in 
///           Rules</param>
/// <seealso cref="appendRules(ICollection)"/>
public void appendRules(Rule el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allRules().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendRules(Lock aLock,Rule el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allRules().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Rules</summary>
/// <param name="coll">a collection ofRules to add to the collection in 
///           Rules</param>
/// <seealso cref="appendRules(Rule)"/>
public void appendRules(ICollection coll)
  {
  __setDirty(true);
  allRules().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendRules(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allRules().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Rules
/// This insertion function inserts a new element in the
/// collection in Rules</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertRules(int idx, Rule el)
  {
  __setDirty(true);
  allRules().Insert (idx, el);
NotifyControllers(null);
  }

public void insertRules(int idx, Rule el,Lock aLock)
  {
  __setDirty(true);
  allRules().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Rules
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfRules(IXmlBBase el)
  {
  return allRules().IndexOf (el);
  }

/// <summary>Part of the list interface for Rules
/// This deletion function removes an element from the
/// collection in Rules</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteRules(int idx)
  {
  __setDirty(true);
  allRules().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteRules(int idx,Lock aLock)
  {
  __setDirty(true);
  allRules().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Rules
/// This deletion function removes an element from the
/// collection in Rules
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeRules(IXmlBBase obj)
  {
  int idx = indexOfRules(obj);
  if (idx >= 0) { deleteRules(idx);
NotifyControllers(null);
   }
  }

public void removeRules(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfRules(obj);
  if (idx >= 0) { deleteRules(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Rules</summary>
/// <returns>the number of elements in Rules</returns>
public int countRules()
  {
  return allRules().Count;
  }

/// <summary>Part of the list interface for Rules
/// This function returns an element from the
/// collection in Rules based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Rule getRules(int idx)
{
  return (Rule) ( allRules()[idx]);
}

public NameSpace()
{
NameSpace obj = this;
aNameSpaces=(null);
aRanges=(null);
aEnumerations=(null);
aStructures=(null);
aCollections=(null);
aStateMachines=(null);
aFunctions=(null);
aProcedures=(null);
aVariables=(null);
aRules=(null);
}

public void copyTo(NameSpace other)
{
base.copyTo(other);
other.aNameSpaces = aNameSpaces;
other.aRanges = aRanges;
other.aEnumerations = aEnumerations;
other.aStructures = aStructures;
other.aCollections = aCollections;
other.aStateMachines = aStateMachines;
other.aFunctions = aFunctions;
other.aProcedures = aProcedures;
other.aVariables = aVariables;
other.aRules = aRules;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
bool fl195;
NameSpace fl197;
bool fl208;
Range fl210;
bool fl221;
Enum fl223;
bool fl234;
Structure fl236;
bool fl247;
Collection fl249;
bool fl260;
StateMachine fl262;
bool fl273;
Function fl275;
bool fl286;
Procedure fl288;
bool fl299;
Variable fl301;
bool fl312;
Rule fl314;

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<NameSpaces")){
ctxt.skipWhiteSpace();
fl195 = true ; 
while (fl195) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl195 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl197 = null;
while(ctxt.lookAheadOpeningTag ("<NameSpace")) {
fl197 = acceptor.lAccept_NameSpace(ctxt, "</NameSpace>");
appendNameSpaces(fl197);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</NameSpaces>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Ranges")){
ctxt.skipWhiteSpace();
fl208 = true ; 
while (fl208) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl208 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl210 = null;
while(ctxt.lookAheadOpeningTag ("<Range")) {
fl210 = acceptor.lAccept_Range(ctxt, "</Range>");
appendRanges(fl210);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Ranges>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Enumerations")){
ctxt.skipWhiteSpace();
fl221 = true ; 
while (fl221) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl221 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl223 = null;
while(ctxt.lookAheadOpeningTag ("<Enum")) {
fl223 = acceptor.lAccept_Enum(ctxt, "</Enum>");
appendEnumerations(fl223);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Enumerations>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Structures")){
ctxt.skipWhiteSpace();
fl234 = true ; 
while (fl234) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl234 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl236 = null;
while(ctxt.lookAheadOpeningTag ("<Structure")) {
fl236 = acceptor.lAccept_Structure(ctxt, "</Structure>");
appendStructures(fl236);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Structures>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Collections")){
ctxt.skipWhiteSpace();
fl247 = true ; 
while (fl247) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl247 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl249 = null;
while(ctxt.lookAheadOpeningTag ("<Collection")) {
fl249 = acceptor.lAccept_Collection(ctxt, "</Collection>");
appendCollections(fl249);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Collections>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<StateMachines")){
ctxt.skipWhiteSpace();
fl260 = true ; 
while (fl260) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl260 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl262 = null;
while(ctxt.lookAheadOpeningTag ("<StateMachine")) {
fl262 = acceptor.lAccept_StateMachine(ctxt, "</StateMachine>");
appendStateMachines(fl262);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</StateMachines>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Functions")){
ctxt.skipWhiteSpace();
fl273 = true ; 
while (fl273) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl273 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl275 = null;
while(ctxt.lookAheadOpeningTag ("<Function")) {
fl275 = acceptor.lAccept_Function(ctxt, "</Function>");
appendFunctions(fl275);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Functions>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Procedures")){
ctxt.skipWhiteSpace();
fl286 = true ; 
while (fl286) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl286 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl288 = null;
while(ctxt.lookAheadOpeningTag ("<Procedure")) {
fl288 = acceptor.lAccept_Procedure(ctxt, "</Procedure>");
appendProcedures(fl288);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Procedures>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Variables")){
ctxt.skipWhiteSpace();
fl299 = true ; 
while (fl299) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl299 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl301 = null;
while(ctxt.lookAheadOpeningTag ("<Variable")) {
fl301 = acceptor.lAccept_Variable(ctxt, "</Variable>");
appendVariables(fl301);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Variables>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Rules")){
ctxt.skipWhiteSpace();
fl312 = true ; 
while (fl312) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl312 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl314 = null;
while(ctxt.lookAheadOpeningTag ("<Rule")) {
fl314 = acceptor.lAccept_Rule(ctxt, "</Rule>");
appendRules(fl314);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Rules>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl325;
bool fl326;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl325 = false ; 
fl326 = true ; 
while (fl326) { // BeginLoop 
if (ctxt.lookAheadString("Name=")){
indicator = 325;
} else {
indicator = 327;
} // If
switch (indicator) {
case 325: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl325){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl325 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 327: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl326 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<NameSpace";
  endingTag = "</NameSpace>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"NameSpace\"");
} // If
pw.Write('\n');
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing Enclosed
// Testing for empty content: NameSpaces
if (countNameSpaces() > 0){
pw.Write("<NameSpaces>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getNameSpaces(), false, "<NameSpace", "</NameSpace>");
pw.Write("</NameSpaces>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: NameSpaces
// Unparsing Enclosed
// Testing for empty content: Ranges
if (countRanges() > 0){
pw.Write("<Ranges>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getRanges(), false, "<Range", "</Range>");
pw.Write("</Ranges>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Ranges
// Unparsing Enclosed
// Testing for empty content: Enumerations
if (countEnumerations() > 0){
pw.Write("<Enumerations>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getEnumerations(), false, "<Enum", "</Enum>");
pw.Write("</Enumerations>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Enumerations
// Unparsing Enclosed
// Testing for empty content: Structures
if (countStructures() > 0){
pw.Write("<Structures>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getStructures(), false, "<Structure", "</Structure>");
pw.Write("</Structures>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Structures
// Unparsing Enclosed
// Testing for empty content: Collections
if (countCollections() > 0){
pw.Write("<Collections>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getCollections(), false, "<Collection", "</Collection>");
pw.Write("</Collections>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Collections
// Unparsing Enclosed
// Testing for empty content: StateMachines
if (countStateMachines() > 0){
pw.Write("<StateMachines>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getStateMachines(), false, "<StateMachine", "</StateMachine>");
pw.Write("</StateMachines>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: StateMachines
// Unparsing Enclosed
// Testing for empty content: Functions
if (countFunctions() > 0){
pw.Write("<Functions>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getFunctions(), false, "<Function", "</Function>");
pw.Write("</Functions>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Functions
// Unparsing Enclosed
// Testing for empty content: Procedures
if (countProcedures() > 0){
pw.Write("<Procedures>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getProcedures(), false, "<Procedure", "</Procedure>");
pw.Write("</Procedures>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Procedures
// Unparsing Enclosed
// Testing for empty content: Variables
if (countVariables() > 0){
pw.Write("<Variables>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getVariables(), false, "<Variable", "</Variable>");
pw.Write("</Variables>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Variables
// Unparsing Enclosed
// Testing for empty content: Rules
if (countRules() > 0){
pw.Write("<Rules>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getRules(), false, "<Rule", "</Rule>");
pw.Write("</Rules>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Rules
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
for (int i = 0; i < countNameSpaces(); i++) {
  l.Add(getNameSpaces(i));
}
for (int i = 0; i < countRanges(); i++) {
  l.Add(getRanges(i));
}
for (int i = 0; i < countEnumerations(); i++) {
  l.Add(getEnumerations(i));
}
for (int i = 0; i < countStructures(); i++) {
  l.Add(getStructures(i));
}
for (int i = 0; i < countCollections(); i++) {
  l.Add(getCollections(i));
}
for (int i = 0; i < countStateMachines(); i++) {
  l.Add(getStateMachines(i));
}
for (int i = 0; i < countFunctions(); i++) {
  l.Add(getFunctions(i));
}
for (int i = 0; i < countProcedures(); i++) {
  l.Add(getProcedures(i));
}
for (int i = 0; i < countVariables(); i++) {
  l.Add(getVariables(i));
}
for (int i = 0; i < countRules(); i++) {
  l.Add(getRules(i));
}
}

}
public partial class ReqRef
: ModelElement
{
public  override  bool find(Object search){
if (search is String ) {
if(getId().CompareTo((String) search) == 0)return true;
if(getComment().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.ReqRefController.alertChange(aLock, this);
}
private   string  aId;

public   string  getId() { return aId;}
public  void setId( string  v) {
  aId = v;
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aComment;

public   string  getComment() { return aComment;}
public  void setComment( string  v) {
  aComment = v;
  __setDirty(true);
  NotifyControllers(null);
}

public ReqRef()
{
ReqRef obj = this;
aId=(null);
aComment=(null);
}

public void copyTo(ReqRef other)
{
other.aId = aId;
other.aComment = aComment;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
bool fl329;

ctxt.skipWhiteSpace();
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Comment")){
ctxt.skipWhiteSpace();
fl329 = true ; 
while (fl329) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl329 = false ; 
} // If
} // While
ctxt.accept('>');
// Indicator
// Parse PC data
this.setComment(acceptor.lAcceptPcData(ctxt, -1, '<',XmlBContext.WS_PRESERVE));
// Regexp
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Comment>");
} // If
// End enclosed
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl330;
bool fl331;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl330 = false ; 
fl331 = true ; 
while (fl331) { // BeginLoop 
if (ctxt.lookAhead3('I','d','=')){
indicator = 330;
} else {
indicator = 332;
} // If
switch (indicator) {
case 330: {
// Handling attribute Id
// Also handles alien attributes with prefix Id
if (fl330){
ctxt.fail ("Duplicate attribute: Id");
} // If
fl330 = true ; 
quoteChar = ctxt.acceptQuote();
this.setId((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 332: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl330){
ctxt.fail ("Mandatory attribute missing: Id in ReqRef");
} // If
fl331 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString ("</ReqRef>");
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

pw.Write("<ReqRef");
if (typeId){
pw.Write(" xsi:type=\"ReqRef\"");
} // If
pw.Write('\n');
pw.Write(" Id=\"");
acceptor.unParsePcData(pw, this.getId());
pw.Write('"');
pw.Write('\n');
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write("</ReqRef>");
pw.Write('\n');
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

// Unparsing Enclosed
// Testing for empty content: Comment
if (this.getComment() != null){
pw.Write("<Comment>");
// Unparsing PcData
acceptor.unParsePcData(pw, this.getComment());
pw.Write("</Comment>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Comment
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
}

}
public abstract partial class Type
: DataDictionary.ReqRelated
{
public  override  bool find(Object search){
if (search is String ) {
if(getDefault().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.TypeController.alertChange(aLock, this);
}
private   string  aDefault;

public   string  getDefault() { return aDefault;}
public  void setDefault( string  v) {
  aDefault = v;
  __setDirty(true);
  NotifyControllers(null);
}

public Type()
{
Type obj = this;
aDefault=(null);
}

public void copyTo(Type other)
{
base.copyTo(other);
other.aDefault = aDefault;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl334;
bool fl335;
bool fl336;
bool fl337;
bool fl338;
bool fl339;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl334 = false ; 
fl335 = false ; 
fl336 = false ; 
fl337 = false ; 
fl338 = false ; 
fl339 = true ; 
while (fl339) { // BeginLoop 
switch (ctxt.current()) {
case 'V':
{
ctxt.advance();
if (ctxt.lookAheadString("erified=")){
indicator = 336;
} else {
indicator = 340;
} // If
break;
} // Case
case 'N':
{
ctxt.advance();
switch (ctxt.current()) {
case 'e':
{
ctxt.advance();
if (ctxt.lookAheadString("edsRequirement=")){
indicator = 337;
} else {
indicator = 340;
} // If
break;
} // Case
case 'a':
{
ctxt.advance();
if (ctxt.lookAhead3('m','e','=')){
indicator = 338;
} else {
indicator = 340;
} // If
break;
} // Case
default:
indicator = 340;
break;
} // Switch
break;
} // Case
case 'I':
{
ctxt.advance();
if (ctxt.lookAheadString("mplemented=")){
indicator = 335;
} else {
indicator = 340;
} // If
break;
} // Case
case 'D':
{
ctxt.advance();
if (ctxt.lookAheadString("efault=")){
indicator = 334;
} else {
indicator = 340;
} // If
break;
} // Case
default:
indicator = 340;
break;
} // Switch
switch (indicator) {
case 334: {
// Handling attribute Default
// Also handles alien attributes with prefix Default
if (fl334){
ctxt.fail ("Duplicate attribute: Default");
} // If
fl334 = true ; 
quoteChar = ctxt.acceptQuote();
this.setDefault((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 335: {
// Handling attribute Implemented
// Also handles alien attributes with prefix Implemented
if (fl335){
ctxt.fail ("Duplicate attribute: Implemented");
} // If
fl335 = true ; 
quoteChar = ctxt.acceptQuote();
this.setImplemented(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 336: {
// Handling attribute Verified
// Also handles alien attributes with prefix Verified
if (fl336){
ctxt.fail ("Duplicate attribute: Verified");
} // If
fl336 = true ; 
quoteChar = ctxt.acceptQuote();
this.setVerified(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 337: {
// Handling attribute NeedsRequirement
// Also handles alien attributes with prefix NeedsRequirement
if (fl337){
ctxt.fail ("Duplicate attribute: NeedsRequirement");
} // If
fl337 = true ; 
quoteChar = ctxt.acceptQuote();
this.setNeedsRequirement(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 338: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl338){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl338 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 340: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl335){
this.setImplemented( false);
} // If
if (!fl336){
this.setVerified( false);
} // If
if (!fl337){
this.setNeedsRequirement( true);
} // If
fl339 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<Type";
  endingTag = "</Type>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"Type\"");
} // If
pw.Write('\n');
if (this.getDefault() != null){
pw.Write(" Default=\"");
acceptor.unParsePcData(pw, this.getDefault());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getImplemented()){
pw.Write(" Implemented=\"");
acceptor.unParsePcData(pw, this.getImplemented());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getVerified()){
pw.Write(" Verified=\"");
acceptor.unParsePcData(pw, this.getVerified());
pw.Write('"');
pw.Write('\n');
} // If
if (!this.getNeedsRequirement()){
pw.Write(" NeedsRequirement=\"");
acceptor.unParsePcData(pw, this.getNeedsRequirement());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
}

}
public partial class Enum
: DataDictionary.Types.Type
{
public  override  bool find(Object search){
if (search is String ) {
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.EnumController.alertChange(aLock, this);
}
private System.Collections.ArrayList aValues;

/// <summary>Part of the list interface for Values</summary>
/// <returns>a collection of all the elements in Values</returns>
public System.Collections.ArrayList allValues()
  {
if (aValues == null){
    setAllValues( new System.Collections.ArrayList() );
} // If
    return aValues;
  }

/// <summary>Part of the list interface for Values</summary>
/// <returns>a collection of all the elements in Values</returns>
private System.Collections.ArrayList getValues()
  {
    return allValues();
  }

/// <summary>Part of the list interface for Values</summary>
/// <param name="coll">a collection of elements which replaces 
///        Values's current content.</param>
public void setAllValues(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aValues = coll;
    NotifyControllers(null);
  }
public void setAllValues(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aValues = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Values</summary>
/// <param name="el">a EnumValue to add to the collection in 
///           Values</param>
/// <seealso cref="appendValues(ICollection)"/>
public void appendValues(EnumValue el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allValues().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendValues(Lock aLock,EnumValue el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allValues().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Values</summary>
/// <param name="coll">a collection ofEnumValues to add to the collection in 
///           Values</param>
/// <seealso cref="appendValues(EnumValue)"/>
public void appendValues(ICollection coll)
  {
  __setDirty(true);
  allValues().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendValues(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allValues().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Values
/// This insertion function inserts a new element in the
/// collection in Values</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertValues(int idx, EnumValue el)
  {
  __setDirty(true);
  allValues().Insert (idx, el);
NotifyControllers(null);
  }

public void insertValues(int idx, EnumValue el,Lock aLock)
  {
  __setDirty(true);
  allValues().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Values
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfValues(IXmlBBase el)
  {
  return allValues().IndexOf (el);
  }

/// <summary>Part of the list interface for Values
/// This deletion function removes an element from the
/// collection in Values</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteValues(int idx)
  {
  __setDirty(true);
  allValues().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteValues(int idx,Lock aLock)
  {
  __setDirty(true);
  allValues().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Values
/// This deletion function removes an element from the
/// collection in Values
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeValues(IXmlBBase obj)
  {
  int idx = indexOfValues(obj);
  if (idx >= 0) { deleteValues(idx);
NotifyControllers(null);
   }
  }

public void removeValues(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfValues(obj);
  if (idx >= 0) { deleteValues(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Values</summary>
/// <returns>the number of elements in Values</returns>
public int countValues()
  {
  return allValues().Count;
  }

/// <summary>Part of the list interface for Values
/// This function returns an element from the
/// collection in Values based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public EnumValue getValues(int idx)
{
  return (EnumValue) ( allValues()[idx]);
}

private System.Collections.ArrayList aSubEnums;

/// <summary>Part of the list interface for SubEnums</summary>
/// <returns>a collection of all the elements in SubEnums</returns>
public System.Collections.ArrayList allSubEnums()
  {
if (aSubEnums == null){
    setAllSubEnums( new System.Collections.ArrayList() );
} // If
    return aSubEnums;
  }

/// <summary>Part of the list interface for SubEnums</summary>
/// <returns>a collection of all the elements in SubEnums</returns>
private System.Collections.ArrayList getSubEnums()
  {
    return allSubEnums();
  }

/// <summary>Part of the list interface for SubEnums</summary>
/// <param name="coll">a collection of elements which replaces 
///        SubEnums's current content.</param>
public void setAllSubEnums(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aSubEnums = coll;
    NotifyControllers(null);
  }
public void setAllSubEnums(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aSubEnums = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SubEnums</summary>
/// <param name="el">a Enum to add to the collection in 
///           SubEnums</param>
/// <seealso cref="appendSubEnums(ICollection)"/>
public void appendSubEnums(Enum el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allSubEnums().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendSubEnums(Lock aLock,Enum el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allSubEnums().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for SubEnums</summary>
/// <param name="coll">a collection ofEnums to add to the collection in 
///           SubEnums</param>
/// <seealso cref="appendSubEnums(Enum)"/>
public void appendSubEnums(ICollection coll)
  {
  __setDirty(true);
  allSubEnums().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendSubEnums(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allSubEnums().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SubEnums
/// This insertion function inserts a new element in the
/// collection in SubEnums</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertSubEnums(int idx, Enum el)
  {
  __setDirty(true);
  allSubEnums().Insert (idx, el);
NotifyControllers(null);
  }

public void insertSubEnums(int idx, Enum el,Lock aLock)
  {
  __setDirty(true);
  allSubEnums().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SubEnums
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfSubEnums(IXmlBBase el)
  {
  return allSubEnums().IndexOf (el);
  }

/// <summary>Part of the list interface for SubEnums
/// This deletion function removes an element from the
/// collection in SubEnums</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteSubEnums(int idx)
  {
  __setDirty(true);
  allSubEnums().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteSubEnums(int idx,Lock aLock)
  {
  __setDirty(true);
  allSubEnums().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SubEnums
/// This deletion function removes an element from the
/// collection in SubEnums
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeSubEnums(IXmlBBase obj)
  {
  int idx = indexOfSubEnums(obj);
  if (idx >= 0) { deleteSubEnums(idx);
NotifyControllers(null);
   }
  }

public void removeSubEnums(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfSubEnums(obj);
  if (idx >= 0) { deleteSubEnums(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for SubEnums</summary>
/// <returns>the number of elements in SubEnums</returns>
public int countSubEnums()
  {
  return allSubEnums().Count;
  }

/// <summary>Part of the list interface for SubEnums
/// This function returns an element from the
/// collection in SubEnums based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Enum getSubEnums(int idx)
{
  return (Enum) ( allSubEnums()[idx]);
}

public Enum()
{
Enum obj = this;
aValues=(null);
aSubEnums=(null);
}

public void copyTo(Enum other)
{
base.copyTo(other);
other.aValues = aValues;
other.aSubEnums = aSubEnums;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
bool fl348;
EnumValue fl350;
bool fl361;
Enum fl363;

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Values")){
ctxt.skipWhiteSpace();
fl348 = true ; 
while (fl348) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl348 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl350 = null;
while(ctxt.lookAheadOpeningTag ("<EnumValue")) {
fl350 = acceptor.lAccept_EnumValue(ctxt, "</EnumValue>");
appendValues(fl350);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Values>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<SubEnums")){
ctxt.skipWhiteSpace();
fl361 = true ; 
while (fl361) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl361 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl363 = null;
while(ctxt.lookAheadOpeningTag ("<Enum")) {
fl363 = acceptor.lAccept_Enum(ctxt, "</Enum>");
appendSubEnums(fl363);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</SubEnums>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl374;
bool fl375;
bool fl376;
bool fl377;
bool fl378;
bool fl379;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl374 = false ; 
fl375 = false ; 
fl376 = false ; 
fl377 = false ; 
fl378 = false ; 
fl379 = true ; 
while (fl379) { // BeginLoop 
switch (ctxt.current()) {
case 'V':
{
ctxt.advance();
if (ctxt.lookAheadString("erified=")){
indicator = 376;
} else {
indicator = 380;
} // If
break;
} // Case
case 'N':
{
ctxt.advance();
switch (ctxt.current()) {
case 'e':
{
ctxt.advance();
if (ctxt.lookAheadString("edsRequirement=")){
indicator = 377;
} else {
indicator = 380;
} // If
break;
} // Case
case 'a':
{
ctxt.advance();
if (ctxt.lookAhead3('m','e','=')){
indicator = 378;
} else {
indicator = 380;
} // If
break;
} // Case
default:
indicator = 380;
break;
} // Switch
break;
} // Case
case 'I':
{
ctxt.advance();
if (ctxt.lookAheadString("mplemented=")){
indicator = 375;
} else {
indicator = 380;
} // If
break;
} // Case
case 'D':
{
ctxt.advance();
if (ctxt.lookAheadString("efault=")){
indicator = 374;
} else {
indicator = 380;
} // If
break;
} // Case
default:
indicator = 380;
break;
} // Switch
switch (indicator) {
case 374: {
// Handling attribute Default
// Also handles alien attributes with prefix Default
if (fl374){
ctxt.fail ("Duplicate attribute: Default");
} // If
fl374 = true ; 
quoteChar = ctxt.acceptQuote();
this.setDefault((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 375: {
// Handling attribute Implemented
// Also handles alien attributes with prefix Implemented
if (fl375){
ctxt.fail ("Duplicate attribute: Implemented");
} // If
fl375 = true ; 
quoteChar = ctxt.acceptQuote();
this.setImplemented(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 376: {
// Handling attribute Verified
// Also handles alien attributes with prefix Verified
if (fl376){
ctxt.fail ("Duplicate attribute: Verified");
} // If
fl376 = true ; 
quoteChar = ctxt.acceptQuote();
this.setVerified(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 377: {
// Handling attribute NeedsRequirement
// Also handles alien attributes with prefix NeedsRequirement
if (fl377){
ctxt.fail ("Duplicate attribute: NeedsRequirement");
} // If
fl377 = true ; 
quoteChar = ctxt.acceptQuote();
this.setNeedsRequirement(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 378: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl378){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl378 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 380: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl375){
this.setImplemented( false);
} // If
if (!fl376){
this.setVerified( false);
} // If
if (!fl377){
this.setNeedsRequirement( true);
} // If
fl379 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<Enum";
  endingTag = "</Enum>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"Enum\"");
} // If
pw.Write('\n');
if (this.getDefault() != null){
pw.Write(" Default=\"");
acceptor.unParsePcData(pw, this.getDefault());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getImplemented()){
pw.Write(" Implemented=\"");
acceptor.unParsePcData(pw, this.getImplemented());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getVerified()){
pw.Write(" Verified=\"");
acceptor.unParsePcData(pw, this.getVerified());
pw.Write('"');
pw.Write('\n');
} // If
if (!this.getNeedsRequirement()){
pw.Write(" NeedsRequirement=\"");
acceptor.unParsePcData(pw, this.getNeedsRequirement());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing Enclosed
// Testing for empty content: Values
if (countValues() > 0){
pw.Write("<Values>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getValues(), false, "<EnumValue", "</EnumValue>");
pw.Write("</Values>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Values
// Unparsing Enclosed
// Testing for empty content: SubEnums
if (countSubEnums() > 0){
pw.Write("<SubEnums>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getSubEnums(), false, "<Enum", "</Enum>");
pw.Write("</SubEnums>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: SubEnums
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
for (int i = 0; i < countValues(); i++) {
  l.Add(getValues(i));
}
for (int i = 0; i < countSubEnums(); i++) {
  l.Add(getSubEnums(i));
}
}

}
public partial class EnumValue
: DataDictionary.Namable
{
public  override  bool find(Object search){
if (search is String ) {
if(getValue().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.EnumValueController.alertChange(aLock, this);
}
private   string  aValue;

public   string  getValue() { return aValue;}
public  void setValue( string  v) {
  aValue = v;
  __setDirty(true);
  NotifyControllers(null);
}

public EnumValue()
{
EnumValue obj = this;
aValue=(null);
}

public void copyTo(EnumValue other)
{
base.copyTo(other);
other.aValue = aValue;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl388;
bool fl389;
bool fl390;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl388 = false ; 
fl389 = false ; 
fl390 = true ; 
while (fl390) { // BeginLoop 
switch (ctxt.current()) {
case 'V':
{
ctxt.advance();
if (ctxt.lookAheadString("alue=")){
indicator = 388;
} else {
indicator = 391;
} // If
break;
} // Case
case 'N':
{
ctxt.advance();
if (ctxt.lookAheadString("ame=")){
indicator = 389;
} else {
indicator = 391;
} // If
break;
} // Case
default:
indicator = 391;
break;
} // Switch
switch (indicator) {
case 388: {
// Handling attribute Value
// Also handles alien attributes with prefix Value
if (fl388){
ctxt.fail ("Duplicate attribute: Value");
} // If
fl388 = true ; 
quoteChar = ctxt.acceptQuote();
this.setValue((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 389: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl389){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl389 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 391: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl388){
this.setValue("0");
} // If
fl390 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<EnumValue";
  endingTag = "</EnumValue>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"EnumValue\"");
} // If
pw.Write('\n');
if (this.getValue() != null){
pw.Write(" Value=\"");
acceptor.unParsePcData(pw, this.getValue());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
}

}
public partial class Range
: DataDictionary.Types.Type
{
public  override  bool find(Object search){
if (search is String ) {
if(getMinValue().CompareTo((String) search) == 0)return true;
if(getMaxValue().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.RangeController.alertChange(aLock, this);
}
private   string  aMinValue;

public   string  getMinValue() { return aMinValue;}
public  void setMinValue( string  v) {
  aMinValue = v;
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aMaxValue;

public   string  getMaxValue() { return aMaxValue;}
public  void setMaxValue( string  v) {
  aMaxValue = v;
  __setDirty(true);
  NotifyControllers(null);
}

private System.Collections.ArrayList aSpecialValues;

/// <summary>Part of the list interface for SpecialValues</summary>
/// <returns>a collection of all the elements in SpecialValues</returns>
public System.Collections.ArrayList allSpecialValues()
  {
if (aSpecialValues == null){
    setAllSpecialValues( new System.Collections.ArrayList() );
} // If
    return aSpecialValues;
  }

/// <summary>Part of the list interface for SpecialValues</summary>
/// <returns>a collection of all the elements in SpecialValues</returns>
private System.Collections.ArrayList getSpecialValues()
  {
    return allSpecialValues();
  }

/// <summary>Part of the list interface for SpecialValues</summary>
/// <param name="coll">a collection of elements which replaces 
///        SpecialValues's current content.</param>
public void setAllSpecialValues(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aSpecialValues = coll;
    NotifyControllers(null);
  }
public void setAllSpecialValues(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aSpecialValues = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SpecialValues</summary>
/// <param name="el">a EnumValue to add to the collection in 
///           SpecialValues</param>
/// <seealso cref="appendSpecialValues(ICollection)"/>
public void appendSpecialValues(EnumValue el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allSpecialValues().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendSpecialValues(Lock aLock,EnumValue el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allSpecialValues().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for SpecialValues</summary>
/// <param name="coll">a collection ofEnumValues to add to the collection in 
///           SpecialValues</param>
/// <seealso cref="appendSpecialValues(EnumValue)"/>
public void appendSpecialValues(ICollection coll)
  {
  __setDirty(true);
  allSpecialValues().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendSpecialValues(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allSpecialValues().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SpecialValues
/// This insertion function inserts a new element in the
/// collection in SpecialValues</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertSpecialValues(int idx, EnumValue el)
  {
  __setDirty(true);
  allSpecialValues().Insert (idx, el);
NotifyControllers(null);
  }

public void insertSpecialValues(int idx, EnumValue el,Lock aLock)
  {
  __setDirty(true);
  allSpecialValues().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SpecialValues
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfSpecialValues(IXmlBBase el)
  {
  return allSpecialValues().IndexOf (el);
  }

/// <summary>Part of the list interface for SpecialValues
/// This deletion function removes an element from the
/// collection in SpecialValues</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteSpecialValues(int idx)
  {
  __setDirty(true);
  allSpecialValues().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteSpecialValues(int idx,Lock aLock)
  {
  __setDirty(true);
  allSpecialValues().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SpecialValues
/// This deletion function removes an element from the
/// collection in SpecialValues
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeSpecialValues(IXmlBBase obj)
  {
  int idx = indexOfSpecialValues(obj);
  if (idx >= 0) { deleteSpecialValues(idx);
NotifyControllers(null);
   }
  }

public void removeSpecialValues(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfSpecialValues(obj);
  if (idx >= 0) { deleteSpecialValues(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for SpecialValues</summary>
/// <returns>the number of elements in SpecialValues</returns>
public int countSpecialValues()
  {
  return allSpecialValues().Count;
  }

/// <summary>Part of the list interface for SpecialValues
/// This function returns an element from the
/// collection in SpecialValues based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public EnumValue getSpecialValues(int idx)
{
  return (EnumValue) ( allSpecialValues()[idx]);
}

private  acceptor.PrecisionEnum aPrecision;

public  acceptor.PrecisionEnum getPrecision() { return aPrecision;}
public  void setPrecision(acceptor.PrecisionEnum v) {
  aPrecision = v;
  __setDirty(true);
  NotifyControllers(null);
}

public  string   getPrecision_AsString()
{
  return acceptor.Enum_PrecisionEnum_ToString (aPrecision);
}

public  bool setPrecision_AsString( string  v)
{
 acceptor.PrecisionEnum  temp = acceptor.StringTo_Enum_PrecisionEnum(v);
if (temp >= 0){
  aPrecision = temp;
  __setDirty(true);
  NotifyControllers(null);
  return true;
} // If
return false;
}

public Range()
{
Range obj = this;
aMinValue=(null);
aMaxValue=(null);
aSpecialValues=(null);
aPrecision=(0);
}

public void copyTo(Range other)
{
base.copyTo(other);
other.aMinValue = aMinValue;
other.aMaxValue = aMaxValue;
other.aSpecialValues = aSpecialValues;
other.aPrecision = aPrecision;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
bool fl395;
EnumValue fl397;

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<SpecialValues")){
ctxt.skipWhiteSpace();
fl395 = true ; 
while (fl395) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl395 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl397 = null;
while(ctxt.lookAheadOpeningTag ("<EnumValue")) {
fl397 = acceptor.lAccept_EnumValue(ctxt, "</EnumValue>");
appendSpecialValues(fl397);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</SpecialValues>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl408;
bool fl409;
bool fl410;
bool fl411;
bool fl412;
bool fl413;
bool fl414;
bool fl415;
bool fl416;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl408 = false ; 
fl409 = false ; 
fl410 = false ; 
fl411 = false ; 
fl412 = false ; 
fl413 = false ; 
fl414 = false ; 
fl415 = false ; 
fl416 = true ; 
while (fl416) { // BeginLoop 
switch (ctxt.current()) {
case 'V':
{
ctxt.advance();
if (ctxt.lookAheadString("erified=")){
indicator = 413;
} else {
indicator = 417;
} // If
break;
} // Case
case 'P':
{
ctxt.advance();
if (ctxt.lookAheadString("recision=")){
indicator = 410;
} else {
indicator = 417;
} // If
break;
} // Case
case 'N':
{
ctxt.advance();
switch (ctxt.current()) {
case 'e':
{
ctxt.advance();
if (ctxt.lookAheadString("edsRequirement=")){
indicator = 414;
} else {
indicator = 417;
} // If
break;
} // Case
case 'a':
{
ctxt.advance();
if (ctxt.lookAhead3('m','e','=')){
indicator = 415;
} else {
indicator = 417;
} // If
break;
} // Case
default:
indicator = 417;
break;
} // Switch
break;
} // Case
case 'M':
{
ctxt.advance();
switch (ctxt.current()) {
case 'i':
{
ctxt.advance();
if (ctxt.lookAheadString("nValue=")){
indicator = 408;
} else {
indicator = 417;
} // If
break;
} // Case
case 'a':
{
ctxt.advance();
if (ctxt.lookAheadString("xValue=")){
indicator = 409;
} else {
indicator = 417;
} // If
break;
} // Case
default:
indicator = 417;
break;
} // Switch
break;
} // Case
case 'I':
{
ctxt.advance();
if (ctxt.lookAheadString("mplemented=")){
indicator = 412;
} else {
indicator = 417;
} // If
break;
} // Case
case 'D':
{
ctxt.advance();
if (ctxt.lookAheadString("efault=")){
indicator = 411;
} else {
indicator = 417;
} // If
break;
} // Case
default:
indicator = 417;
break;
} // Switch
switch (indicator) {
case 408: {
// Handling attribute MinValue
// Also handles alien attributes with prefix MinValue
if (fl408){
ctxt.fail ("Duplicate attribute: MinValue");
} // If
fl408 = true ; 
quoteChar = ctxt.acceptQuote();
this.setMinValue((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 409: {
// Handling attribute MaxValue
// Also handles alien attributes with prefix MaxValue
if (fl409){
ctxt.fail ("Duplicate attribute: MaxValue");
} // If
fl409 = true ; 
quoteChar = ctxt.acceptQuote();
this.setMaxValue((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 410: {
// Handling attribute Precision
// Also handles alien attributes with prefix Precision
if (fl410){
ctxt.fail ("Duplicate attribute: Precision");
} // If
fl410 = true ; 
quoteChar = ctxt.acceptQuote();
this.setPrecision(acceptor.lAcceptEnum_PrecisionEnum(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 411: {
// Handling attribute Default
// Also handles alien attributes with prefix Default
if (fl411){
ctxt.fail ("Duplicate attribute: Default");
} // If
fl411 = true ; 
quoteChar = ctxt.acceptQuote();
this.setDefault((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 412: {
// Handling attribute Implemented
// Also handles alien attributes with prefix Implemented
if (fl412){
ctxt.fail ("Duplicate attribute: Implemented");
} // If
fl412 = true ; 
quoteChar = ctxt.acceptQuote();
this.setImplemented(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 413: {
// Handling attribute Verified
// Also handles alien attributes with prefix Verified
if (fl413){
ctxt.fail ("Duplicate attribute: Verified");
} // If
fl413 = true ; 
quoteChar = ctxt.acceptQuote();
this.setVerified(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 414: {
// Handling attribute NeedsRequirement
// Also handles alien attributes with prefix NeedsRequirement
if (fl414){
ctxt.fail ("Duplicate attribute: NeedsRequirement");
} // If
fl414 = true ; 
quoteChar = ctxt.acceptQuote();
this.setNeedsRequirement(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 415: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl415){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl415 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 417: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl408){
ctxt.fail ("Mandatory attribute missing: MinValue in Range");
} // If
if (!fl409){
ctxt.fail ("Mandatory attribute missing: MaxValue in Range");
} // If
if (!fl410){
this.setPrecision(acceptor.PrecisionEnum.aIntegerPrecision);
} // If
if (!fl412){
this.setImplemented( false);
} // If
if (!fl413){
this.setVerified( false);
} // If
if (!fl414){
this.setNeedsRequirement( true);
} // If
fl416 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<Range";
  endingTag = "</Range>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"Range\"");
} // If
pw.Write('\n');
pw.Write(" MinValue=\"");
acceptor.unParsePcData(pw, this.getMinValue());
pw.Write('"');
pw.Write('\n');
pw.Write(" MaxValue=\"");
acceptor.unParsePcData(pw, this.getMaxValue());
pw.Write('"');
pw.Write('\n');
if (this.getPrecision() != 0){
pw.Write(" Precision=\"");
acceptor.unParsePcData(pw,
  acceptor.Enum_PrecisionEnum_ToString(this.getPrecision()));
pw.Write('"');
pw.Write('\n');
} // If
if (this.getDefault() != null){
pw.Write(" Default=\"");
acceptor.unParsePcData(pw, this.getDefault());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getImplemented()){
pw.Write(" Implemented=\"");
acceptor.unParsePcData(pw, this.getImplemented());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getVerified()){
pw.Write(" Verified=\"");
acceptor.unParsePcData(pw, this.getVerified());
pw.Write('"');
pw.Write('\n');
} // If
if (!this.getNeedsRequirement()){
pw.Write(" NeedsRequirement=\"");
acceptor.unParsePcData(pw, this.getNeedsRequirement());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing Enclosed
// Testing for empty content: SpecialValues
if (countSpecialValues() > 0){
pw.Write("<SpecialValues>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getSpecialValues(), false, "<EnumValue", "</EnumValue>");
pw.Write("</SpecialValues>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: SpecialValues
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
for (int i = 0; i < countSpecialValues(); i++) {
  l.Add(getSpecialValues(i));
}
}

}
public partial class Structure
: DataDictionary.Types.Type
{
public  override  bool find(Object search){
if (search is String ) {
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.StructureController.alertChange(aLock, this);
}
private System.Collections.ArrayList aElements;

/// <summary>Part of the list interface for Elements</summary>
/// <returns>a collection of all the elements in Elements</returns>
public System.Collections.ArrayList allElements()
  {
if (aElements == null){
    setAllElements( new System.Collections.ArrayList() );
} // If
    return aElements;
  }

/// <summary>Part of the list interface for Elements</summary>
/// <returns>a collection of all the elements in Elements</returns>
private System.Collections.ArrayList getElements()
  {
    return allElements();
  }

/// <summary>Part of the list interface for Elements</summary>
/// <param name="coll">a collection of elements which replaces 
///        Elements's current content.</param>
public void setAllElements(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aElements = coll;
    NotifyControllers(null);
  }
public void setAllElements(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aElements = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Elements</summary>
/// <param name="el">a StructureElement to add to the collection in 
///           Elements</param>
/// <seealso cref="appendElements(ICollection)"/>
public void appendElements(StructureElement el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allElements().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendElements(Lock aLock,StructureElement el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allElements().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Elements</summary>
/// <param name="coll">a collection ofStructureElements to add to the collection in 
///           Elements</param>
/// <seealso cref="appendElements(StructureElement)"/>
public void appendElements(ICollection coll)
  {
  __setDirty(true);
  allElements().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendElements(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allElements().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Elements
/// This insertion function inserts a new element in the
/// collection in Elements</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertElements(int idx, StructureElement el)
  {
  __setDirty(true);
  allElements().Insert (idx, el);
NotifyControllers(null);
  }

public void insertElements(int idx, StructureElement el,Lock aLock)
  {
  __setDirty(true);
  allElements().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Elements
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfElements(IXmlBBase el)
  {
  return allElements().IndexOf (el);
  }

/// <summary>Part of the list interface for Elements
/// This deletion function removes an element from the
/// collection in Elements</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteElements(int idx)
  {
  __setDirty(true);
  allElements().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteElements(int idx,Lock aLock)
  {
  __setDirty(true);
  allElements().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Elements
/// This deletion function removes an element from the
/// collection in Elements
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeElements(IXmlBBase obj)
  {
  int idx = indexOfElements(obj);
  if (idx >= 0) { deleteElements(idx);
NotifyControllers(null);
   }
  }

public void removeElements(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfElements(obj);
  if (idx >= 0) { deleteElements(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Elements</summary>
/// <returns>the number of elements in Elements</returns>
public int countElements()
  {
  return allElements().Count;
  }

/// <summary>Part of the list interface for Elements
/// This function returns an element from the
/// collection in Elements based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public StructureElement getElements(int idx)
{
  return (StructureElement) ( allElements()[idx]);
}

private System.Collections.ArrayList aProcedures;

/// <summary>Part of the list interface for Procedures</summary>
/// <returns>a collection of all the elements in Procedures</returns>
public System.Collections.ArrayList allProcedures()
  {
if (aProcedures == null){
    setAllProcedures( new System.Collections.ArrayList() );
} // If
    return aProcedures;
  }

/// <summary>Part of the list interface for Procedures</summary>
/// <returns>a collection of all the elements in Procedures</returns>
private System.Collections.ArrayList getProcedures()
  {
    return allProcedures();
  }

/// <summary>Part of the list interface for Procedures</summary>
/// <param name="coll">a collection of elements which replaces 
///        Procedures's current content.</param>
public void setAllProcedures(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aProcedures = coll;
    NotifyControllers(null);
  }
public void setAllProcedures(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aProcedures = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Procedures</summary>
/// <param name="el">a StructureProcedure to add to the collection in 
///           Procedures</param>
/// <seealso cref="appendProcedures(ICollection)"/>
public void appendProcedures(StructureProcedure el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allProcedures().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendProcedures(Lock aLock,StructureProcedure el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allProcedures().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Procedures</summary>
/// <param name="coll">a collection ofStructureProcedures to add to the collection in 
///           Procedures</param>
/// <seealso cref="appendProcedures(StructureProcedure)"/>
public void appendProcedures(ICollection coll)
  {
  __setDirty(true);
  allProcedures().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendProcedures(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allProcedures().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Procedures
/// This insertion function inserts a new element in the
/// collection in Procedures</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertProcedures(int idx, StructureProcedure el)
  {
  __setDirty(true);
  allProcedures().Insert (idx, el);
NotifyControllers(null);
  }

public void insertProcedures(int idx, StructureProcedure el,Lock aLock)
  {
  __setDirty(true);
  allProcedures().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Procedures
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfProcedures(IXmlBBase el)
  {
  return allProcedures().IndexOf (el);
  }

/// <summary>Part of the list interface for Procedures
/// This deletion function removes an element from the
/// collection in Procedures</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteProcedures(int idx)
  {
  __setDirty(true);
  allProcedures().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteProcedures(int idx,Lock aLock)
  {
  __setDirty(true);
  allProcedures().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Procedures
/// This deletion function removes an element from the
/// collection in Procedures
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeProcedures(IXmlBBase obj)
  {
  int idx = indexOfProcedures(obj);
  if (idx >= 0) { deleteProcedures(idx);
NotifyControllers(null);
   }
  }

public void removeProcedures(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfProcedures(obj);
  if (idx >= 0) { deleteProcedures(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Procedures</summary>
/// <returns>the number of elements in Procedures</returns>
public int countProcedures()
  {
  return allProcedures().Count;
  }

/// <summary>Part of the list interface for Procedures
/// This function returns an element from the
/// collection in Procedures based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public StructureProcedure getProcedures(int idx)
{
  return (StructureProcedure) ( allProcedures()[idx]);
}

private System.Collections.ArrayList aStateMachines;

/// <summary>Part of the list interface for StateMachines</summary>
/// <returns>a collection of all the elements in StateMachines</returns>
public System.Collections.ArrayList allStateMachines()
  {
if (aStateMachines == null){
    setAllStateMachines( new System.Collections.ArrayList() );
} // If
    return aStateMachines;
  }

/// <summary>Part of the list interface for StateMachines</summary>
/// <returns>a collection of all the elements in StateMachines</returns>
private System.Collections.ArrayList getStateMachines()
  {
    return allStateMachines();
  }

/// <summary>Part of the list interface for StateMachines</summary>
/// <param name="coll">a collection of elements which replaces 
///        StateMachines's current content.</param>
public void setAllStateMachines(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aStateMachines = coll;
    NotifyControllers(null);
  }
public void setAllStateMachines(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aStateMachines = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for StateMachines</summary>
/// <param name="el">a StateMachine to add to the collection in 
///           StateMachines</param>
/// <seealso cref="appendStateMachines(ICollection)"/>
public void appendStateMachines(StateMachine el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allStateMachines().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendStateMachines(Lock aLock,StateMachine el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allStateMachines().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for StateMachines</summary>
/// <param name="coll">a collection ofStateMachines to add to the collection in 
///           StateMachines</param>
/// <seealso cref="appendStateMachines(StateMachine)"/>
public void appendStateMachines(ICollection coll)
  {
  __setDirty(true);
  allStateMachines().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendStateMachines(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allStateMachines().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for StateMachines
/// This insertion function inserts a new element in the
/// collection in StateMachines</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertStateMachines(int idx, StateMachine el)
  {
  __setDirty(true);
  allStateMachines().Insert (idx, el);
NotifyControllers(null);
  }

public void insertStateMachines(int idx, StateMachine el,Lock aLock)
  {
  __setDirty(true);
  allStateMachines().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for StateMachines
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfStateMachines(IXmlBBase el)
  {
  return allStateMachines().IndexOf (el);
  }

/// <summary>Part of the list interface for StateMachines
/// This deletion function removes an element from the
/// collection in StateMachines</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteStateMachines(int idx)
  {
  __setDirty(true);
  allStateMachines().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteStateMachines(int idx,Lock aLock)
  {
  __setDirty(true);
  allStateMachines().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for StateMachines
/// This deletion function removes an element from the
/// collection in StateMachines
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeStateMachines(IXmlBBase obj)
  {
  int idx = indexOfStateMachines(obj);
  if (idx >= 0) { deleteStateMachines(idx);
NotifyControllers(null);
   }
  }

public void removeStateMachines(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfStateMachines(obj);
  if (idx >= 0) { deleteStateMachines(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for StateMachines</summary>
/// <returns>the number of elements in StateMachines</returns>
public int countStateMachines()
  {
  return allStateMachines().Count;
  }

/// <summary>Part of the list interface for StateMachines
/// This function returns an element from the
/// collection in StateMachines based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public StateMachine getStateMachines(int idx)
{
  return (StateMachine) ( allStateMachines()[idx]);
}

private System.Collections.ArrayList aRules;

/// <summary>Part of the list interface for Rules</summary>
/// <returns>a collection of all the elements in Rules</returns>
public System.Collections.ArrayList allRules()
  {
if (aRules == null){
    setAllRules( new System.Collections.ArrayList() );
} // If
    return aRules;
  }

/// <summary>Part of the list interface for Rules</summary>
/// <returns>a collection of all the elements in Rules</returns>
private System.Collections.ArrayList getRules()
  {
    return allRules();
  }

/// <summary>Part of the list interface for Rules</summary>
/// <param name="coll">a collection of elements which replaces 
///        Rules's current content.</param>
public void setAllRules(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aRules = coll;
    NotifyControllers(null);
  }
public void setAllRules(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aRules = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Rules</summary>
/// <param name="el">a Rule to add to the collection in 
///           Rules</param>
/// <seealso cref="appendRules(ICollection)"/>
public void appendRules(Rule el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allRules().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendRules(Lock aLock,Rule el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allRules().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Rules</summary>
/// <param name="coll">a collection ofRules to add to the collection in 
///           Rules</param>
/// <seealso cref="appendRules(Rule)"/>
public void appendRules(ICollection coll)
  {
  __setDirty(true);
  allRules().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendRules(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allRules().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Rules
/// This insertion function inserts a new element in the
/// collection in Rules</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertRules(int idx, Rule el)
  {
  __setDirty(true);
  allRules().Insert (idx, el);
NotifyControllers(null);
  }

public void insertRules(int idx, Rule el,Lock aLock)
  {
  __setDirty(true);
  allRules().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Rules
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfRules(IXmlBBase el)
  {
  return allRules().IndexOf (el);
  }

/// <summary>Part of the list interface for Rules
/// This deletion function removes an element from the
/// collection in Rules</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteRules(int idx)
  {
  __setDirty(true);
  allRules().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteRules(int idx,Lock aLock)
  {
  __setDirty(true);
  allRules().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Rules
/// This deletion function removes an element from the
/// collection in Rules
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeRules(IXmlBBase obj)
  {
  int idx = indexOfRules(obj);
  if (idx >= 0) { deleteRules(idx);
NotifyControllers(null);
   }
  }

public void removeRules(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfRules(obj);
  if (idx >= 0) { deleteRules(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Rules</summary>
/// <returns>the number of elements in Rules</returns>
public int countRules()
  {
  return allRules().Count;
  }

/// <summary>Part of the list interface for Rules
/// This function returns an element from the
/// collection in Rules based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Rule getRules(int idx)
{
  return (Rule) ( allRules()[idx]);
}

public Structure()
{
Structure obj = this;
aElements=(null);
aProcedures=(null);
aStateMachines=(null);
aRules=(null);
}

public void copyTo(Structure other)
{
base.copyTo(other);
other.aElements = aElements;
other.aProcedures = aProcedures;
other.aStateMachines = aStateMachines;
other.aRules = aRules;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
bool fl429;
Rule fl431;
bool fl442;
StructureProcedure fl444;
StructureElement fl456;
bool fl467;
StateMachine fl469;

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Rules")){
ctxt.skipWhiteSpace();
fl429 = true ; 
while (fl429) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl429 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl431 = null;
while(ctxt.lookAheadOpeningTag ("<Rule")) {
fl431 = acceptor.lAccept_Rule(ctxt, "</Rule>");
appendRules(fl431);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Rules>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Procedures")){
ctxt.skipWhiteSpace();
fl442 = true ; 
while (fl442) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl442 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl444 = null;
while(ctxt.lookAheadOpeningTag ("<StructureProcedure")) {
fl444 = acceptor.lAccept_StructureProcedure(ctxt, "</StructureProcedure>");
appendProcedures(fl444);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Procedures>");
} // If
} // If
// End enclosed
// Repeat
ctxt.skipWhiteSpace();
fl456 = null;
while(ctxt.lookAheadOpeningTag ("<StructureElement")) {
fl456 = acceptor.lAccept_StructureElement(ctxt, "</StructureElement>");
appendElements(fl456);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<StateMachines")){
ctxt.skipWhiteSpace();
fl467 = true ; 
while (fl467) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl467 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl469 = null;
while(ctxt.lookAheadOpeningTag ("<StateMachine")) {
fl469 = acceptor.lAccept_StateMachine(ctxt, "</StateMachine>");
appendStateMachines(fl469);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</StateMachines>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl480;
bool fl481;
bool fl482;
bool fl483;
bool fl484;
bool fl485;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl480 = false ; 
fl481 = false ; 
fl482 = false ; 
fl483 = false ; 
fl484 = false ; 
fl485 = true ; 
while (fl485) { // BeginLoop 
switch (ctxt.current()) {
case 'V':
{
ctxt.advance();
if (ctxt.lookAheadString("erified=")){
indicator = 482;
} else {
indicator = 486;
} // If
break;
} // Case
case 'N':
{
ctxt.advance();
switch (ctxt.current()) {
case 'e':
{
ctxt.advance();
if (ctxt.lookAheadString("edsRequirement=")){
indicator = 483;
} else {
indicator = 486;
} // If
break;
} // Case
case 'a':
{
ctxt.advance();
if (ctxt.lookAhead3('m','e','=')){
indicator = 484;
} else {
indicator = 486;
} // If
break;
} // Case
default:
indicator = 486;
break;
} // Switch
break;
} // Case
case 'I':
{
ctxt.advance();
if (ctxt.lookAheadString("mplemented=")){
indicator = 481;
} else {
indicator = 486;
} // If
break;
} // Case
case 'D':
{
ctxt.advance();
if (ctxt.lookAheadString("efault=")){
indicator = 480;
} else {
indicator = 486;
} // If
break;
} // Case
default:
indicator = 486;
break;
} // Switch
switch (indicator) {
case 480: {
// Handling attribute Default
// Also handles alien attributes with prefix Default
if (fl480){
ctxt.fail ("Duplicate attribute: Default");
} // If
fl480 = true ; 
quoteChar = ctxt.acceptQuote();
this.setDefault((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 481: {
// Handling attribute Implemented
// Also handles alien attributes with prefix Implemented
if (fl481){
ctxt.fail ("Duplicate attribute: Implemented");
} // If
fl481 = true ; 
quoteChar = ctxt.acceptQuote();
this.setImplemented(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 482: {
// Handling attribute Verified
// Also handles alien attributes with prefix Verified
if (fl482){
ctxt.fail ("Duplicate attribute: Verified");
} // If
fl482 = true ; 
quoteChar = ctxt.acceptQuote();
this.setVerified(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 483: {
// Handling attribute NeedsRequirement
// Also handles alien attributes with prefix NeedsRequirement
if (fl483){
ctxt.fail ("Duplicate attribute: NeedsRequirement");
} // If
fl483 = true ; 
quoteChar = ctxt.acceptQuote();
this.setNeedsRequirement(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 484: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl484){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl484 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 486: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl481){
this.setImplemented( false);
} // If
if (!fl482){
this.setVerified( false);
} // If
if (!fl483){
this.setNeedsRequirement( true);
} // If
fl485 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<Structure";
  endingTag = "</Structure>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"Structure\"");
} // If
pw.Write('\n');
if (this.getDefault() != null){
pw.Write(" Default=\"");
acceptor.unParsePcData(pw, this.getDefault());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getImplemented()){
pw.Write(" Implemented=\"");
acceptor.unParsePcData(pw, this.getImplemented());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getVerified()){
pw.Write(" Verified=\"");
acceptor.unParsePcData(pw, this.getVerified());
pw.Write('"');
pw.Write('\n');
} // If
if (!this.getNeedsRequirement()){
pw.Write(" NeedsRequirement=\"");
acceptor.unParsePcData(pw, this.getNeedsRequirement());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing Enclosed
// Testing for empty content: Rules
if (countRules() > 0){
pw.Write("<Rules>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getRules(), false, "<Rule", "</Rule>");
pw.Write("</Rules>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Rules
// Unparsing Enclosed
// Testing for empty content: Procedures
if (countProcedures() > 0){
pw.Write("<Procedures>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getProcedures(), false, "<StructureProcedure", "</StructureProcedure>");
pw.Write("</Procedures>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Procedures
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getElements(), false, "<StructureElement", "</StructureElement>");
// Unparsing Enclosed
// Testing for empty content: StateMachines
if (countStateMachines() > 0){
pw.Write("<StateMachines>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getStateMachines(), false, "<StateMachine", "</StateMachine>");
pw.Write("</StateMachines>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: StateMachines
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
for (int i = 0; i < countElements(); i++) {
  l.Add(getElements(i));
}
for (int i = 0; i < countProcedures(); i++) {
  l.Add(getProcedures(i));
}
for (int i = 0; i < countStateMachines(); i++) {
  l.Add(getStateMachines(i));
}
for (int i = 0; i < countRules(); i++) {
  l.Add(getRules(i));
}
}

}
public partial class StructureElement
: DataDictionary.ReqRelated
{
public  override  bool find(Object search){
if (search is String ) {
if(getTypeName().CompareTo((String) search) == 0)return true;
if(getDefault().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.StructureElementController.alertChange(aLock, this);
}
private   string  aTypeName;

public   string  getTypeName() { return aTypeName;}
public  void setTypeName( string  v) {
  aTypeName = v;
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aDefault;

public   string  getDefault() { return aDefault;}
public  void setDefault( string  v) {
  aDefault = v;
  __setDirty(true);
  NotifyControllers(null);
}

private  acceptor.VariableModeEnumType aMode;

public  acceptor.VariableModeEnumType getMode() { return aMode;}
public  void setMode(acceptor.VariableModeEnumType v) {
  aMode = v;
  __setDirty(true);
  NotifyControllers(null);
}

public  string   getMode_AsString()
{
  return acceptor.Enum_VariableModeEnumType_ToString (aMode);
}

public  bool setMode_AsString( string  v)
{
 acceptor.VariableModeEnumType  temp = acceptor.StringTo_Enum_VariableModeEnumType(v);
if (temp >= 0){
  aMode = temp;
  __setDirty(true);
  NotifyControllers(null);
  return true;
} // If
return false;
}

public StructureElement()
{
StructureElement obj = this;
aTypeName=(null);
aDefault=(null);
aMode=(0);
}

public void copyTo(StructureElement other)
{
base.copyTo(other);
other.aTypeName = aTypeName;
other.aDefault = aDefault;
other.aMode = aMode;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl494;
bool fl495;
bool fl496;
bool fl497;
bool fl498;
bool fl499;
bool fl500;
bool fl501;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl494 = false ; 
fl495 = false ; 
fl496 = false ; 
fl497 = false ; 
fl498 = false ; 
fl499 = false ; 
fl500 = false ; 
fl501 = true ; 
while (fl501) { // BeginLoop 
switch (ctxt.current()) {
case 'V':
{
ctxt.advance();
if (ctxt.lookAheadString("erified=")){
indicator = 498;
} else {
indicator = 502;
} // If
break;
} // Case
case 'T':
{
ctxt.advance();
if (ctxt.lookAheadString("ypeName=")){
indicator = 494;
} else {
indicator = 502;
} // If
break;
} // Case
case 'N':
{
ctxt.advance();
switch (ctxt.current()) {
case 'e':
{
ctxt.advance();
if (ctxt.lookAheadString("edsRequirement=")){
indicator = 499;
} else {
indicator = 502;
} // If
break;
} // Case
case 'a':
{
ctxt.advance();
if (ctxt.lookAhead3('m','e','=')){
indicator = 500;
} else {
indicator = 502;
} // If
break;
} // Case
default:
indicator = 502;
break;
} // Switch
break;
} // Case
case 'M':
{
ctxt.advance();
if (ctxt.lookAheadString("ode=")){
indicator = 496;
} else {
indicator = 502;
} // If
break;
} // Case
case 'I':
{
ctxt.advance();
if (ctxt.lookAheadString("mplemented=")){
indicator = 497;
} else {
indicator = 502;
} // If
break;
} // Case
case 'D':
{
ctxt.advance();
if (ctxt.lookAheadString("efault=")){
indicator = 495;
} else {
indicator = 502;
} // If
break;
} // Case
default:
indicator = 502;
break;
} // Switch
switch (indicator) {
case 494: {
// Handling attribute TypeName
// Also handles alien attributes with prefix TypeName
if (fl494){
ctxt.fail ("Duplicate attribute: TypeName");
} // If
fl494 = true ; 
quoteChar = ctxt.acceptQuote();
this.setTypeName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 495: {
// Handling attribute Default
// Also handles alien attributes with prefix Default
if (fl495){
ctxt.fail ("Duplicate attribute: Default");
} // If
fl495 = true ; 
quoteChar = ctxt.acceptQuote();
this.setDefault((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 496: {
// Handling attribute Mode
// Also handles alien attributes with prefix Mode
if (fl496){
ctxt.fail ("Duplicate attribute: Mode");
} // If
fl496 = true ; 
quoteChar = ctxt.acceptQuote();
this.setMode(acceptor.lAcceptEnum_VariableModeEnumType(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 497: {
// Handling attribute Implemented
// Also handles alien attributes with prefix Implemented
if (fl497){
ctxt.fail ("Duplicate attribute: Implemented");
} // If
fl497 = true ; 
quoteChar = ctxt.acceptQuote();
this.setImplemented(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 498: {
// Handling attribute Verified
// Also handles alien attributes with prefix Verified
if (fl498){
ctxt.fail ("Duplicate attribute: Verified");
} // If
fl498 = true ; 
quoteChar = ctxt.acceptQuote();
this.setVerified(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 499: {
// Handling attribute NeedsRequirement
// Also handles alien attributes with prefix NeedsRequirement
if (fl499){
ctxt.fail ("Duplicate attribute: NeedsRequirement");
} // If
fl499 = true ; 
quoteChar = ctxt.acceptQuote();
this.setNeedsRequirement(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 500: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl500){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl500 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 502: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl494){
ctxt.fail ("Mandatory attribute missing: TypeName in StructureElement");
} // If
if (!fl495){
this.setDefault("");
} // If
if (!fl496){
this.setMode(acceptor.VariableModeEnumType.aInternal);
} // If
if (!fl497){
this.setImplemented( false);
} // If
if (!fl498){
this.setVerified( false);
} // If
if (!fl499){
this.setNeedsRequirement( true);
} // If
fl501 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<StructureElement";
  endingTag = "</StructureElement>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"StructureElement\"");
} // If
pw.Write('\n');
pw.Write(" TypeName=\"");
acceptor.unParsePcData(pw, this.getTypeName());
pw.Write('"');
pw.Write('\n');
if (this.getDefault() != null){
pw.Write(" Default=\"");
acceptor.unParsePcData(pw, this.getDefault());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getMode() != 0){
pw.Write(" Mode=\"");
acceptor.unParsePcData(pw,
  acceptor.Enum_VariableModeEnumType_ToString(this.getMode()));
pw.Write('"');
pw.Write('\n');
} // If
if (this.getImplemented()){
pw.Write(" Implemented=\"");
acceptor.unParsePcData(pw, this.getImplemented());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getVerified()){
pw.Write(" Verified=\"");
acceptor.unParsePcData(pw, this.getVerified());
pw.Write('"');
pw.Write('\n');
} // If
if (!this.getNeedsRequirement()){
pw.Write(" NeedsRequirement=\"");
acceptor.unParsePcData(pw, this.getNeedsRequirement());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
}

}
public partial class StructureProcedure
: DataDictionary.ReqRelated
{
public  override  bool find(Object search){
if (search is String ) {
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.StructureProcedureController.alertChange(aLock, this);
}
private  StateMachine aStateMachine;

public  StateMachine getStateMachine() { return aStateMachine;}
public  void setStateMachine(StateMachine v) {
  aStateMachine = v;
  if ( v != null ) { 
    v.setFather(this);
  }
  __setDirty(true);
  NotifyControllers(null);
}

private System.Collections.ArrayList aRules;

/// <summary>Part of the list interface for Rules</summary>
/// <returns>a collection of all the elements in Rules</returns>
public System.Collections.ArrayList allRules()
  {
if (aRules == null){
    setAllRules( new System.Collections.ArrayList() );
} // If
    return aRules;
  }

/// <summary>Part of the list interface for Rules</summary>
/// <returns>a collection of all the elements in Rules</returns>
private System.Collections.ArrayList getRules()
  {
    return allRules();
  }

/// <summary>Part of the list interface for Rules</summary>
/// <param name="coll">a collection of elements which replaces 
///        Rules's current content.</param>
public void setAllRules(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aRules = coll;
    NotifyControllers(null);
  }
public void setAllRules(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aRules = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Rules</summary>
/// <param name="el">a Rule to add to the collection in 
///           Rules</param>
/// <seealso cref="appendRules(ICollection)"/>
public void appendRules(Rule el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allRules().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendRules(Lock aLock,Rule el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allRules().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Rules</summary>
/// <param name="coll">a collection ofRules to add to the collection in 
///           Rules</param>
/// <seealso cref="appendRules(Rule)"/>
public void appendRules(ICollection coll)
  {
  __setDirty(true);
  allRules().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendRules(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allRules().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Rules
/// This insertion function inserts a new element in the
/// collection in Rules</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertRules(int idx, Rule el)
  {
  __setDirty(true);
  allRules().Insert (idx, el);
NotifyControllers(null);
  }

public void insertRules(int idx, Rule el,Lock aLock)
  {
  __setDirty(true);
  allRules().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Rules
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfRules(IXmlBBase el)
  {
  return allRules().IndexOf (el);
  }

/// <summary>Part of the list interface for Rules
/// This deletion function removes an element from the
/// collection in Rules</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteRules(int idx)
  {
  __setDirty(true);
  allRules().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteRules(int idx,Lock aLock)
  {
  __setDirty(true);
  allRules().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Rules
/// This deletion function removes an element from the
/// collection in Rules
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeRules(IXmlBBase obj)
  {
  int idx = indexOfRules(obj);
  if (idx >= 0) { deleteRules(idx);
NotifyControllers(null);
   }
  }

public void removeRules(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfRules(obj);
  if (idx >= 0) { deleteRules(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Rules</summary>
/// <returns>the number of elements in Rules</returns>
public int countRules()
  {
  return allRules().Count;
  }

/// <summary>Part of the list interface for Rules
/// This function returns an element from the
/// collection in Rules based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Rule getRules(int idx)
{
  return (Rule) ( allRules()[idx]);
}

private System.Collections.ArrayList aParameters;

/// <summary>Part of the list interface for Parameters</summary>
/// <returns>a collection of all the elements in Parameters</returns>
public System.Collections.ArrayList allParameters()
  {
if (aParameters == null){
    setAllParameters( new System.Collections.ArrayList() );
} // If
    return aParameters;
  }

/// <summary>Part of the list interface for Parameters</summary>
/// <returns>a collection of all the elements in Parameters</returns>
private System.Collections.ArrayList getParameters()
  {
    return allParameters();
  }

/// <summary>Part of the list interface for Parameters</summary>
/// <param name="coll">a collection of elements which replaces 
///        Parameters's current content.</param>
public void setAllParameters(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aParameters = coll;
    NotifyControllers(null);
  }
public void setAllParameters(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aParameters = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Parameters</summary>
/// <param name="el">a Parameter to add to the collection in 
///           Parameters</param>
/// <seealso cref="appendParameters(ICollection)"/>
public void appendParameters(Parameter el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allParameters().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendParameters(Lock aLock,Parameter el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allParameters().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Parameters</summary>
/// <param name="coll">a collection ofParameters to add to the collection in 
///           Parameters</param>
/// <seealso cref="appendParameters(Parameter)"/>
public void appendParameters(ICollection coll)
  {
  __setDirty(true);
  allParameters().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendParameters(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allParameters().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Parameters
/// This insertion function inserts a new element in the
/// collection in Parameters</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertParameters(int idx, Parameter el)
  {
  __setDirty(true);
  allParameters().Insert (idx, el);
NotifyControllers(null);
  }

public void insertParameters(int idx, Parameter el,Lock aLock)
  {
  __setDirty(true);
  allParameters().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Parameters
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfParameters(IXmlBBase el)
  {
  return allParameters().IndexOf (el);
  }

/// <summary>Part of the list interface for Parameters
/// This deletion function removes an element from the
/// collection in Parameters</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteParameters(int idx)
  {
  __setDirty(true);
  allParameters().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteParameters(int idx,Lock aLock)
  {
  __setDirty(true);
  allParameters().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Parameters
/// This deletion function removes an element from the
/// collection in Parameters
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeParameters(IXmlBBase obj)
  {
  int idx = indexOfParameters(obj);
  if (idx >= 0) { deleteParameters(idx);
NotifyControllers(null);
   }
  }

public void removeParameters(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfParameters(obj);
  if (idx >= 0) { deleteParameters(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Parameters</summary>
/// <returns>the number of elements in Parameters</returns>
public int countParameters()
  {
  return allParameters().Count;
  }

/// <summary>Part of the list interface for Parameters
/// This function returns an element from the
/// collection in Parameters based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Parameter getParameters(int idx)
{
  return (Parameter) ( allParameters()[idx]);
}

public StructureProcedure()
{
StructureProcedure obj = this;
aStateMachine=(null);
aRules=(null);
aParameters=(null);
}

public void copyTo(StructureProcedure other)
{
base.copyTo(other);
other.aStateMachine = aStateMachine;
other.aRules = aRules;
other.aParameters = aParameters;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
bool fl512;
Parameter fl514;
bool fl525;
Rule fl527;

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Parameters")){
ctxt.skipWhiteSpace();
fl512 = true ; 
while (fl512) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl512 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl514 = null;
while(ctxt.lookAheadOpeningTag ("<Parameter")) {
fl514 = acceptor.lAccept_Parameter(ctxt, "</Parameter>");
appendParameters(fl514);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Parameters>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Rules")){
ctxt.skipWhiteSpace();
fl525 = true ; 
while (fl525) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl525 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl527 = null;
while(ctxt.lookAheadOpeningTag ("<Rule")) {
fl527 = acceptor.lAccept_Rule(ctxt, "</Rule>");
appendRules(fl527);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Rules>");
} // If
} // If
// End enclosed
// Element Ref : StateMachine
ctxt.skipWhiteSpace();
// If optional...
if (ctxt.lookAheadOpeningTag("<StateMachine")){
// Parsing sub element
this.setStateMachine(acceptor.lAccept_StateMachine(ctxt,"</StateMachine>"));
setSon(this.getStateMachine());
// Endif optional...
} // If
ctxt.skipWhiteSpace();
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl538;
bool fl539;
bool fl540;
bool fl541;
bool fl542;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl538 = false ; 
fl539 = false ; 
fl540 = false ; 
fl541 = false ; 
fl542 = true ; 
while (fl542) { // BeginLoop 
switch (ctxt.current()) {
case 'V':
{
ctxt.advance();
if (ctxt.lookAheadString("erified=")){
indicator = 539;
} else {
indicator = 543;
} // If
break;
} // Case
case 'N':
{
ctxt.advance();
switch (ctxt.current()) {
case 'e':
{
ctxt.advance();
if (ctxt.lookAheadString("edsRequirement=")){
indicator = 540;
} else {
indicator = 543;
} // If
break;
} // Case
case 'a':
{
ctxt.advance();
if (ctxt.lookAhead3('m','e','=')){
indicator = 541;
} else {
indicator = 543;
} // If
break;
} // Case
default:
indicator = 543;
break;
} // Switch
break;
} // Case
case 'I':
{
ctxt.advance();
if (ctxt.lookAheadString("mplemented=")){
indicator = 538;
} else {
indicator = 543;
} // If
break;
} // Case
default:
indicator = 543;
break;
} // Switch
switch (indicator) {
case 538: {
// Handling attribute Implemented
// Also handles alien attributes with prefix Implemented
if (fl538){
ctxt.fail ("Duplicate attribute: Implemented");
} // If
fl538 = true ; 
quoteChar = ctxt.acceptQuote();
this.setImplemented(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 539: {
// Handling attribute Verified
// Also handles alien attributes with prefix Verified
if (fl539){
ctxt.fail ("Duplicate attribute: Verified");
} // If
fl539 = true ; 
quoteChar = ctxt.acceptQuote();
this.setVerified(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 540: {
// Handling attribute NeedsRequirement
// Also handles alien attributes with prefix NeedsRequirement
if (fl540){
ctxt.fail ("Duplicate attribute: NeedsRequirement");
} // If
fl540 = true ; 
quoteChar = ctxt.acceptQuote();
this.setNeedsRequirement(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 541: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl541){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl541 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 543: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl538){
this.setImplemented( false);
} // If
if (!fl539){
this.setVerified( false);
} // If
if (!fl540){
this.setNeedsRequirement( true);
} // If
fl542 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<StructureProcedure";
  endingTag = "</StructureProcedure>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"StructureProcedure\"");
} // If
pw.Write('\n');
if (this.getImplemented()){
pw.Write(" Implemented=\"");
acceptor.unParsePcData(pw, this.getImplemented());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getVerified()){
pw.Write(" Verified=\"");
acceptor.unParsePcData(pw, this.getVerified());
pw.Write('"');
pw.Write('\n');
} // If
if (!this.getNeedsRequirement()){
pw.Write(" NeedsRequirement=\"");
acceptor.unParsePcData(pw, this.getNeedsRequirement());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing Enclosed
// Testing for empty content: Parameters
if (countParameters() > 0){
pw.Write("<Parameters>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getParameters(), false, "<Parameter", "</Parameter>");
pw.Write("</Parameters>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Parameters
// Unparsing Enclosed
// Testing for empty content: Rules
if (countRules() > 0){
pw.Write("<Rules>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getRules(), false, "<Rule", "</Rule>");
pw.Write("</Rules>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Rules
// Unparsing ElementRef
if (this.getStateMachine() != null){
unParse(pw, this.getStateMachine(),false,"<StateMachine","</StateMachine>");
} // If
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
l.Add(this.getStateMachine());
for (int i = 0; i < countRules(); i++) {
  l.Add(getRules(i));
}
for (int i = 0; i < countParameters(); i++) {
  l.Add(getParameters(i));
}
}

}
public partial class Collection
: DataDictionary.Types.Type
{
public  override  bool find(Object search){
if (search is String ) {
if(getTypeName().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.CollectionController.alertChange(aLock, this);
}
private   string  aTypeName;

public   string  getTypeName() { return aTypeName;}
public  void setTypeName( string  v) {
  aTypeName = v;
  __setDirty(true);
  NotifyControllers(null);
}

private  int aMaxSize;

public  int getMaxSize() { return aMaxSize;}
public  void setMaxSize(int v) {
  aMaxSize = v;
  __setDirty(true);
  NotifyControllers(null);
}

public Collection()
{
Collection obj = this;
aTypeName=(null);
aMaxSize=(0);
}

public void copyTo(Collection other)
{
base.copyTo(other);
other.aTypeName = aTypeName;
other.aMaxSize = aMaxSize;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl550;
bool fl551;
bool fl552;
bool fl553;
bool fl554;
bool fl555;
bool fl556;
bool fl557;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl550 = false ; 
fl551 = false ; 
fl552 = false ; 
fl553 = false ; 
fl554 = false ; 
fl555 = false ; 
fl556 = false ; 
fl557 = true ; 
while (fl557) { // BeginLoop 
switch (ctxt.current()) {
case 'V':
{
ctxt.advance();
if (ctxt.lookAheadString("erified=")){
indicator = 554;
} else {
indicator = 558;
} // If
break;
} // Case
case 'T':
{
ctxt.advance();
if (ctxt.lookAheadString("ypeName=")){
indicator = 550;
} else {
indicator = 558;
} // If
break;
} // Case
case 'N':
{
ctxt.advance();
switch (ctxt.current()) {
case 'e':
{
ctxt.advance();
if (ctxt.lookAheadString("edsRequirement=")){
indicator = 555;
} else {
indicator = 558;
} // If
break;
} // Case
case 'a':
{
ctxt.advance();
if (ctxt.lookAhead3('m','e','=')){
indicator = 556;
} else {
indicator = 558;
} // If
break;
} // Case
default:
indicator = 558;
break;
} // Switch
break;
} // Case
case 'M':
{
ctxt.advance();
if (ctxt.lookAheadString("axSize=")){
indicator = 551;
} else {
indicator = 558;
} // If
break;
} // Case
case 'I':
{
ctxt.advance();
if (ctxt.lookAheadString("mplemented=")){
indicator = 553;
} else {
indicator = 558;
} // If
break;
} // Case
case 'D':
{
ctxt.advance();
if (ctxt.lookAheadString("efault=")){
indicator = 552;
} else {
indicator = 558;
} // If
break;
} // Case
default:
indicator = 558;
break;
} // Switch
switch (indicator) {
case 550: {
// Handling attribute TypeName
// Also handles alien attributes with prefix TypeName
if (fl550){
ctxt.fail ("Duplicate attribute: TypeName");
} // If
fl550 = true ; 
quoteChar = ctxt.acceptQuote();
this.setTypeName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 551: {
// Handling attribute MaxSize
// Also handles alien attributes with prefix MaxSize
if (fl551){
ctxt.fail ("Duplicate attribute: MaxSize");
} // If
fl551 = true ; 
quoteChar = ctxt.acceptQuote();
this.setMaxSize(ctxt.fetchInteger());
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 552: {
// Handling attribute Default
// Also handles alien attributes with prefix Default
if (fl552){
ctxt.fail ("Duplicate attribute: Default");
} // If
fl552 = true ; 
quoteChar = ctxt.acceptQuote();
this.setDefault((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 553: {
// Handling attribute Implemented
// Also handles alien attributes with prefix Implemented
if (fl553){
ctxt.fail ("Duplicate attribute: Implemented");
} // If
fl553 = true ; 
quoteChar = ctxt.acceptQuote();
this.setImplemented(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 554: {
// Handling attribute Verified
// Also handles alien attributes with prefix Verified
if (fl554){
ctxt.fail ("Duplicate attribute: Verified");
} // If
fl554 = true ; 
quoteChar = ctxt.acceptQuote();
this.setVerified(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 555: {
// Handling attribute NeedsRequirement
// Also handles alien attributes with prefix NeedsRequirement
if (fl555){
ctxt.fail ("Duplicate attribute: NeedsRequirement");
} // If
fl555 = true ; 
quoteChar = ctxt.acceptQuote();
this.setNeedsRequirement(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 556: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl556){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl556 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 558: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl550){
ctxt.fail ("Mandatory attribute missing: TypeName in Collection");
} // If
if (!fl551){
this.setMaxSize(10);
} // If
if (!fl553){
this.setImplemented( false);
} // If
if (!fl554){
this.setVerified( false);
} // If
if (!fl555){
this.setNeedsRequirement( true);
} // If
fl557 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<Collection";
  endingTag = "</Collection>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"Collection\"");
} // If
pw.Write('\n');
pw.Write(" TypeName=\"");
acceptor.unParsePcData(pw, this.getTypeName());
pw.Write('"');
pw.Write('\n');
if (this.getMaxSize() != 10){
pw.Write(" MaxSize=\"");
acceptor.unParsePcData(pw, this.getMaxSize());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getDefault() != null){
pw.Write(" Default=\"");
acceptor.unParsePcData(pw, this.getDefault());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getImplemented()){
pw.Write(" Implemented=\"");
acceptor.unParsePcData(pw, this.getImplemented());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getVerified()){
pw.Write(" Verified=\"");
acceptor.unParsePcData(pw, this.getVerified());
pw.Write('"');
pw.Write('\n');
} // If
if (!this.getNeedsRequirement()){
pw.Write(" NeedsRequirement=\"");
acceptor.unParsePcData(pw, this.getNeedsRequirement());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
}

}
public partial class Function
: DataDictionary.Types.Type
{
public  override  bool find(Object search){
if (search is String ) {
if(getTypeName().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.FunctionController.alertChange(aLock, this);
}
private System.Collections.ArrayList aParameters;

/// <summary>Part of the list interface for Parameters</summary>
/// <returns>a collection of all the elements in Parameters</returns>
public System.Collections.ArrayList allParameters()
  {
if (aParameters == null){
    setAllParameters( new System.Collections.ArrayList() );
} // If
    return aParameters;
  }

/// <summary>Part of the list interface for Parameters</summary>
/// <returns>a collection of all the elements in Parameters</returns>
private System.Collections.ArrayList getParameters()
  {
    return allParameters();
  }

/// <summary>Part of the list interface for Parameters</summary>
/// <param name="coll">a collection of elements which replaces 
///        Parameters's current content.</param>
public void setAllParameters(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aParameters = coll;
    NotifyControllers(null);
  }
public void setAllParameters(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aParameters = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Parameters</summary>
/// <param name="el">a Parameter to add to the collection in 
///           Parameters</param>
/// <seealso cref="appendParameters(ICollection)"/>
public void appendParameters(Parameter el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allParameters().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendParameters(Lock aLock,Parameter el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allParameters().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Parameters</summary>
/// <param name="coll">a collection ofParameters to add to the collection in 
///           Parameters</param>
/// <seealso cref="appendParameters(Parameter)"/>
public void appendParameters(ICollection coll)
  {
  __setDirty(true);
  allParameters().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendParameters(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allParameters().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Parameters
/// This insertion function inserts a new element in the
/// collection in Parameters</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertParameters(int idx, Parameter el)
  {
  __setDirty(true);
  allParameters().Insert (idx, el);
NotifyControllers(null);
  }

public void insertParameters(int idx, Parameter el,Lock aLock)
  {
  __setDirty(true);
  allParameters().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Parameters
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfParameters(IXmlBBase el)
  {
  return allParameters().IndexOf (el);
  }

/// <summary>Part of the list interface for Parameters
/// This deletion function removes an element from the
/// collection in Parameters</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteParameters(int idx)
  {
  __setDirty(true);
  allParameters().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteParameters(int idx,Lock aLock)
  {
  __setDirty(true);
  allParameters().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Parameters
/// This deletion function removes an element from the
/// collection in Parameters
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeParameters(IXmlBBase obj)
  {
  int idx = indexOfParameters(obj);
  if (idx >= 0) { deleteParameters(idx);
NotifyControllers(null);
   }
  }

public void removeParameters(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfParameters(obj);
  if (idx >= 0) { deleteParameters(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Parameters</summary>
/// <returns>the number of elements in Parameters</returns>
public int countParameters()
  {
  return allParameters().Count;
  }

/// <summary>Part of the list interface for Parameters
/// This function returns an element from the
/// collection in Parameters based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Parameter getParameters(int idx)
{
  return (Parameter) ( allParameters()[idx]);
}

private System.Collections.ArrayList aCases;

/// <summary>Part of the list interface for Cases</summary>
/// <returns>a collection of all the elements in Cases</returns>
public System.Collections.ArrayList allCases()
  {
if (aCases == null){
    setAllCases( new System.Collections.ArrayList() );
} // If
    return aCases;
  }

/// <summary>Part of the list interface for Cases</summary>
/// <returns>a collection of all the elements in Cases</returns>
private System.Collections.ArrayList getCases()
  {
    return allCases();
  }

/// <summary>Part of the list interface for Cases</summary>
/// <param name="coll">a collection of elements which replaces 
///        Cases's current content.</param>
public void setAllCases(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aCases = coll;
    NotifyControllers(null);
  }
public void setAllCases(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aCases = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Cases</summary>
/// <param name="el">a Case to add to the collection in 
///           Cases</param>
/// <seealso cref="appendCases(ICollection)"/>
public void appendCases(Case el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allCases().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendCases(Lock aLock,Case el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allCases().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Cases</summary>
/// <param name="coll">a collection ofCases to add to the collection in 
///           Cases</param>
/// <seealso cref="appendCases(Case)"/>
public void appendCases(ICollection coll)
  {
  __setDirty(true);
  allCases().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendCases(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allCases().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Cases
/// This insertion function inserts a new element in the
/// collection in Cases</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertCases(int idx, Case el)
  {
  __setDirty(true);
  allCases().Insert (idx, el);
NotifyControllers(null);
  }

public void insertCases(int idx, Case el,Lock aLock)
  {
  __setDirty(true);
  allCases().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Cases
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfCases(IXmlBBase el)
  {
  return allCases().IndexOf (el);
  }

/// <summary>Part of the list interface for Cases
/// This deletion function removes an element from the
/// collection in Cases</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteCases(int idx)
  {
  __setDirty(true);
  allCases().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteCases(int idx,Lock aLock)
  {
  __setDirty(true);
  allCases().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Cases
/// This deletion function removes an element from the
/// collection in Cases
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeCases(IXmlBBase obj)
  {
  int idx = indexOfCases(obj);
  if (idx >= 0) { deleteCases(idx);
NotifyControllers(null);
   }
  }

public void removeCases(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfCases(obj);
  if (idx >= 0) { deleteCases(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Cases</summary>
/// <returns>the number of elements in Cases</returns>
public int countCases()
  {
  return allCases().Count;
  }

/// <summary>Part of the list interface for Cases
/// This function returns an element from the
/// collection in Cases based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Case getCases(int idx)
{
  return (Case) ( allCases()[idx]);
}

private   string  aTypeName;

public   string  getTypeName() { return aTypeName;}
public  void setTypeName( string  v) {
  aTypeName = v;
  __setDirty(true);
  NotifyControllers(null);
}

private  bool aCacheable;

public  bool getCacheable() { return aCacheable;}
public  void setCacheable(bool v) {
  aCacheable = v;
  __setDirty(true);
  NotifyControllers(null);
}

public Function()
{
Function obj = this;
aParameters=(null);
aCases=(null);
aTypeName=(null);
aCacheable=(false);
}

public void copyTo(Function other)
{
base.copyTo(other);
other.aParameters = aParameters;
other.aCases = aCases;
other.aTypeName = aTypeName;
other.aCacheable = aCacheable;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
bool fl568;
Parameter fl570;
bool fl581;
Case fl583;

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Parameters")){
ctxt.skipWhiteSpace();
fl568 = true ; 
while (fl568) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl568 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl570 = null;
while(ctxt.lookAheadOpeningTag ("<Parameter")) {
fl570 = acceptor.lAccept_Parameter(ctxt, "</Parameter>");
appendParameters(fl570);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Parameters>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Enclosed
ctxt.acceptString ("<Cases");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
ctxt.skipWhiteSpace();
fl581 = true ; 
while (fl581) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl581 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl583 = null;
while(ctxt.lookAheadOpeningTag ("<Case")) {
fl583 = acceptor.lAccept_Case(ctxt, "</Case>");
appendCases(fl583);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Cases>");
} // If
// End enclosed
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl594;
bool fl595;
bool fl596;
bool fl597;
bool fl598;
bool fl599;
bool fl600;
bool fl601;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl594 = false ; 
fl595 = false ; 
fl596 = false ; 
fl597 = false ; 
fl598 = false ; 
fl599 = false ; 
fl600 = false ; 
fl601 = true ; 
while (fl601) { // BeginLoop 
switch (ctxt.current()) {
case 'V':
{
ctxt.advance();
if (ctxt.lookAheadString("erified=")){
indicator = 598;
} else {
indicator = 602;
} // If
break;
} // Case
case 'T':
{
ctxt.advance();
if (ctxt.lookAheadString("ype=")){
indicator = 594;
} else {
indicator = 602;
} // If
break;
} // Case
case 'N':
{
ctxt.advance();
switch (ctxt.current()) {
case 'e':
{
ctxt.advance();
if (ctxt.lookAheadString("edsRequirement=")){
indicator = 599;
} else {
indicator = 602;
} // If
break;
} // Case
case 'a':
{
ctxt.advance();
if (ctxt.lookAhead3('m','e','=')){
indicator = 600;
} else {
indicator = 602;
} // If
break;
} // Case
default:
indicator = 602;
break;
} // Switch
break;
} // Case
case 'I':
{
ctxt.advance();
if (ctxt.lookAheadString("mplemented=")){
indicator = 597;
} else {
indicator = 602;
} // If
break;
} // Case
case 'D':
{
ctxt.advance();
if (ctxt.lookAheadString("efault=")){
indicator = 596;
} else {
indicator = 602;
} // If
break;
} // Case
case 'C':
{
ctxt.advance();
if (ctxt.lookAheadString("acheable=")){
indicator = 595;
} else {
indicator = 602;
} // If
break;
} // Case
default:
indicator = 602;
break;
} // Switch
switch (indicator) {
case 594: {
// Handling attribute Type
// Also handles alien attributes with prefix Type
if (fl594){
ctxt.fail ("Duplicate attribute: Type");
} // If
fl594 = true ; 
quoteChar = ctxt.acceptQuote();
this.setTypeName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 595: {
// Handling attribute Cacheable
// Also handles alien attributes with prefix Cacheable
if (fl595){
ctxt.fail ("Duplicate attribute: Cacheable");
} // If
fl595 = true ; 
quoteChar = ctxt.acceptQuote();
this.setCacheable(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 596: {
// Handling attribute Default
// Also handles alien attributes with prefix Default
if (fl596){
ctxt.fail ("Duplicate attribute: Default");
} // If
fl596 = true ; 
quoteChar = ctxt.acceptQuote();
this.setDefault((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 597: {
// Handling attribute Implemented
// Also handles alien attributes with prefix Implemented
if (fl597){
ctxt.fail ("Duplicate attribute: Implemented");
} // If
fl597 = true ; 
quoteChar = ctxt.acceptQuote();
this.setImplemented(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 598: {
// Handling attribute Verified
// Also handles alien attributes with prefix Verified
if (fl598){
ctxt.fail ("Duplicate attribute: Verified");
} // If
fl598 = true ; 
quoteChar = ctxt.acceptQuote();
this.setVerified(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 599: {
// Handling attribute NeedsRequirement
// Also handles alien attributes with prefix NeedsRequirement
if (fl599){
ctxt.fail ("Duplicate attribute: NeedsRequirement");
} // If
fl599 = true ; 
quoteChar = ctxt.acceptQuote();
this.setNeedsRequirement(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 600: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl600){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl600 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 602: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl595){
this.setCacheable( false);
} // If
if (!fl597){
this.setImplemented( false);
} // If
if (!fl598){
this.setVerified( false);
} // If
if (!fl599){
this.setNeedsRequirement( true);
} // If
fl601 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<Function";
  endingTag = "</Function>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"Function\"");
} // If
pw.Write('\n');
if (this.getTypeName() != null){
pw.Write(" Type=\"");
acceptor.unParsePcData(pw, this.getTypeName());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getCacheable()){
pw.Write(" Cacheable=\"");
acceptor.unParsePcData(pw, this.getCacheable());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getDefault() != null){
pw.Write(" Default=\"");
acceptor.unParsePcData(pw, this.getDefault());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getImplemented()){
pw.Write(" Implemented=\"");
acceptor.unParsePcData(pw, this.getImplemented());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getVerified()){
pw.Write(" Verified=\"");
acceptor.unParsePcData(pw, this.getVerified());
pw.Write('"');
pw.Write('\n');
} // If
if (!this.getNeedsRequirement()){
pw.Write(" NeedsRequirement=\"");
acceptor.unParsePcData(pw, this.getNeedsRequirement());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing Enclosed
// Testing for empty content: Parameters
if (countParameters() > 0){
pw.Write("<Parameters>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getParameters(), false, "<Parameter", "</Parameter>");
pw.Write("</Parameters>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Parameters
// Unparsing Enclosed
pw.Write("<Cases>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getCases(), false, "<Case", "</Case>");
pw.Write("</Cases>");
// Father is not a mixed
pw.Write('\n');
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
for (int i = 0; i < countParameters(); i++) {
  l.Add(getParameters(i));
}
for (int i = 0; i < countCases(); i++) {
  l.Add(getCases(i));
}
}

}
public partial class Parameter
: DataDictionary.Namable
{
public  override  bool find(Object search){
if (search is String ) {
if(getTypeName().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.ParameterController.alertChange(aLock, this);
}
private   string  aTypeName;

public   string  getTypeName() { return aTypeName;}
public  void setTypeName( string  v) {
  aTypeName = v;
  __setDirty(true);
  NotifyControllers(null);
}

public Parameter()
{
Parameter obj = this;
aTypeName=(null);
}

public void copyTo(Parameter other)
{
base.copyTo(other);
other.aTypeName = aTypeName;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl612;
bool fl613;
bool fl614;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl612 = false ; 
fl613 = false ; 
fl614 = true ; 
while (fl614) { // BeginLoop 
switch (ctxt.current()) {
case 'T':
{
ctxt.advance();
if (ctxt.lookAheadString("ype=")){
indicator = 612;
} else {
indicator = 615;
} // If
break;
} // Case
case 'N':
{
ctxt.advance();
if (ctxt.lookAheadString("ame=")){
indicator = 613;
} else {
indicator = 615;
} // If
break;
} // Case
default:
indicator = 615;
break;
} // Switch
switch (indicator) {
case 612: {
// Handling attribute Type
// Also handles alien attributes with prefix Type
if (fl612){
ctxt.fail ("Duplicate attribute: Type");
} // If
fl612 = true ; 
quoteChar = ctxt.acceptQuote();
this.setTypeName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 613: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl613){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl613 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 615: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl612){
ctxt.fail ("Mandatory attribute missing: Type in Parameter");
} // If
fl614 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<Parameter";
  endingTag = "</Parameter>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"Parameter\"");
} // If
pw.Write('\n');
pw.Write(" Type=\"");
acceptor.unParsePcData(pw, this.getTypeName());
pw.Write('"');
pw.Write('\n');
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
}

}
public partial class Case
: DataDictionary.Namable
{
public  override  bool find(Object search){
if (search is String ) {
if(getExpression().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.CaseController.alertChange(aLock, this);
}
private System.Collections.ArrayList aPreConditions;

/// <summary>Part of the list interface for PreConditions</summary>
/// <returns>a collection of all the elements in PreConditions</returns>
public System.Collections.ArrayList allPreConditions()
  {
if (aPreConditions == null){
    setAllPreConditions( new System.Collections.ArrayList() );
} // If
    return aPreConditions;
  }

/// <summary>Part of the list interface for PreConditions</summary>
/// <returns>a collection of all the elements in PreConditions</returns>
private System.Collections.ArrayList getPreConditions()
  {
    return allPreConditions();
  }

/// <summary>Part of the list interface for PreConditions</summary>
/// <param name="coll">a collection of elements which replaces 
///        PreConditions's current content.</param>
public void setAllPreConditions(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aPreConditions = coll;
    NotifyControllers(null);
  }
public void setAllPreConditions(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aPreConditions = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for PreConditions</summary>
/// <param name="el">a PreCondition to add to the collection in 
///           PreConditions</param>
/// <seealso cref="appendPreConditions(ICollection)"/>
public void appendPreConditions(PreCondition el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allPreConditions().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendPreConditions(Lock aLock,PreCondition el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allPreConditions().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for PreConditions</summary>
/// <param name="coll">a collection ofPreConditions to add to the collection in 
///           PreConditions</param>
/// <seealso cref="appendPreConditions(PreCondition)"/>
public void appendPreConditions(ICollection coll)
  {
  __setDirty(true);
  allPreConditions().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendPreConditions(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allPreConditions().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for PreConditions
/// This insertion function inserts a new element in the
/// collection in PreConditions</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertPreConditions(int idx, PreCondition el)
  {
  __setDirty(true);
  allPreConditions().Insert (idx, el);
NotifyControllers(null);
  }

public void insertPreConditions(int idx, PreCondition el,Lock aLock)
  {
  __setDirty(true);
  allPreConditions().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for PreConditions
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfPreConditions(IXmlBBase el)
  {
  return allPreConditions().IndexOf (el);
  }

/// <summary>Part of the list interface for PreConditions
/// This deletion function removes an element from the
/// collection in PreConditions</summary>
/// <param name="idx">the index of the element to remove</param>
public void deletePreConditions(int idx)
  {
  __setDirty(true);
  allPreConditions().RemoveAt(idx);
NotifyControllers(null);
  }

public void deletePreConditions(int idx,Lock aLock)
  {
  __setDirty(true);
  allPreConditions().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for PreConditions
/// This deletion function removes an element from the
/// collection in PreConditions
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removePreConditions(IXmlBBase obj)
  {
  int idx = indexOfPreConditions(obj);
  if (idx >= 0) { deletePreConditions(idx);
NotifyControllers(null);
   }
  }

public void removePreConditions(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfPreConditions(obj);
  if (idx >= 0) { deletePreConditions(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for PreConditions</summary>
/// <returns>the number of elements in PreConditions</returns>
public int countPreConditions()
  {
  return allPreConditions().Count;
  }

/// <summary>Part of the list interface for PreConditions
/// This function returns an element from the
/// collection in PreConditions based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public PreCondition getPreConditions(int idx)
{
  return (PreCondition) ( allPreConditions()[idx]);
}

private   string  aExpression;

public   string  getExpression() { return aExpression;}
public  void setExpression( string  v) {
  aExpression = v;
  __setDirty(true);
  NotifyControllers(null);
}

public Case()
{
Case obj = this;
aPreConditions=(null);
aExpression=(null);
}

public void copyTo(Case other)
{
base.copyTo(other);
other.aPreConditions = aPreConditions;
other.aExpression = aExpression;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
bool fl619;
PreCondition fl621;
bool fl632;

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<PreConditions")){
ctxt.skipWhiteSpace();
fl619 = true ; 
while (fl619) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl619 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl621 = null;
while(ctxt.lookAheadOpeningTag ("<PreCondition")) {
fl621 = acceptor.lAccept_PreCondition(ctxt, null);
appendPreConditions(fl621);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</PreConditions>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Enclosed
ctxt.acceptString ("<Expression");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
ctxt.skipWhiteSpace();
fl632 = true ; 
while (fl632) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl632 = false ; 
} // If
} // While
ctxt.accept('>');
// Indicator
// Parse PC data
this.setExpression(acceptor.lAcceptPcData(ctxt, -1, '<',XmlBContext.WS_PRESERVE));
// Regexp
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Expression>");
// End enclosed
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl633;
bool fl634;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl633 = false ; 
fl634 = true ; 
while (fl634) { // BeginLoop 
if (ctxt.lookAheadString("Name=")){
indicator = 633;
} else {
indicator = 635;
} // If
switch (indicator) {
case 633: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl633){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl633 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 635: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl634 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<Case";
  endingTag = "</Case>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"Case\"");
} // If
pw.Write('\n');
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing Enclosed
// Testing for empty content: PreConditions
if (countPreConditions() > 0){
pw.Write("<PreConditions>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getPreConditions(), false, null, null);
pw.Write("</PreConditions>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: PreConditions
// Unparsing Enclosed
pw.Write("<Expression>");
// Unparsing PcData
acceptor.unParsePcData(pw, this.getExpression());
pw.Write("</Expression>");
// Father is not a mixed
pw.Write('\n');
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
for (int i = 0; i < countPreConditions(); i++) {
  l.Add(getPreConditions(i));
}
}

}
public partial class Procedure
: DataDictionary.ReqRelated
{
public  override  bool find(Object search){
if (search is String ) {
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.ProcedureController.alertChange(aLock, this);
}
private  StateMachine aStateMachine;

public  StateMachine getStateMachine() { return aStateMachine;}
public  void setStateMachine(StateMachine v) {
  aStateMachine = v;
  if ( v != null ) { 
    v.setFather(this);
  }
  __setDirty(true);
  NotifyControllers(null);
}

private System.Collections.ArrayList aRules;

/// <summary>Part of the list interface for Rules</summary>
/// <returns>a collection of all the elements in Rules</returns>
public System.Collections.ArrayList allRules()
  {
if (aRules == null){
    setAllRules( new System.Collections.ArrayList() );
} // If
    return aRules;
  }

/// <summary>Part of the list interface for Rules</summary>
/// <returns>a collection of all the elements in Rules</returns>
private System.Collections.ArrayList getRules()
  {
    return allRules();
  }

/// <summary>Part of the list interface for Rules</summary>
/// <param name="coll">a collection of elements which replaces 
///        Rules's current content.</param>
public void setAllRules(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aRules = coll;
    NotifyControllers(null);
  }
public void setAllRules(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aRules = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Rules</summary>
/// <param name="el">a Rule to add to the collection in 
///           Rules</param>
/// <seealso cref="appendRules(ICollection)"/>
public void appendRules(Rule el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allRules().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendRules(Lock aLock,Rule el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allRules().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Rules</summary>
/// <param name="coll">a collection ofRules to add to the collection in 
///           Rules</param>
/// <seealso cref="appendRules(Rule)"/>
public void appendRules(ICollection coll)
  {
  __setDirty(true);
  allRules().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendRules(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allRules().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Rules
/// This insertion function inserts a new element in the
/// collection in Rules</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertRules(int idx, Rule el)
  {
  __setDirty(true);
  allRules().Insert (idx, el);
NotifyControllers(null);
  }

public void insertRules(int idx, Rule el,Lock aLock)
  {
  __setDirty(true);
  allRules().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Rules
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfRules(IXmlBBase el)
  {
  return allRules().IndexOf (el);
  }

/// <summary>Part of the list interface for Rules
/// This deletion function removes an element from the
/// collection in Rules</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteRules(int idx)
  {
  __setDirty(true);
  allRules().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteRules(int idx,Lock aLock)
  {
  __setDirty(true);
  allRules().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Rules
/// This deletion function removes an element from the
/// collection in Rules
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeRules(IXmlBBase obj)
  {
  int idx = indexOfRules(obj);
  if (idx >= 0) { deleteRules(idx);
NotifyControllers(null);
   }
  }

public void removeRules(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfRules(obj);
  if (idx >= 0) { deleteRules(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Rules</summary>
/// <returns>the number of elements in Rules</returns>
public int countRules()
  {
  return allRules().Count;
  }

/// <summary>Part of the list interface for Rules
/// This function returns an element from the
/// collection in Rules based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Rule getRules(int idx)
{
  return (Rule) ( allRules()[idx]);
}

private System.Collections.ArrayList aParameters;

/// <summary>Part of the list interface for Parameters</summary>
/// <returns>a collection of all the elements in Parameters</returns>
public System.Collections.ArrayList allParameters()
  {
if (aParameters == null){
    setAllParameters( new System.Collections.ArrayList() );
} // If
    return aParameters;
  }

/// <summary>Part of the list interface for Parameters</summary>
/// <returns>a collection of all the elements in Parameters</returns>
private System.Collections.ArrayList getParameters()
  {
    return allParameters();
  }

/// <summary>Part of the list interface for Parameters</summary>
/// <param name="coll">a collection of elements which replaces 
///        Parameters's current content.</param>
public void setAllParameters(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aParameters = coll;
    NotifyControllers(null);
  }
public void setAllParameters(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aParameters = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Parameters</summary>
/// <param name="el">a Parameter to add to the collection in 
///           Parameters</param>
/// <seealso cref="appendParameters(ICollection)"/>
public void appendParameters(Parameter el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allParameters().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendParameters(Lock aLock,Parameter el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allParameters().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Parameters</summary>
/// <param name="coll">a collection ofParameters to add to the collection in 
///           Parameters</param>
/// <seealso cref="appendParameters(Parameter)"/>
public void appendParameters(ICollection coll)
  {
  __setDirty(true);
  allParameters().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendParameters(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allParameters().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Parameters
/// This insertion function inserts a new element in the
/// collection in Parameters</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertParameters(int idx, Parameter el)
  {
  __setDirty(true);
  allParameters().Insert (idx, el);
NotifyControllers(null);
  }

public void insertParameters(int idx, Parameter el,Lock aLock)
  {
  __setDirty(true);
  allParameters().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Parameters
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfParameters(IXmlBBase el)
  {
  return allParameters().IndexOf (el);
  }

/// <summary>Part of the list interface for Parameters
/// This deletion function removes an element from the
/// collection in Parameters</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteParameters(int idx)
  {
  __setDirty(true);
  allParameters().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteParameters(int idx,Lock aLock)
  {
  __setDirty(true);
  allParameters().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Parameters
/// This deletion function removes an element from the
/// collection in Parameters
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeParameters(IXmlBBase obj)
  {
  int idx = indexOfParameters(obj);
  if (idx >= 0) { deleteParameters(idx);
NotifyControllers(null);
   }
  }

public void removeParameters(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfParameters(obj);
  if (idx >= 0) { deleteParameters(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Parameters</summary>
/// <returns>the number of elements in Parameters</returns>
public int countParameters()
  {
  return allParameters().Count;
  }

/// <summary>Part of the list interface for Parameters
/// This function returns an element from the
/// collection in Parameters based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Parameter getParameters(int idx)
{
  return (Parameter) ( allParameters()[idx]);
}

public Procedure()
{
Procedure obj = this;
aStateMachine=(null);
aRules=(null);
aParameters=(null);
}

public void copyTo(Procedure other)
{
base.copyTo(other);
other.aStateMachine = aStateMachine;
other.aRules = aRules;
other.aParameters = aParameters;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
bool fl637;
Parameter fl639;
bool fl650;
Rule fl652;

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Parameters")){
ctxt.skipWhiteSpace();
fl637 = true ; 
while (fl637) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl637 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl639 = null;
while(ctxt.lookAheadOpeningTag ("<Parameter")) {
fl639 = acceptor.lAccept_Parameter(ctxt, "</Parameter>");
appendParameters(fl639);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Parameters>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Rules")){
ctxt.skipWhiteSpace();
fl650 = true ; 
while (fl650) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl650 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl652 = null;
while(ctxt.lookAheadOpeningTag ("<Rule")) {
fl652 = acceptor.lAccept_Rule(ctxt, "</Rule>");
appendRules(fl652);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Rules>");
} // If
} // If
// End enclosed
// Element Ref : StateMachine
ctxt.skipWhiteSpace();
// If optional...
if (ctxt.lookAheadOpeningTag("<StateMachine")){
// Parsing sub element
this.setStateMachine(acceptor.lAccept_StateMachine(ctxt,"</StateMachine>"));
setSon(this.getStateMachine());
// Endif optional...
} // If
ctxt.skipWhiteSpace();
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl663;
bool fl664;
bool fl665;
bool fl666;
bool fl667;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl663 = false ; 
fl664 = false ; 
fl665 = false ; 
fl666 = false ; 
fl667 = true ; 
while (fl667) { // BeginLoop 
switch (ctxt.current()) {
case 'V':
{
ctxt.advance();
if (ctxt.lookAheadString("erified=")){
indicator = 664;
} else {
indicator = 668;
} // If
break;
} // Case
case 'N':
{
ctxt.advance();
switch (ctxt.current()) {
case 'e':
{
ctxt.advance();
if (ctxt.lookAheadString("edsRequirement=")){
indicator = 665;
} else {
indicator = 668;
} // If
break;
} // Case
case 'a':
{
ctxt.advance();
if (ctxt.lookAhead3('m','e','=')){
indicator = 666;
} else {
indicator = 668;
} // If
break;
} // Case
default:
indicator = 668;
break;
} // Switch
break;
} // Case
case 'I':
{
ctxt.advance();
if (ctxt.lookAheadString("mplemented=")){
indicator = 663;
} else {
indicator = 668;
} // If
break;
} // Case
default:
indicator = 668;
break;
} // Switch
switch (indicator) {
case 663: {
// Handling attribute Implemented
// Also handles alien attributes with prefix Implemented
if (fl663){
ctxt.fail ("Duplicate attribute: Implemented");
} // If
fl663 = true ; 
quoteChar = ctxt.acceptQuote();
this.setImplemented(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 664: {
// Handling attribute Verified
// Also handles alien attributes with prefix Verified
if (fl664){
ctxt.fail ("Duplicate attribute: Verified");
} // If
fl664 = true ; 
quoteChar = ctxt.acceptQuote();
this.setVerified(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 665: {
// Handling attribute NeedsRequirement
// Also handles alien attributes with prefix NeedsRequirement
if (fl665){
ctxt.fail ("Duplicate attribute: NeedsRequirement");
} // If
fl665 = true ; 
quoteChar = ctxt.acceptQuote();
this.setNeedsRequirement(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 666: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl666){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl666 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 668: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl663){
this.setImplemented( false);
} // If
if (!fl664){
this.setVerified( false);
} // If
if (!fl665){
this.setNeedsRequirement( true);
} // If
fl667 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<Procedure";
  endingTag = "</Procedure>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"Procedure\"");
} // If
pw.Write('\n');
if (this.getImplemented()){
pw.Write(" Implemented=\"");
acceptor.unParsePcData(pw, this.getImplemented());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getVerified()){
pw.Write(" Verified=\"");
acceptor.unParsePcData(pw, this.getVerified());
pw.Write('"');
pw.Write('\n');
} // If
if (!this.getNeedsRequirement()){
pw.Write(" NeedsRequirement=\"");
acceptor.unParsePcData(pw, this.getNeedsRequirement());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing Enclosed
// Testing for empty content: Parameters
if (countParameters() > 0){
pw.Write("<Parameters>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getParameters(), false, "<Parameter", "</Parameter>");
pw.Write("</Parameters>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Parameters
// Unparsing Enclosed
// Testing for empty content: Rules
if (countRules() > 0){
pw.Write("<Rules>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getRules(), false, "<Rule", "</Rule>");
pw.Write("</Rules>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Rules
// Unparsing ElementRef
if (this.getStateMachine() != null){
unParse(pw, this.getStateMachine(),false,"<StateMachine","</StateMachine>");
} // If
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
l.Add(this.getStateMachine());
for (int i = 0; i < countRules(); i++) {
  l.Add(getRules(i));
}
for (int i = 0; i < countParameters(); i++) {
  l.Add(getParameters(i));
}
}

}
public partial class StateMachine
: DataDictionary.Types.Type
{
public  override  bool find(Object search){
if (search is String ) {
if(getInitialState().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.StateMachineController.alertChange(aLock, this);
}
private   string  aInitialState;

public   string  getInitialState() { return aInitialState;}
public  void setInitialState( string  v) {
  aInitialState = v;
  __setDirty(true);
  NotifyControllers(null);
}

private System.Collections.ArrayList aStates;

/// <summary>Part of the list interface for States</summary>
/// <returns>a collection of all the elements in States</returns>
public System.Collections.ArrayList allStates()
  {
if (aStates == null){
    setAllStates( new System.Collections.ArrayList() );
} // If
    return aStates;
  }

/// <summary>Part of the list interface for States</summary>
/// <returns>a collection of all the elements in States</returns>
private System.Collections.ArrayList getStates()
  {
    return allStates();
  }

/// <summary>Part of the list interface for States</summary>
/// <param name="coll">a collection of elements which replaces 
///        States's current content.</param>
public void setAllStates(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aStates = coll;
    NotifyControllers(null);
  }
public void setAllStates(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aStates = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for States</summary>
/// <param name="el">a State to add to the collection in 
///           States</param>
/// <seealso cref="appendStates(ICollection)"/>
public void appendStates(State el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allStates().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendStates(Lock aLock,State el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allStates().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for States</summary>
/// <param name="coll">a collection ofStates to add to the collection in 
///           States</param>
/// <seealso cref="appendStates(State)"/>
public void appendStates(ICollection coll)
  {
  __setDirty(true);
  allStates().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendStates(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allStates().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for States
/// This insertion function inserts a new element in the
/// collection in States</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertStates(int idx, State el)
  {
  __setDirty(true);
  allStates().Insert (idx, el);
NotifyControllers(null);
  }

public void insertStates(int idx, State el,Lock aLock)
  {
  __setDirty(true);
  allStates().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for States
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfStates(IXmlBBase el)
  {
  return allStates().IndexOf (el);
  }

/// <summary>Part of the list interface for States
/// This deletion function removes an element from the
/// collection in States</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteStates(int idx)
  {
  __setDirty(true);
  allStates().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteStates(int idx,Lock aLock)
  {
  __setDirty(true);
  allStates().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for States
/// This deletion function removes an element from the
/// collection in States
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeStates(IXmlBBase obj)
  {
  int idx = indexOfStates(obj);
  if (idx >= 0) { deleteStates(idx);
NotifyControllers(null);
   }
  }

public void removeStates(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfStates(obj);
  if (idx >= 0) { deleteStates(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for States</summary>
/// <returns>the number of elements in States</returns>
public int countStates()
  {
  return allStates().Count;
  }

/// <summary>Part of the list interface for States
/// This function returns an element from the
/// collection in States based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public State getStates(int idx)
{
  return (State) ( allStates()[idx]);
}

private System.Collections.ArrayList aRules;

/// <summary>Part of the list interface for Rules</summary>
/// <returns>a collection of all the elements in Rules</returns>
public System.Collections.ArrayList allRules()
  {
if (aRules == null){
    setAllRules( new System.Collections.ArrayList() );
} // If
    return aRules;
  }

/// <summary>Part of the list interface for Rules</summary>
/// <returns>a collection of all the elements in Rules</returns>
private System.Collections.ArrayList getRules()
  {
    return allRules();
  }

/// <summary>Part of the list interface for Rules</summary>
/// <param name="coll">a collection of elements which replaces 
///        Rules's current content.</param>
public void setAllRules(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aRules = coll;
    NotifyControllers(null);
  }
public void setAllRules(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aRules = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Rules</summary>
/// <param name="el">a Rule to add to the collection in 
///           Rules</param>
/// <seealso cref="appendRules(ICollection)"/>
public void appendRules(Rule el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allRules().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendRules(Lock aLock,Rule el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allRules().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Rules</summary>
/// <param name="coll">a collection ofRules to add to the collection in 
///           Rules</param>
/// <seealso cref="appendRules(Rule)"/>
public void appendRules(ICollection coll)
  {
  __setDirty(true);
  allRules().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendRules(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allRules().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Rules
/// This insertion function inserts a new element in the
/// collection in Rules</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertRules(int idx, Rule el)
  {
  __setDirty(true);
  allRules().Insert (idx, el);
NotifyControllers(null);
  }

public void insertRules(int idx, Rule el,Lock aLock)
  {
  __setDirty(true);
  allRules().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Rules
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfRules(IXmlBBase el)
  {
  return allRules().IndexOf (el);
  }

/// <summary>Part of the list interface for Rules
/// This deletion function removes an element from the
/// collection in Rules</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteRules(int idx)
  {
  __setDirty(true);
  allRules().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteRules(int idx,Lock aLock)
  {
  __setDirty(true);
  allRules().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Rules
/// This deletion function removes an element from the
/// collection in Rules
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeRules(IXmlBBase obj)
  {
  int idx = indexOfRules(obj);
  if (idx >= 0) { deleteRules(idx);
NotifyControllers(null);
   }
  }

public void removeRules(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfRules(obj);
  if (idx >= 0) { deleteRules(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Rules</summary>
/// <returns>the number of elements in Rules</returns>
public int countRules()
  {
  return allRules().Count;
  }

/// <summary>Part of the list interface for Rules
/// This function returns an element from the
/// collection in Rules based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Rule getRules(int idx)
{
  return (Rule) ( allRules()[idx]);
}

public StateMachine()
{
StateMachine obj = this;
aInitialState=(null);
aStates=(null);
aRules=(null);
}

public void copyTo(StateMachine other)
{
base.copyTo(other);
other.aInitialState = aInitialState;
other.aStates = aStates;
other.aRules = aRules;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
bool fl675;
State fl677;
bool fl688;
Rule fl690;

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<States")){
ctxt.skipWhiteSpace();
fl675 = true ; 
while (fl675) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl675 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl677 = null;
while(ctxt.lookAheadOpeningTag ("<State")) {
fl677 = acceptor.lAccept_State(ctxt, "</State>");
appendStates(fl677);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</States>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Rules")){
ctxt.skipWhiteSpace();
fl688 = true ; 
while (fl688) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl688 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl690 = null;
while(ctxt.lookAheadOpeningTag ("<Rule")) {
fl690 = acceptor.lAccept_Rule(ctxt, "</Rule>");
appendRules(fl690);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Rules>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl701;
bool fl702;
bool fl703;
bool fl704;
bool fl705;
bool fl706;
bool fl707;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl701 = false ; 
fl702 = false ; 
fl703 = false ; 
fl704 = false ; 
fl705 = false ; 
fl706 = false ; 
fl707 = true ; 
while (fl707) { // BeginLoop 
switch (ctxt.current()) {
case 'V':
{
ctxt.advance();
if (ctxt.lookAheadString("erified=")){
indicator = 704;
} else {
indicator = 708;
} // If
break;
} // Case
case 'N':
{
ctxt.advance();
switch (ctxt.current()) {
case 'e':
{
ctxt.advance();
if (ctxt.lookAheadString("edsRequirement=")){
indicator = 705;
} else {
indicator = 708;
} // If
break;
} // Case
case 'a':
{
ctxt.advance();
if (ctxt.lookAhead3('m','e','=')){
indicator = 706;
} else {
indicator = 708;
} // If
break;
} // Case
default:
indicator = 708;
break;
} // Switch
break;
} // Case
case 'I':
{
ctxt.advance();
switch (ctxt.current()) {
case 'n':
{
ctxt.advance();
if (ctxt.lookAheadString("itialState=")){
indicator = 701;
} else {
indicator = 708;
} // If
break;
} // Case
case 'm':
{
ctxt.advance();
if (ctxt.lookAheadString("plemented=")){
indicator = 703;
} else {
indicator = 708;
} // If
break;
} // Case
default:
indicator = 708;
break;
} // Switch
break;
} // Case
case 'D':
{
ctxt.advance();
if (ctxt.lookAheadString("efault=")){
indicator = 702;
} else {
indicator = 708;
} // If
break;
} // Case
default:
indicator = 708;
break;
} // Switch
switch (indicator) {
case 701: {
// Handling attribute InitialState
// Also handles alien attributes with prefix InitialState
if (fl701){
ctxt.fail ("Duplicate attribute: InitialState");
} // If
fl701 = true ; 
quoteChar = ctxt.acceptQuote();
this.setInitialState((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 702: {
// Handling attribute Default
// Also handles alien attributes with prefix Default
if (fl702){
ctxt.fail ("Duplicate attribute: Default");
} // If
fl702 = true ; 
quoteChar = ctxt.acceptQuote();
this.setDefault((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 703: {
// Handling attribute Implemented
// Also handles alien attributes with prefix Implemented
if (fl703){
ctxt.fail ("Duplicate attribute: Implemented");
} // If
fl703 = true ; 
quoteChar = ctxt.acceptQuote();
this.setImplemented(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 704: {
// Handling attribute Verified
// Also handles alien attributes with prefix Verified
if (fl704){
ctxt.fail ("Duplicate attribute: Verified");
} // If
fl704 = true ; 
quoteChar = ctxt.acceptQuote();
this.setVerified(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 705: {
// Handling attribute NeedsRequirement
// Also handles alien attributes with prefix NeedsRequirement
if (fl705){
ctxt.fail ("Duplicate attribute: NeedsRequirement");
} // If
fl705 = true ; 
quoteChar = ctxt.acceptQuote();
this.setNeedsRequirement(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 706: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl706){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl706 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 708: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl701){
ctxt.fail ("Mandatory attribute missing: InitialState in StateMachine");
} // If
if (!fl703){
this.setImplemented( false);
} // If
if (!fl704){
this.setVerified( false);
} // If
if (!fl705){
this.setNeedsRequirement( true);
} // If
fl707 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<StateMachine";
  endingTag = "</StateMachine>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"StateMachine\"");
} // If
pw.Write('\n');
pw.Write(" InitialState=\"");
acceptor.unParsePcData(pw, this.getInitialState());
pw.Write('"');
pw.Write('\n');
if (this.getDefault() != null){
pw.Write(" Default=\"");
acceptor.unParsePcData(pw, this.getDefault());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getImplemented()){
pw.Write(" Implemented=\"");
acceptor.unParsePcData(pw, this.getImplemented());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getVerified()){
pw.Write(" Verified=\"");
acceptor.unParsePcData(pw, this.getVerified());
pw.Write('"');
pw.Write('\n');
} // If
if (!this.getNeedsRequirement()){
pw.Write(" NeedsRequirement=\"");
acceptor.unParsePcData(pw, this.getNeedsRequirement());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing Enclosed
// Testing for empty content: States
if (countStates() > 0){
pw.Write("<States>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getStates(), false, "<State", "</State>");
pw.Write("</States>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: States
// Unparsing Enclosed
// Testing for empty content: Rules
if (countRules() > 0){
pw.Write("<Rules>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getRules(), false, "<Rule", "</Rule>");
pw.Write("</Rules>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Rules
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
for (int i = 0; i < countStates(); i++) {
  l.Add(getStates(i));
}
for (int i = 0; i < countRules(); i++) {
  l.Add(getRules(i));
}
}

}
public partial class State
: DataDictionary.ReqRelated
{
public  override  bool find(Object search){
if (search is String ) {
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.StateController.alertChange(aLock, this);
}
private  StateMachine aStateMachine;

public  StateMachine getStateMachine() { return aStateMachine;}
public  void setStateMachine(StateMachine v) {
  aStateMachine = v;
  if ( v != null ) { 
    v.setFather(this);
  }
  __setDirty(true);
  NotifyControllers(null);
}

private  int aWidth;

public  int getWidth() { return aWidth;}
public  void setWidth(int v) {
  aWidth = v;
  __setDirty(true);
  NotifyControllers(null);
}

private  int aHeight;

public  int getHeight() { return aHeight;}
public  void setHeight(int v) {
  aHeight = v;
  __setDirty(true);
  NotifyControllers(null);
}

private  int aX;

public  int getX() { return aX;}
public  void setX(int v) {
  aX = v;
  __setDirty(true);
  NotifyControllers(null);
}

private  int aY;

public  int getY() { return aY;}
public  void setY(int v) {
  aY = v;
  __setDirty(true);
  NotifyControllers(null);
}

public State()
{
State obj = this;
aStateMachine=(null);
aWidth=(0);
aHeight=(0);
aX=(0);
aY=(0);
}

public void copyTo(State other)
{
base.copyTo(other);
other.aStateMachine = aStateMachine;
other.aWidth = aWidth;
other.aHeight = aHeight;
other.aX = aX;
other.aY = aY;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
// Element Ref : StateMachine
ctxt.skipWhiteSpace();
// If optional...
if (ctxt.lookAheadOpeningTag("<StateMachine")){
// Parsing sub element
this.setStateMachine(acceptor.lAccept_StateMachine(ctxt,"</StateMachine>"));
setSon(this.getStateMachine());
// Endif optional...
} // If
ctxt.skipWhiteSpace();
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl718;
bool fl719;
bool fl720;
bool fl721;
bool fl722;
bool fl723;
bool fl724;
bool fl725;
bool fl726;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl718 = false ; 
fl719 = false ; 
fl720 = false ; 
fl721 = false ; 
fl722 = false ; 
fl723 = false ; 
fl724 = false ; 
fl725 = false ; 
fl726 = true ; 
while (fl726) { // BeginLoop 
switch (ctxt.current()) {
case 'Y':
{
ctxt.advance();
if (ctxt.lookAhead1('=')){
indicator = 719;
} else {
indicator = 727;
} // If
break;
} // Case
case 'X':
{
ctxt.advance();
if (ctxt.lookAhead1('=')){
indicator = 718;
} else {
indicator = 727;
} // If
break;
} // Case
case 'W':
{
ctxt.advance();
if (ctxt.lookAheadString("idth=")){
indicator = 720;
} else {
indicator = 727;
} // If
break;
} // Case
case 'V':
{
ctxt.advance();
if (ctxt.lookAheadString("erified=")){
indicator = 723;
} else {
indicator = 727;
} // If
break;
} // Case
case 'N':
{
ctxt.advance();
switch (ctxt.current()) {
case 'e':
{
ctxt.advance();
if (ctxt.lookAheadString("edsRequirement=")){
indicator = 724;
} else {
indicator = 727;
} // If
break;
} // Case
case 'a':
{
ctxt.advance();
if (ctxt.lookAhead3('m','e','=')){
indicator = 725;
} else {
indicator = 727;
} // If
break;
} // Case
default:
indicator = 727;
break;
} // Switch
break;
} // Case
case 'I':
{
ctxt.advance();
if (ctxt.lookAheadString("mplemented=")){
indicator = 722;
} else {
indicator = 727;
} // If
break;
} // Case
case 'H':
{
ctxt.advance();
if (ctxt.lookAheadString("eight=")){
indicator = 721;
} else {
indicator = 727;
} // If
break;
} // Case
default:
indicator = 727;
break;
} // Switch
switch (indicator) {
case 718: {
// Handling attribute X
// Also handles alien attributes with prefix X
if (fl718){
ctxt.fail ("Duplicate attribute: X");
} // If
fl718 = true ; 
quoteChar = ctxt.acceptQuote();
this.setX(ctxt.fetchInteger());
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 719: {
// Handling attribute Y
// Also handles alien attributes with prefix Y
if (fl719){
ctxt.fail ("Duplicate attribute: Y");
} // If
fl719 = true ; 
quoteChar = ctxt.acceptQuote();
this.setY(ctxt.fetchInteger());
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 720: {
// Handling attribute Width
// Also handles alien attributes with prefix Width
if (fl720){
ctxt.fail ("Duplicate attribute: Width");
} // If
fl720 = true ; 
quoteChar = ctxt.acceptQuote();
this.setWidth(ctxt.fetchInteger());
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 721: {
// Handling attribute Height
// Also handles alien attributes with prefix Height
if (fl721){
ctxt.fail ("Duplicate attribute: Height");
} // If
fl721 = true ; 
quoteChar = ctxt.acceptQuote();
this.setHeight(ctxt.fetchInteger());
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 722: {
// Handling attribute Implemented
// Also handles alien attributes with prefix Implemented
if (fl722){
ctxt.fail ("Duplicate attribute: Implemented");
} // If
fl722 = true ; 
quoteChar = ctxt.acceptQuote();
this.setImplemented(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 723: {
// Handling attribute Verified
// Also handles alien attributes with prefix Verified
if (fl723){
ctxt.fail ("Duplicate attribute: Verified");
} // If
fl723 = true ; 
quoteChar = ctxt.acceptQuote();
this.setVerified(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 724: {
// Handling attribute NeedsRequirement
// Also handles alien attributes with prefix NeedsRequirement
if (fl724){
ctxt.fail ("Duplicate attribute: NeedsRequirement");
} // If
fl724 = true ; 
quoteChar = ctxt.acceptQuote();
this.setNeedsRequirement(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 725: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl725){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl725 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 727: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl718){
this.setX(0);
} // If
if (!fl719){
this.setY(0);
} // If
if (!fl720){
this.setWidth(0);
} // If
if (!fl721){
this.setHeight(0);
} // If
if (!fl722){
this.setImplemented( false);
} // If
if (!fl723){
this.setVerified( false);
} // If
if (!fl724){
this.setNeedsRequirement( true);
} // If
fl726 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<State";
  endingTag = "</State>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"State\"");
} // If
pw.Write('\n');
if (this.getX() != 0){
pw.Write(" X=\"");
acceptor.unParsePcData(pw, this.getX());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getY() != 0){
pw.Write(" Y=\"");
acceptor.unParsePcData(pw, this.getY());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getWidth() != 0){
pw.Write(" Width=\"");
acceptor.unParsePcData(pw, this.getWidth());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getHeight() != 0){
pw.Write(" Height=\"");
acceptor.unParsePcData(pw, this.getHeight());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getImplemented()){
pw.Write(" Implemented=\"");
acceptor.unParsePcData(pw, this.getImplemented());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getVerified()){
pw.Write(" Verified=\"");
acceptor.unParsePcData(pw, this.getVerified());
pw.Write('"');
pw.Write('\n');
} // If
if (!this.getNeedsRequirement()){
pw.Write(" NeedsRequirement=\"");
acceptor.unParsePcData(pw, this.getNeedsRequirement());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing ElementRef
if (this.getStateMachine() != null){
unParse(pw, this.getStateMachine(),false,"<StateMachine","</StateMachine>");
} // If
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
l.Add(this.getStateMachine());
}

}
public partial class Variable
: DataDictionary.ReqRelated
{
public  override  bool find(Object search){
if (search is String ) {
if(getTypeName().CompareTo((String) search) == 0)return true;
if(getDefaultValue().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.VariableController.alertChange(aLock, this);
}
private   string  aTypeName;

public   string  getTypeName() { return aTypeName;}
public  void setTypeName( string  v) {
  aTypeName = v;
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aDefaultValue;

public   string  getDefaultValue() { return aDefaultValue;}
public  void setDefaultValue( string  v) {
  aDefaultValue = v;
  __setDirty(true);
  NotifyControllers(null);
}

private  acceptor.VariableModeEnumType aVariableMode;

public  acceptor.VariableModeEnumType getVariableMode() { return aVariableMode;}
public  void setVariableMode(acceptor.VariableModeEnumType v) {
  aVariableMode = v;
  __setDirty(true);
  NotifyControllers(null);
}

public  string   getVariableMode_AsString()
{
  return acceptor.Enum_VariableModeEnumType_ToString (aVariableMode);
}

public  bool setVariableMode_AsString( string  v)
{
 acceptor.VariableModeEnumType  temp = acceptor.StringTo_Enum_VariableModeEnumType(v);
if (temp >= 0){
  aVariableMode = temp;
  __setDirty(true);
  NotifyControllers(null);
  return true;
} // If
return false;
}

private System.Collections.ArrayList aSubVariables;

/// <summary>Part of the list interface for SubVariables</summary>
/// <returns>a collection of all the elements in SubVariables</returns>
public System.Collections.ArrayList allSubVariables()
  {
if (aSubVariables == null){
    setAllSubVariables( new System.Collections.ArrayList() );
} // If
    return aSubVariables;
  }

/// <summary>Part of the list interface for SubVariables</summary>
/// <returns>a collection of all the elements in SubVariables</returns>
private System.Collections.ArrayList getSubVariables()
  {
    return allSubVariables();
  }

/// <summary>Part of the list interface for SubVariables</summary>
/// <param name="coll">a collection of elements which replaces 
///        SubVariables's current content.</param>
public void setAllSubVariables(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aSubVariables = coll;
    NotifyControllers(null);
  }
public void setAllSubVariables(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aSubVariables = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SubVariables</summary>
/// <param name="el">a Variable to add to the collection in 
///           SubVariables</param>
/// <seealso cref="appendSubVariables(ICollection)"/>
public void appendSubVariables(Variable el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allSubVariables().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendSubVariables(Lock aLock,Variable el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allSubVariables().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for SubVariables</summary>
/// <param name="coll">a collection ofVariables to add to the collection in 
///           SubVariables</param>
/// <seealso cref="appendSubVariables(Variable)"/>
public void appendSubVariables(ICollection coll)
  {
  __setDirty(true);
  allSubVariables().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendSubVariables(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allSubVariables().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SubVariables
/// This insertion function inserts a new element in the
/// collection in SubVariables</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertSubVariables(int idx, Variable el)
  {
  __setDirty(true);
  allSubVariables().Insert (idx, el);
NotifyControllers(null);
  }

public void insertSubVariables(int idx, Variable el,Lock aLock)
  {
  __setDirty(true);
  allSubVariables().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SubVariables
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfSubVariables(IXmlBBase el)
  {
  return allSubVariables().IndexOf (el);
  }

/// <summary>Part of the list interface for SubVariables
/// This deletion function removes an element from the
/// collection in SubVariables</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteSubVariables(int idx)
  {
  __setDirty(true);
  allSubVariables().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteSubVariables(int idx,Lock aLock)
  {
  __setDirty(true);
  allSubVariables().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SubVariables
/// This deletion function removes an element from the
/// collection in SubVariables
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeSubVariables(IXmlBBase obj)
  {
  int idx = indexOfSubVariables(obj);
  if (idx >= 0) { deleteSubVariables(idx);
NotifyControllers(null);
   }
  }

public void removeSubVariables(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfSubVariables(obj);
  if (idx >= 0) { deleteSubVariables(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for SubVariables</summary>
/// <returns>the number of elements in SubVariables</returns>
public int countSubVariables()
  {
  return allSubVariables().Count;
  }

/// <summary>Part of the list interface for SubVariables
/// This function returns an element from the
/// collection in SubVariables based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Variable getSubVariables(int idx)
{
  return (Variable) ( allSubVariables()[idx]);
}

public Variable()
{
Variable obj = this;
aTypeName=(null);
aDefaultValue=(null);
aVariableMode=(0);
aSubVariables=(null);
}

public void copyTo(Variable other)
{
base.copyTo(other);
other.aTypeName = aTypeName;
other.aDefaultValue = aDefaultValue;
other.aVariableMode = aVariableMode;
other.aSubVariables = aSubVariables;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
bool fl738;
Variable fl740;

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<SubVariables")){
ctxt.skipWhiteSpace();
fl738 = true ; 
while (fl738) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl738 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl740 = null;
while(ctxt.lookAheadOpeningTag ("<Variable")) {
fl740 = acceptor.lAccept_Variable(ctxt, "</Variable>");
appendSubVariables(fl740);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</SubVariables>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl751;
bool fl752;
bool fl753;
bool fl754;
bool fl755;
bool fl756;
bool fl757;
bool fl758;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl751 = false ; 
fl752 = false ; 
fl753 = false ; 
fl754 = false ; 
fl755 = false ; 
fl756 = false ; 
fl757 = false ; 
fl758 = true ; 
while (fl758) { // BeginLoop 
switch (ctxt.current()) {
case 'V':
{
ctxt.advance();
switch (ctxt.current()) {
case 'e':
{
ctxt.advance();
if (ctxt.lookAheadString("rified=")){
indicator = 755;
} else {
indicator = 759;
} // If
break;
} // Case
case 'a':
{
ctxt.advance();
if (ctxt.lookAheadString("riableMode=")){
indicator = 753;
} else {
indicator = 759;
} // If
break;
} // Case
default:
indicator = 759;
break;
} // Switch
break;
} // Case
case 'T':
{
ctxt.advance();
if (ctxt.lookAheadString("ype=")){
indicator = 751;
} else {
indicator = 759;
} // If
break;
} // Case
case 'N':
{
ctxt.advance();
switch (ctxt.current()) {
case 'e':
{
ctxt.advance();
if (ctxt.lookAheadString("edsRequirement=")){
indicator = 756;
} else {
indicator = 759;
} // If
break;
} // Case
case 'a':
{
ctxt.advance();
if (ctxt.lookAhead3('m','e','=')){
indicator = 757;
} else {
indicator = 759;
} // If
break;
} // Case
default:
indicator = 759;
break;
} // Switch
break;
} // Case
case 'I':
{
ctxt.advance();
if (ctxt.lookAheadString("mplemented=")){
indicator = 754;
} else {
indicator = 759;
} // If
break;
} // Case
case 'D':
{
ctxt.advance();
if (ctxt.lookAheadString("efaultValue=")){
indicator = 752;
} else {
indicator = 759;
} // If
break;
} // Case
default:
indicator = 759;
break;
} // Switch
switch (indicator) {
case 751: {
// Handling attribute Type
// Also handles alien attributes with prefix Type
if (fl751){
ctxt.fail ("Duplicate attribute: Type");
} // If
fl751 = true ; 
quoteChar = ctxt.acceptQuote();
this.setTypeName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 752: {
// Handling attribute DefaultValue
// Also handles alien attributes with prefix DefaultValue
if (fl752){
ctxt.fail ("Duplicate attribute: DefaultValue");
} // If
fl752 = true ; 
quoteChar = ctxt.acceptQuote();
this.setDefaultValue((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 753: {
// Handling attribute VariableMode
// Also handles alien attributes with prefix VariableMode
if (fl753){
ctxt.fail ("Duplicate attribute: VariableMode");
} // If
fl753 = true ; 
quoteChar = ctxt.acceptQuote();
this.setVariableMode(acceptor.lAcceptEnum_VariableModeEnumType(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 754: {
// Handling attribute Implemented
// Also handles alien attributes with prefix Implemented
if (fl754){
ctxt.fail ("Duplicate attribute: Implemented");
} // If
fl754 = true ; 
quoteChar = ctxt.acceptQuote();
this.setImplemented(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 755: {
// Handling attribute Verified
// Also handles alien attributes with prefix Verified
if (fl755){
ctxt.fail ("Duplicate attribute: Verified");
} // If
fl755 = true ; 
quoteChar = ctxt.acceptQuote();
this.setVerified(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 756: {
// Handling attribute NeedsRequirement
// Also handles alien attributes with prefix NeedsRequirement
if (fl756){
ctxt.fail ("Duplicate attribute: NeedsRequirement");
} // If
fl756 = true ; 
quoteChar = ctxt.acceptQuote();
this.setNeedsRequirement(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 757: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl757){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl757 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 759: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl753){
this.setVariableMode(acceptor.VariableModeEnumType.aInternal);
} // If
if (!fl754){
this.setImplemented( false);
} // If
if (!fl755){
this.setVerified( false);
} // If
if (!fl756){
this.setNeedsRequirement( true);
} // If
fl758 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<Variable";
  endingTag = "</Variable>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"Variable\"");
} // If
pw.Write('\n');
if (this.getTypeName() != null){
pw.Write(" Type=\"");
acceptor.unParsePcData(pw, this.getTypeName());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getDefaultValue() != null){
pw.Write(" DefaultValue=\"");
acceptor.unParsePcData(pw, this.getDefaultValue());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getVariableMode() != 0){
pw.Write(" VariableMode=\"");
acceptor.unParsePcData(pw,
  acceptor.Enum_VariableModeEnumType_ToString(this.getVariableMode()));
pw.Write('"');
pw.Write('\n');
} // If
if (this.getImplemented()){
pw.Write(" Implemented=\"");
acceptor.unParsePcData(pw, this.getImplemented());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getVerified()){
pw.Write(" Verified=\"");
acceptor.unParsePcData(pw, this.getVerified());
pw.Write('"');
pw.Write('\n');
} // If
if (!this.getNeedsRequirement()){
pw.Write(" NeedsRequirement=\"");
acceptor.unParsePcData(pw, this.getNeedsRequirement());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing Enclosed
// Testing for empty content: SubVariables
if (countSubVariables() > 0){
pw.Write("<SubVariables>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getSubVariables(), false, "<Variable", "</Variable>");
pw.Write("</SubVariables>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: SubVariables
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
for (int i = 0; i < countSubVariables(); i++) {
  l.Add(getSubVariables(i));
}
}

}
public partial class Rule
: DataDictionary.ReqRelated
{
public  override  bool find(Object search){
if (search is String ) {
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.RuleController.alertChange(aLock, this);
}
private  acceptor.RulePriority aPriority;

public  acceptor.RulePriority getPriority() { return aPriority;}
public  void setPriority(acceptor.RulePriority v) {
  aPriority = v;
  __setDirty(true);
  NotifyControllers(null);
}

public  string   getPriority_AsString()
{
  return acceptor.Enum_RulePriority_ToString (aPriority);
}

public  bool setPriority_AsString( string  v)
{
 acceptor.RulePriority  temp = acceptor.StringTo_Enum_RulePriority(v);
if (temp >= 0){
  aPriority = temp;
  __setDirty(true);
  NotifyControllers(null);
  return true;
} // If
return false;
}

private System.Collections.ArrayList aConditions;

/// <summary>Part of the list interface for Conditions</summary>
/// <returns>a collection of all the elements in Conditions</returns>
public System.Collections.ArrayList allConditions()
  {
if (aConditions == null){
    setAllConditions( new System.Collections.ArrayList() );
} // If
    return aConditions;
  }

/// <summary>Part of the list interface for Conditions</summary>
/// <returns>a collection of all the elements in Conditions</returns>
private System.Collections.ArrayList getConditions()
  {
    return allConditions();
  }

/// <summary>Part of the list interface for Conditions</summary>
/// <param name="coll">a collection of elements which replaces 
///        Conditions's current content.</param>
public void setAllConditions(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aConditions = coll;
    NotifyControllers(null);
  }
public void setAllConditions(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aConditions = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Conditions</summary>
/// <param name="el">a RuleCondition to add to the collection in 
///           Conditions</param>
/// <seealso cref="appendConditions(ICollection)"/>
public void appendConditions(RuleCondition el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allConditions().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendConditions(Lock aLock,RuleCondition el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allConditions().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Conditions</summary>
/// <param name="coll">a collection ofRuleConditions to add to the collection in 
///           Conditions</param>
/// <seealso cref="appendConditions(RuleCondition)"/>
public void appendConditions(ICollection coll)
  {
  __setDirty(true);
  allConditions().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendConditions(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allConditions().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Conditions
/// This insertion function inserts a new element in the
/// collection in Conditions</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertConditions(int idx, RuleCondition el)
  {
  __setDirty(true);
  allConditions().Insert (idx, el);
NotifyControllers(null);
  }

public void insertConditions(int idx, RuleCondition el,Lock aLock)
  {
  __setDirty(true);
  allConditions().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Conditions
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfConditions(IXmlBBase el)
  {
  return allConditions().IndexOf (el);
  }

/// <summary>Part of the list interface for Conditions
/// This deletion function removes an element from the
/// collection in Conditions</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteConditions(int idx)
  {
  __setDirty(true);
  allConditions().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteConditions(int idx,Lock aLock)
  {
  __setDirty(true);
  allConditions().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Conditions
/// This deletion function removes an element from the
/// collection in Conditions
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeConditions(IXmlBBase obj)
  {
  int idx = indexOfConditions(obj);
  if (idx >= 0) { deleteConditions(idx);
NotifyControllers(null);
   }
  }

public void removeConditions(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfConditions(obj);
  if (idx >= 0) { deleteConditions(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Conditions</summary>
/// <returns>the number of elements in Conditions</returns>
public int countConditions()
  {
  return allConditions().Count;
  }

/// <summary>Part of the list interface for Conditions
/// This function returns an element from the
/// collection in Conditions based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public RuleCondition getConditions(int idx)
{
  return (RuleCondition) ( allConditions()[idx]);
}

public Rule()
{
Rule obj = this;
aPriority=(0);
aConditions=(null);
}

public void copyTo(Rule other)
{
base.copyTo(other);
other.aPriority = aPriority;
other.aConditions = aConditions;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
bool fl770;
bool fl771;
RuleCondition fl773;

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<SubRules")){
ctxt.skipWhiteSpace();
fl770 = true ; 
while (fl770) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl770 = false ; 
} // If
} // While
ctxt.accept('>');
// Indicator
// Parse PC data
acceptor.lAcceptPcData(ctxt, 0, '<', XmlBContext.WS_PRESERVE);
// Regexp
ctxt.skipWhiteSpace();
ctxt.acceptString ("</SubRules>");
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Conditions")){
ctxt.skipWhiteSpace();
fl771 = true ; 
while (fl771) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl771 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl773 = null;
while(ctxt.lookAheadOpeningTag ("<RuleCondition")) {
fl773 = acceptor.lAccept_RuleCondition(ctxt, "</RuleCondition>");
appendConditions(fl773);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Conditions>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl784;
bool fl785;
bool fl786;
bool fl787;
bool fl788;
bool fl789;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl784 = false ; 
fl785 = false ; 
fl786 = false ; 
fl787 = false ; 
fl788 = false ; 
fl789 = true ; 
while (fl789) { // BeginLoop 
switch (ctxt.current()) {
case 'V':
{
ctxt.advance();
if (ctxt.lookAheadString("erified=")){
indicator = 786;
} else {
indicator = 790;
} // If
break;
} // Case
case 'P':
{
ctxt.advance();
if (ctxt.lookAheadString("riority=")){
indicator = 784;
} else {
indicator = 790;
} // If
break;
} // Case
case 'N':
{
ctxt.advance();
switch (ctxt.current()) {
case 'e':
{
ctxt.advance();
if (ctxt.lookAheadString("edsRequirement=")){
indicator = 787;
} else {
indicator = 790;
} // If
break;
} // Case
case 'a':
{
ctxt.advance();
if (ctxt.lookAhead3('m','e','=')){
indicator = 788;
} else {
indicator = 790;
} // If
break;
} // Case
default:
indicator = 790;
break;
} // Switch
break;
} // Case
case 'I':
{
ctxt.advance();
if (ctxt.lookAheadString("mplemented=")){
indicator = 785;
} else {
indicator = 790;
} // If
break;
} // Case
default:
indicator = 790;
break;
} // Switch
switch (indicator) {
case 784: {
// Handling attribute Priority
// Also handles alien attributes with prefix Priority
if (fl784){
ctxt.fail ("Duplicate attribute: Priority");
} // If
fl784 = true ; 
quoteChar = ctxt.acceptQuote();
this.setPriority(acceptor.lAcceptEnum_RulePriority(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 785: {
// Handling attribute Implemented
// Also handles alien attributes with prefix Implemented
if (fl785){
ctxt.fail ("Duplicate attribute: Implemented");
} // If
fl785 = true ; 
quoteChar = ctxt.acceptQuote();
this.setImplemented(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 786: {
// Handling attribute Verified
// Also handles alien attributes with prefix Verified
if (fl786){
ctxt.fail ("Duplicate attribute: Verified");
} // If
fl786 = true ; 
quoteChar = ctxt.acceptQuote();
this.setVerified(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 787: {
// Handling attribute NeedsRequirement
// Also handles alien attributes with prefix NeedsRequirement
if (fl787){
ctxt.fail ("Duplicate attribute: NeedsRequirement");
} // If
fl787 = true ; 
quoteChar = ctxt.acceptQuote();
this.setNeedsRequirement(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 788: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl788){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl788 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 790: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl785){
this.setImplemented( false);
} // If
if (!fl786){
this.setVerified( false);
} // If
if (!fl787){
this.setNeedsRequirement( true);
} // If
fl789 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<Rule";
  endingTag = "</Rule>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"Rule\"");
} // If
pw.Write('\n');
if (this.getPriority() != 0){
pw.Write(" Priority=\"");
acceptor.unParsePcData(pw,
  acceptor.Enum_RulePriority_ToString(this.getPriority()));
pw.Write('"');
pw.Write('\n');
} // If
if (this.getImplemented()){
pw.Write(" Implemented=\"");
acceptor.unParsePcData(pw, this.getImplemented());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getVerified()){
pw.Write(" Verified=\"");
acceptor.unParsePcData(pw, this.getVerified());
pw.Write('"');
pw.Write('\n');
} // If
if (!this.getNeedsRequirement()){
pw.Write(" NeedsRequirement=\"");
acceptor.unParsePcData(pw, this.getNeedsRequirement());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing Enclosed
pw.Write("<SubRules>");
// Unparsing PcData
pw.Write("</SubRules>");
// Father is not a mixed
pw.Write('\n');
// Unparsing Enclosed
// Testing for empty content: Conditions
if (countConditions() > 0){
pw.Write("<Conditions>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getConditions(), false, "<RuleCondition", "</RuleCondition>");
pw.Write("</Conditions>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Conditions
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
for (int i = 0; i < countConditions(); i++) {
  l.Add(getConditions(i));
}
}

}
public partial class RuleCondition
: DataDictionary.ReqRelated
{
public  override  bool find(Object search){
if (search is String ) {
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.RuleConditionController.alertChange(aLock, this);
}
private System.Collections.ArrayList aPreConditions;

/// <summary>Part of the list interface for PreConditions</summary>
/// <returns>a collection of all the elements in PreConditions</returns>
public System.Collections.ArrayList allPreConditions()
  {
if (aPreConditions == null){
    setAllPreConditions( new System.Collections.ArrayList() );
} // If
    return aPreConditions;
  }

/// <summary>Part of the list interface for PreConditions</summary>
/// <returns>a collection of all the elements in PreConditions</returns>
private System.Collections.ArrayList getPreConditions()
  {
    return allPreConditions();
  }

/// <summary>Part of the list interface for PreConditions</summary>
/// <param name="coll">a collection of elements which replaces 
///        PreConditions's current content.</param>
public void setAllPreConditions(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aPreConditions = coll;
    NotifyControllers(null);
  }
public void setAllPreConditions(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aPreConditions = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for PreConditions</summary>
/// <param name="el">a PreCondition to add to the collection in 
///           PreConditions</param>
/// <seealso cref="appendPreConditions(ICollection)"/>
public void appendPreConditions(PreCondition el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allPreConditions().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendPreConditions(Lock aLock,PreCondition el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allPreConditions().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for PreConditions</summary>
/// <param name="coll">a collection ofPreConditions to add to the collection in 
///           PreConditions</param>
/// <seealso cref="appendPreConditions(PreCondition)"/>
public void appendPreConditions(ICollection coll)
  {
  __setDirty(true);
  allPreConditions().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendPreConditions(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allPreConditions().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for PreConditions
/// This insertion function inserts a new element in the
/// collection in PreConditions</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertPreConditions(int idx, PreCondition el)
  {
  __setDirty(true);
  allPreConditions().Insert (idx, el);
NotifyControllers(null);
  }

public void insertPreConditions(int idx, PreCondition el,Lock aLock)
  {
  __setDirty(true);
  allPreConditions().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for PreConditions
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfPreConditions(IXmlBBase el)
  {
  return allPreConditions().IndexOf (el);
  }

/// <summary>Part of the list interface for PreConditions
/// This deletion function removes an element from the
/// collection in PreConditions</summary>
/// <param name="idx">the index of the element to remove</param>
public void deletePreConditions(int idx)
  {
  __setDirty(true);
  allPreConditions().RemoveAt(idx);
NotifyControllers(null);
  }

public void deletePreConditions(int idx,Lock aLock)
  {
  __setDirty(true);
  allPreConditions().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for PreConditions
/// This deletion function removes an element from the
/// collection in PreConditions
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removePreConditions(IXmlBBase obj)
  {
  int idx = indexOfPreConditions(obj);
  if (idx >= 0) { deletePreConditions(idx);
NotifyControllers(null);
   }
  }

public void removePreConditions(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfPreConditions(obj);
  if (idx >= 0) { deletePreConditions(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for PreConditions</summary>
/// <returns>the number of elements in PreConditions</returns>
public int countPreConditions()
  {
  return allPreConditions().Count;
  }

/// <summary>Part of the list interface for PreConditions
/// This function returns an element from the
/// collection in PreConditions based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public PreCondition getPreConditions(int idx)
{
  return (PreCondition) ( allPreConditions()[idx]);
}

private System.Collections.ArrayList aActions;

/// <summary>Part of the list interface for Actions</summary>
/// <returns>a collection of all the elements in Actions</returns>
public System.Collections.ArrayList allActions()
  {
if (aActions == null){
    setAllActions( new System.Collections.ArrayList() );
} // If
    return aActions;
  }

/// <summary>Part of the list interface for Actions</summary>
/// <returns>a collection of all the elements in Actions</returns>
private System.Collections.ArrayList getActions()
  {
    return allActions();
  }

/// <summary>Part of the list interface for Actions</summary>
/// <param name="coll">a collection of elements which replaces 
///        Actions's current content.</param>
public void setAllActions(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aActions = coll;
    NotifyControllers(null);
  }
public void setAllActions(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aActions = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Actions</summary>
/// <param name="el">a Action to add to the collection in 
///           Actions</param>
/// <seealso cref="appendActions(ICollection)"/>
public void appendActions(Action el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allActions().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendActions(Lock aLock,Action el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allActions().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Actions</summary>
/// <param name="coll">a collection ofActions to add to the collection in 
///           Actions</param>
/// <seealso cref="appendActions(Action)"/>
public void appendActions(ICollection coll)
  {
  __setDirty(true);
  allActions().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendActions(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allActions().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Actions
/// This insertion function inserts a new element in the
/// collection in Actions</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertActions(int idx, Action el)
  {
  __setDirty(true);
  allActions().Insert (idx, el);
NotifyControllers(null);
  }

public void insertActions(int idx, Action el,Lock aLock)
  {
  __setDirty(true);
  allActions().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Actions
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfActions(IXmlBBase el)
  {
  return allActions().IndexOf (el);
  }

/// <summary>Part of the list interface for Actions
/// This deletion function removes an element from the
/// collection in Actions</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteActions(int idx)
  {
  __setDirty(true);
  allActions().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteActions(int idx,Lock aLock)
  {
  __setDirty(true);
  allActions().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Actions
/// This deletion function removes an element from the
/// collection in Actions
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeActions(IXmlBBase obj)
  {
  int idx = indexOfActions(obj);
  if (idx >= 0) { deleteActions(idx);
NotifyControllers(null);
   }
  }

public void removeActions(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfActions(obj);
  if (idx >= 0) { deleteActions(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Actions</summary>
/// <returns>the number of elements in Actions</returns>
public int countActions()
  {
  return allActions().Count;
  }

/// <summary>Part of the list interface for Actions
/// This function returns an element from the
/// collection in Actions based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Action getActions(int idx)
{
  return (Action) ( allActions()[idx]);
}

private System.Collections.ArrayList aSubRules;

/// <summary>Part of the list interface for SubRules</summary>
/// <returns>a collection of all the elements in SubRules</returns>
public System.Collections.ArrayList allSubRules()
  {
if (aSubRules == null){
    setAllSubRules( new System.Collections.ArrayList() );
} // If
    return aSubRules;
  }

/// <summary>Part of the list interface for SubRules</summary>
/// <returns>a collection of all the elements in SubRules</returns>
private System.Collections.ArrayList getSubRules()
  {
    return allSubRules();
  }

/// <summary>Part of the list interface for SubRules</summary>
/// <param name="coll">a collection of elements which replaces 
///        SubRules's current content.</param>
public void setAllSubRules(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aSubRules = coll;
    NotifyControllers(null);
  }
public void setAllSubRules(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aSubRules = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SubRules</summary>
/// <param name="el">a Rule to add to the collection in 
///           SubRules</param>
/// <seealso cref="appendSubRules(ICollection)"/>
public void appendSubRules(Rule el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allSubRules().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendSubRules(Lock aLock,Rule el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allSubRules().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for SubRules</summary>
/// <param name="coll">a collection ofRules to add to the collection in 
///           SubRules</param>
/// <seealso cref="appendSubRules(Rule)"/>
public void appendSubRules(ICollection coll)
  {
  __setDirty(true);
  allSubRules().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendSubRules(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allSubRules().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SubRules
/// This insertion function inserts a new element in the
/// collection in SubRules</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertSubRules(int idx, Rule el)
  {
  __setDirty(true);
  allSubRules().Insert (idx, el);
NotifyControllers(null);
  }

public void insertSubRules(int idx, Rule el,Lock aLock)
  {
  __setDirty(true);
  allSubRules().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SubRules
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfSubRules(IXmlBBase el)
  {
  return allSubRules().IndexOf (el);
  }

/// <summary>Part of the list interface for SubRules
/// This deletion function removes an element from the
/// collection in SubRules</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteSubRules(int idx)
  {
  __setDirty(true);
  allSubRules().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteSubRules(int idx,Lock aLock)
  {
  __setDirty(true);
  allSubRules().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SubRules
/// This deletion function removes an element from the
/// collection in SubRules
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeSubRules(IXmlBBase obj)
  {
  int idx = indexOfSubRules(obj);
  if (idx >= 0) { deleteSubRules(idx);
NotifyControllers(null);
   }
  }

public void removeSubRules(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfSubRules(obj);
  if (idx >= 0) { deleteSubRules(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for SubRules</summary>
/// <returns>the number of elements in SubRules</returns>
public int countSubRules()
  {
  return allSubRules().Count;
  }

/// <summary>Part of the list interface for SubRules
/// This function returns an element from the
/// collection in SubRules based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Rule getSubRules(int idx)
{
  return (Rule) ( allSubRules()[idx]);
}

public RuleCondition()
{
RuleCondition obj = this;
aPreConditions=(null);
aActions=(null);
aSubRules=(null);
}

public void copyTo(RuleCondition other)
{
base.copyTo(other);
other.aPreConditions = aPreConditions;
other.aActions = aActions;
other.aSubRules = aSubRules;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
bool fl798;
PreCondition fl800;
bool fl811;
Action fl813;
bool fl824;
Rule fl826;

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<PreConditions")){
ctxt.skipWhiteSpace();
fl798 = true ; 
while (fl798) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl798 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl800 = null;
while(ctxt.lookAheadOpeningTag ("<PreCondition")) {
fl800 = acceptor.lAccept_PreCondition(ctxt, null);
appendPreConditions(fl800);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</PreConditions>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Actions")){
ctxt.skipWhiteSpace();
fl811 = true ; 
while (fl811) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl811 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl813 = null;
while(ctxt.lookAheadOpeningTag ("<Action")) {
fl813 = acceptor.lAccept_Action(ctxt, null);
appendActions(fl813);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Actions>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<SubRules")){
ctxt.skipWhiteSpace();
fl824 = true ; 
while (fl824) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl824 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl826 = null;
while(ctxt.lookAheadOpeningTag ("<Rule")) {
fl826 = acceptor.lAccept_Rule(ctxt, "</Rule>");
appendSubRules(fl826);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</SubRules>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl837;
bool fl838;
bool fl839;
bool fl840;
bool fl841;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl837 = false ; 
fl838 = false ; 
fl839 = false ; 
fl840 = false ; 
fl841 = true ; 
while (fl841) { // BeginLoop 
switch (ctxt.current()) {
case 'V':
{
ctxt.advance();
if (ctxt.lookAheadString("erified=")){
indicator = 838;
} else {
indicator = 842;
} // If
break;
} // Case
case 'N':
{
ctxt.advance();
switch (ctxt.current()) {
case 'e':
{
ctxt.advance();
if (ctxt.lookAheadString("edsRequirement=")){
indicator = 839;
} else {
indicator = 842;
} // If
break;
} // Case
case 'a':
{
ctxt.advance();
if (ctxt.lookAhead3('m','e','=')){
indicator = 840;
} else {
indicator = 842;
} // If
break;
} // Case
default:
indicator = 842;
break;
} // Switch
break;
} // Case
case 'I':
{
ctxt.advance();
if (ctxt.lookAheadString("mplemented=")){
indicator = 837;
} else {
indicator = 842;
} // If
break;
} // Case
default:
indicator = 842;
break;
} // Switch
switch (indicator) {
case 837: {
// Handling attribute Implemented
// Also handles alien attributes with prefix Implemented
if (fl837){
ctxt.fail ("Duplicate attribute: Implemented");
} // If
fl837 = true ; 
quoteChar = ctxt.acceptQuote();
this.setImplemented(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 838: {
// Handling attribute Verified
// Also handles alien attributes with prefix Verified
if (fl838){
ctxt.fail ("Duplicate attribute: Verified");
} // If
fl838 = true ; 
quoteChar = ctxt.acceptQuote();
this.setVerified(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 839: {
// Handling attribute NeedsRequirement
// Also handles alien attributes with prefix NeedsRequirement
if (fl839){
ctxt.fail ("Duplicate attribute: NeedsRequirement");
} // If
fl839 = true ; 
quoteChar = ctxt.acceptQuote();
this.setNeedsRequirement(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 840: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl840){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl840 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 842: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl837){
this.setImplemented( false);
} // If
if (!fl838){
this.setVerified( false);
} // If
if (!fl839){
this.setNeedsRequirement( true);
} // If
fl841 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<RuleCondition";
  endingTag = "</RuleCondition>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"RuleCondition\"");
} // If
pw.Write('\n');
if (this.getImplemented()){
pw.Write(" Implemented=\"");
acceptor.unParsePcData(pw, this.getImplemented());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getVerified()){
pw.Write(" Verified=\"");
acceptor.unParsePcData(pw, this.getVerified());
pw.Write('"');
pw.Write('\n');
} // If
if (!this.getNeedsRequirement()){
pw.Write(" NeedsRequirement=\"");
acceptor.unParsePcData(pw, this.getNeedsRequirement());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing Enclosed
pw.Write("<PreConditions>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getPreConditions(), false, null, null);
pw.Write("</PreConditions>");
// Father is not a mixed
pw.Write('\n');
// Unparsing Enclosed
pw.Write("<Actions>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getActions(), false, null, null);
pw.Write("</Actions>");
// Father is not a mixed
pw.Write('\n');
// Unparsing Enclosed
// Testing for empty content: SubRules
if (countSubRules() > 0){
pw.Write("<SubRules>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getSubRules(), false, "<Rule", "</Rule>");
pw.Write("</SubRules>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: SubRules
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
for (int i = 0; i < countPreConditions(); i++) {
  l.Add(getPreConditions(i));
}
for (int i = 0; i < countActions(); i++) {
  l.Add(getActions(i));
}
for (int i = 0; i < countSubRules(); i++) {
  l.Add(getSubRules(i));
}
}

}
public partial class PreCondition
: ModelElement
{
public  override  bool find(Object search){
if (search is String ) {
if(getCondition().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.PreConditionController.alertChange(aLock, this);
}
private   string  aCondition;

public   string  getCondition() { return aCondition;}
public  void setCondition( string  v) {
  aCondition = v;
  __setDirty(true);
  NotifyControllers(null);
}

public PreCondition()
{
PreCondition obj = this;
aCondition=(null);
}

public void copyTo(PreCondition other)
{
other.aCondition = aCondition;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219

// Indicator
// Parse PC data
this.setCondition(acceptor.lAcceptPcData(ctxt, -1, '<',XmlBContext.WS_PRESERVE));
// Regexp
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl849;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
fl849 = true ; 
while (fl849) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl849 = false ; 
} // If
} // While
ctxt.skipWhiteSpace();
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString ("</PreCondition>");
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

pw.Write("<PreCondition");
if (typeId){
pw.Write(" xsi:type=\"PreCondition\"");
} // If
pw.Write('>');
unParseBody(pw);
pw.Write("</PreCondition>");
pw.Write('\n');
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

// Unparsing PcData
acceptor.unParsePcData(pw, this.getCondition());
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
}

}
public partial class Action
: ModelElement
{
public  override  bool find(Object search){
if (search is String ) {
if(getExpression().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.ActionController.alertChange(aLock, this);
}
private   string  aExpression;

public   string  getExpression() { return aExpression;}
public  void setExpression( string  v) {
  aExpression = v;
  __setDirty(true);
  NotifyControllers(null);
}

public Action()
{
Action obj = this;
aExpression=(null);
}

public void copyTo(Action other)
{
other.aExpression = aExpression;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219

// Indicator
// Parse PC data
this.setExpression(acceptor.lAcceptPcData(ctxt, -1, '<',XmlBContext.WS_PRESERVE));
// Regexp
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl850;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
fl850 = true ; 
while (fl850) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl850 = false ; 
} // If
} // While
ctxt.skipWhiteSpace();
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString ("</Action>");
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

pw.Write("<Action");
if (typeId){
pw.Write(" xsi:type=\"Action\"");
} // If
pw.Write('>');
unParseBody(pw);
pw.Write("</Action>");
pw.Write('\n');
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

// Unparsing PcData
acceptor.unParsePcData(pw, this.getExpression());
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
}

}
public partial class Frame
: DataDictionary.Namable
{
public  override  bool find(Object search){
if (search is String ) {
if(getCycleDuration().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.FrameController.alertChange(aLock, this);
}
private   string  aCycleDuration;

public   string  getCycleDuration() { return aCycleDuration;}
public  void setCycleDuration( string  v) {
  aCycleDuration = v;
  __setDirty(true);
  NotifyControllers(null);
}

private System.Collections.ArrayList aSubSequences;

/// <summary>Part of the list interface for SubSequences</summary>
/// <returns>a collection of all the elements in SubSequences</returns>
public System.Collections.ArrayList allSubSequences()
  {
if (aSubSequences == null){
    setAllSubSequences( new System.Collections.ArrayList() );
} // If
    return aSubSequences;
  }

/// <summary>Part of the list interface for SubSequences</summary>
/// <returns>a collection of all the elements in SubSequences</returns>
private System.Collections.ArrayList getSubSequences()
  {
    return allSubSequences();
  }

/// <summary>Part of the list interface for SubSequences</summary>
/// <param name="coll">a collection of elements which replaces 
///        SubSequences's current content.</param>
public void setAllSubSequences(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aSubSequences = coll;
    NotifyControllers(null);
  }
public void setAllSubSequences(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aSubSequences = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SubSequences</summary>
/// <param name="el">a SubSequence to add to the collection in 
///           SubSequences</param>
/// <seealso cref="appendSubSequences(ICollection)"/>
public void appendSubSequences(SubSequence el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allSubSequences().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendSubSequences(Lock aLock,SubSequence el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allSubSequences().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for SubSequences</summary>
/// <param name="coll">a collection ofSubSequences to add to the collection in 
///           SubSequences</param>
/// <seealso cref="appendSubSequences(SubSequence)"/>
public void appendSubSequences(ICollection coll)
  {
  __setDirty(true);
  allSubSequences().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendSubSequences(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allSubSequences().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SubSequences
/// This insertion function inserts a new element in the
/// collection in SubSequences</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertSubSequences(int idx, SubSequence el)
  {
  __setDirty(true);
  allSubSequences().Insert (idx, el);
NotifyControllers(null);
  }

public void insertSubSequences(int idx, SubSequence el,Lock aLock)
  {
  __setDirty(true);
  allSubSequences().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SubSequences
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfSubSequences(IXmlBBase el)
  {
  return allSubSequences().IndexOf (el);
  }

/// <summary>Part of the list interface for SubSequences
/// This deletion function removes an element from the
/// collection in SubSequences</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteSubSequences(int idx)
  {
  __setDirty(true);
  allSubSequences().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteSubSequences(int idx,Lock aLock)
  {
  __setDirty(true);
  allSubSequences().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SubSequences
/// This deletion function removes an element from the
/// collection in SubSequences
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeSubSequences(IXmlBBase obj)
  {
  int idx = indexOfSubSequences(obj);
  if (idx >= 0) { deleteSubSequences(idx);
NotifyControllers(null);
   }
  }

public void removeSubSequences(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfSubSequences(obj);
  if (idx >= 0) { deleteSubSequences(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for SubSequences</summary>
/// <returns>the number of elements in SubSequences</returns>
public int countSubSequences()
  {
  return allSubSequences().Count;
  }

/// <summary>Part of the list interface for SubSequences
/// This function returns an element from the
/// collection in SubSequences based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public SubSequence getSubSequences(int idx)
{
  return (SubSequence) ( allSubSequences()[idx]);
}

public Frame()
{
Frame obj = this;
aCycleDuration=(null);
aSubSequences=(null);
}

public void copyTo(Frame other)
{
base.copyTo(other);
other.aCycleDuration = aCycleDuration;
other.aSubSequences = aSubSequences;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
bool fl851;
SubSequence fl853;

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<SubSequences")){
ctxt.skipWhiteSpace();
fl851 = true ; 
while (fl851) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl851 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl853 = null;
while(ctxt.lookAheadOpeningTag ("<SubSequence")) {
fl853 = acceptor.lAccept_SubSequence(ctxt, "</SubSequence>");
appendSubSequences(fl853);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</SubSequences>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl864;
bool fl865;
bool fl866;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl864 = false ; 
fl865 = false ; 
fl866 = true ; 
while (fl866) { // BeginLoop 
switch (ctxt.current()) {
case 'N':
{
ctxt.advance();
if (ctxt.lookAheadString("ame=")){
indicator = 865;
} else {
indicator = 867;
} // If
break;
} // Case
case 'C':
{
ctxt.advance();
if (ctxt.lookAheadString("ycleDuration=")){
indicator = 864;
} else {
indicator = 867;
} // If
break;
} // Case
default:
indicator = 867;
break;
} // Switch
switch (indicator) {
case 864: {
// Handling attribute CycleDuration
// Also handles alien attributes with prefix CycleDuration
if (fl864){
ctxt.fail ("Duplicate attribute: CycleDuration");
} // If
fl864 = true ; 
quoteChar = ctxt.acceptQuote();
this.setCycleDuration((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 865: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl865){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl865 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 867: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl864){
this.setCycleDuration("0.1");
} // If
fl866 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<Frame";
  endingTag = "</Frame>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"Frame\"");
} // If
pw.Write('\n');
if (this.getCycleDuration() != null){
pw.Write(" CycleDuration=\"");
acceptor.unParsePcData(pw, this.getCycleDuration());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing Enclosed
// Testing for empty content: SubSequences
if (countSubSequences() > 0){
pw.Write("<SubSequences>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getSubSequences(), false, "<SubSequence", "</SubSequence>");
pw.Write("</SubSequences>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: SubSequences
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
for (int i = 0; i < countSubSequences(); i++) {
  l.Add(getSubSequences(i));
}
}

}
public partial class SubSequence
: DataDictionary.Namable
{
public  override  bool find(Object search){
if (search is String ) {
if(getD_LRBG().CompareTo((String) search) == 0)return true;
if(getLevel().CompareTo((String) search) == 0)return true;
if(getMode().CompareTo((String) search) == 0)return true;
if(getNID_LRBG().CompareTo((String) search) == 0)return true;
if(getQ_DIRLRBG().CompareTo((String) search) == 0)return true;
if(getQ_DIRTRAIN().CompareTo((String) search) == 0)return true;
if(getQ_DLRBG().CompareTo((String) search) == 0)return true;
if(getRBC_ID().CompareTo((String) search) == 0)return true;
if(getRBCPhone().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.SubSequenceController.alertChange(aLock, this);
}
private   string  aD_LRBG;

public   string  getD_LRBG() { return aD_LRBG;}
public  void setD_LRBG( string  v) {
  aD_LRBG = v;
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aLevel;

public   string  getLevel() { return aLevel;}
public  void setLevel( string  v) {
  aLevel = v;
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aMode;

public   string  getMode() { return aMode;}
public  void setMode( string  v) {
  aMode = v;
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aNID_LRBG;

public   string  getNID_LRBG() { return aNID_LRBG;}
public  void setNID_LRBG( string  v) {
  aNID_LRBG = v;
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aQ_DIRLRBG;

public   string  getQ_DIRLRBG() { return aQ_DIRLRBG;}
public  void setQ_DIRLRBG( string  v) {
  aQ_DIRLRBG = v;
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aQ_DIRTRAIN;

public   string  getQ_DIRTRAIN() { return aQ_DIRTRAIN;}
public  void setQ_DIRTRAIN( string  v) {
  aQ_DIRTRAIN = v;
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aQ_DLRBG;

public   string  getQ_DLRBG() { return aQ_DLRBG;}
public  void setQ_DLRBG( string  v) {
  aQ_DLRBG = v;
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aRBC_ID;

public   string  getRBC_ID() { return aRBC_ID;}
public  void setRBC_ID( string  v) {
  aRBC_ID = v;
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aRBCPhone;

public   string  getRBCPhone() { return aRBCPhone;}
public  void setRBCPhone( string  v) {
  aRBCPhone = v;
  __setDirty(true);
  NotifyControllers(null);
}

private System.Collections.ArrayList aTestCases;

/// <summary>Part of the list interface for TestCases</summary>
/// <returns>a collection of all the elements in TestCases</returns>
public System.Collections.ArrayList allTestCases()
  {
if (aTestCases == null){
    setAllTestCases( new System.Collections.ArrayList() );
} // If
    return aTestCases;
  }

/// <summary>Part of the list interface for TestCases</summary>
/// <returns>a collection of all the elements in TestCases</returns>
private System.Collections.ArrayList getTestCases()
  {
    return allTestCases();
  }

/// <summary>Part of the list interface for TestCases</summary>
/// <param name="coll">a collection of elements which replaces 
///        TestCases's current content.</param>
public void setAllTestCases(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aTestCases = coll;
    NotifyControllers(null);
  }
public void setAllTestCases(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aTestCases = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for TestCases</summary>
/// <param name="el">a TestCase to add to the collection in 
///           TestCases</param>
/// <seealso cref="appendTestCases(ICollection)"/>
public void appendTestCases(TestCase el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allTestCases().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendTestCases(Lock aLock,TestCase el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allTestCases().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for TestCases</summary>
/// <param name="coll">a collection ofTestCases to add to the collection in 
///           TestCases</param>
/// <seealso cref="appendTestCases(TestCase)"/>
public void appendTestCases(ICollection coll)
  {
  __setDirty(true);
  allTestCases().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendTestCases(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allTestCases().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for TestCases
/// This insertion function inserts a new element in the
/// collection in TestCases</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertTestCases(int idx, TestCase el)
  {
  __setDirty(true);
  allTestCases().Insert (idx, el);
NotifyControllers(null);
  }

public void insertTestCases(int idx, TestCase el,Lock aLock)
  {
  __setDirty(true);
  allTestCases().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for TestCases
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfTestCases(IXmlBBase el)
  {
  return allTestCases().IndexOf (el);
  }

/// <summary>Part of the list interface for TestCases
/// This deletion function removes an element from the
/// collection in TestCases</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteTestCases(int idx)
  {
  __setDirty(true);
  allTestCases().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteTestCases(int idx,Lock aLock)
  {
  __setDirty(true);
  allTestCases().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for TestCases
/// This deletion function removes an element from the
/// collection in TestCases
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeTestCases(IXmlBBase obj)
  {
  int idx = indexOfTestCases(obj);
  if (idx >= 0) { deleteTestCases(idx);
NotifyControllers(null);
   }
  }

public void removeTestCases(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfTestCases(obj);
  if (idx >= 0) { deleteTestCases(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for TestCases</summary>
/// <returns>the number of elements in TestCases</returns>
public int countTestCases()
  {
  return allTestCases().Count;
  }

/// <summary>Part of the list interface for TestCases
/// This function returns an element from the
/// collection in TestCases based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public TestCase getTestCases(int idx)
{
  return (TestCase) ( allTestCases()[idx]);
}

public SubSequence()
{
SubSequence obj = this;
aD_LRBG=(null);
aLevel=(null);
aMode=(null);
aNID_LRBG=(null);
aQ_DIRLRBG=(null);
aQ_DIRTRAIN=(null);
aQ_DLRBG=(null);
aRBC_ID=(null);
aRBCPhone=(null);
aTestCases=(null);
}

public void copyTo(SubSequence other)
{
base.copyTo(other);
other.aD_LRBG = aD_LRBG;
other.aLevel = aLevel;
other.aMode = aMode;
other.aNID_LRBG = aNID_LRBG;
other.aQ_DIRLRBG = aQ_DIRLRBG;
other.aQ_DIRTRAIN = aQ_DIRTRAIN;
other.aQ_DLRBG = aQ_DLRBG;
other.aRBC_ID = aRBC_ID;
other.aRBCPhone = aRBCPhone;
other.aTestCases = aTestCases;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
bool fl871;
TestCase fl873;

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<TestCases")){
ctxt.skipWhiteSpace();
fl871 = true ; 
while (fl871) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl871 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl873 = null;
while(ctxt.lookAheadOpeningTag ("<TestCase")) {
fl873 = acceptor.lAccept_TestCase(ctxt, "</TestCase>");
appendTestCases(fl873);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</TestCases>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl884;
bool fl885;
bool fl886;
bool fl887;
bool fl888;
bool fl889;
bool fl890;
bool fl891;
bool fl892;
bool fl893;
bool fl894;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl884 = false ; 
fl885 = false ; 
fl886 = false ; 
fl887 = false ; 
fl888 = false ; 
fl889 = false ; 
fl890 = false ; 
fl891 = false ; 
fl892 = false ; 
fl893 = false ; 
fl894 = true ; 
while (fl894) { // BeginLoop 
switch (ctxt.current()) {
case 'R':
{
ctxt.advance();
if (ctxt.lookAhead2('B','C')){
switch (ctxt.current()) {
case '_':
{
ctxt.advance();
if (ctxt.lookAhead3('I','D','=')){
indicator = 891;
} else {
indicator = 895;
} // If
break;
} // Case
case 'P':
{
ctxt.advance();
if (ctxt.lookAheadString("hone=")){
indicator = 892;
} else {
indicator = 895;
} // If
break;
} // Case
default:
indicator = 895;
break;
} // Switch
} else {
indicator = 895;
} // If
break;
} // Case
case 'Q':
{
ctxt.advance();
if (ctxt.lookAhead2('_','D')){
switch (ctxt.current()) {
case 'L':
{
ctxt.advance();
if (ctxt.lookAheadString("RBG=")){
indicator = 890;
} else {
indicator = 895;
} // If
break;
} // Case
case 'I':
{
ctxt.advance();
if (ctxt.lookAhead1('R')){
switch (ctxt.current()) {
case 'T':
{
ctxt.advance();
if (ctxt.lookAheadString("RAIN=")){
indicator = 889;
} else {
indicator = 895;
} // If
break;
} // Case
case 'L':
{
ctxt.advance();
if (ctxt.lookAheadString("RBG=")){
indicator = 888;
} else {
indicator = 895;
} // If
break;
} // Case
default:
indicator = 895;
break;
} // Switch
} else {
indicator = 895;
} // If
break;
} // Case
default:
indicator = 895;
break;
} // Switch
} else {
indicator = 895;
} // If
break;
} // Case
case 'N':
{
ctxt.advance();
switch (ctxt.current()) {
case 'a':
{
ctxt.advance();
if (ctxt.lookAhead3('m','e','=')){
indicator = 893;
} else {
indicator = 895;
} // If
break;
} // Case
case 'I':
{
ctxt.advance();
if (ctxt.lookAheadString("D_LRBG=")){
indicator = 887;
} else {
indicator = 895;
} // If
break;
} // Case
default:
indicator = 895;
break;
} // Switch
break;
} // Case
case 'M':
{
ctxt.advance();
if (ctxt.lookAheadString("ode=")){
indicator = 886;
} else {
indicator = 895;
} // If
break;
} // Case
case 'L':
{
ctxt.advance();
if (ctxt.lookAheadString("evel=")){
indicator = 885;
} else {
indicator = 895;
} // If
break;
} // Case
case 'D':
{
ctxt.advance();
if (ctxt.lookAheadString("_LRBG=")){
indicator = 884;
} else {
indicator = 895;
} // If
break;
} // Case
default:
indicator = 895;
break;
} // Switch
switch (indicator) {
case 884: {
// Handling attribute D_LRBG
// Also handles alien attributes with prefix D_LRBG
if (fl884){
ctxt.fail ("Duplicate attribute: D_LRBG");
} // If
fl884 = true ; 
quoteChar = ctxt.acceptQuote();
this.setD_LRBG((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 885: {
// Handling attribute Level
// Also handles alien attributes with prefix Level
if (fl885){
ctxt.fail ("Duplicate attribute: Level");
} // If
fl885 = true ; 
quoteChar = ctxt.acceptQuote();
this.setLevel((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 886: {
// Handling attribute Mode
// Also handles alien attributes with prefix Mode
if (fl886){
ctxt.fail ("Duplicate attribute: Mode");
} // If
fl886 = true ; 
quoteChar = ctxt.acceptQuote();
this.setMode((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 887: {
// Handling attribute NID_LRBG
// Also handles alien attributes with prefix NID_LRBG
if (fl887){
ctxt.fail ("Duplicate attribute: NID_LRBG");
} // If
fl887 = true ; 
quoteChar = ctxt.acceptQuote();
this.setNID_LRBG((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 888: {
// Handling attribute Q_DIRLRBG
// Also handles alien attributes with prefix Q_DIRLRBG
if (fl888){
ctxt.fail ("Duplicate attribute: Q_DIRLRBG");
} // If
fl888 = true ; 
quoteChar = ctxt.acceptQuote();
this.setQ_DIRLRBG((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 889: {
// Handling attribute Q_DIRTRAIN
// Also handles alien attributes with prefix Q_DIRTRAIN
if (fl889){
ctxt.fail ("Duplicate attribute: Q_DIRTRAIN");
} // If
fl889 = true ; 
quoteChar = ctxt.acceptQuote();
this.setQ_DIRTRAIN((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 890: {
// Handling attribute Q_DLRBG
// Also handles alien attributes with prefix Q_DLRBG
if (fl890){
ctxt.fail ("Duplicate attribute: Q_DLRBG");
} // If
fl890 = true ; 
quoteChar = ctxt.acceptQuote();
this.setQ_DLRBG((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 891: {
// Handling attribute RBC_ID
// Also handles alien attributes with prefix RBC_ID
if (fl891){
ctxt.fail ("Duplicate attribute: RBC_ID");
} // If
fl891 = true ; 
quoteChar = ctxt.acceptQuote();
this.setRBC_ID((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 892: {
// Handling attribute RBCPhone
// Also handles alien attributes with prefix RBCPhone
if (fl892){
ctxt.fail ("Duplicate attribute: RBCPhone");
} // If
fl892 = true ; 
quoteChar = ctxt.acceptQuote();
this.setRBCPhone((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 893: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl893){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl893 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 895: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl884){
this.setD_LRBG("");
} // If
if (!fl885){
this.setLevel("");
} // If
if (!fl886){
this.setMode("");
} // If
if (!fl887){
this.setNID_LRBG("");
} // If
if (!fl888){
this.setQ_DIRLRBG("");
} // If
if (!fl889){
this.setQ_DIRTRAIN("");
} // If
if (!fl890){
this.setQ_DLRBG("");
} // If
if (!fl891){
this.setRBC_ID("");
} // If
if (!fl892){
this.setRBCPhone("");
} // If
fl894 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<SubSequence";
  endingTag = "</SubSequence>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"SubSequence\"");
} // If
pw.Write('\n');
if (this.getD_LRBG() != null){
pw.Write(" D_LRBG=\"");
acceptor.unParsePcData(pw, this.getD_LRBG());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getLevel() != null){
pw.Write(" Level=\"");
acceptor.unParsePcData(pw, this.getLevel());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getMode() != null){
pw.Write(" Mode=\"");
acceptor.unParsePcData(pw, this.getMode());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getNID_LRBG() != null){
pw.Write(" NID_LRBG=\"");
acceptor.unParsePcData(pw, this.getNID_LRBG());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getQ_DIRLRBG() != null){
pw.Write(" Q_DIRLRBG=\"");
acceptor.unParsePcData(pw, this.getQ_DIRLRBG());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getQ_DIRTRAIN() != null){
pw.Write(" Q_DIRTRAIN=\"");
acceptor.unParsePcData(pw, this.getQ_DIRTRAIN());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getQ_DLRBG() != null){
pw.Write(" Q_DLRBG=\"");
acceptor.unParsePcData(pw, this.getQ_DLRBG());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getRBC_ID() != null){
pw.Write(" RBC_ID=\"");
acceptor.unParsePcData(pw, this.getRBC_ID());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getRBCPhone() != null){
pw.Write(" RBCPhone=\"");
acceptor.unParsePcData(pw, this.getRBCPhone());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing Enclosed
// Testing for empty content: TestCases
if (countTestCases() > 0){
pw.Write("<TestCases>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getTestCases(), false, "<TestCase", "</TestCase>");
pw.Write("</TestCases>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: TestCases
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
for (int i = 0; i < countTestCases(); i++) {
  l.Add(getTestCases(i));
}
}

}
public partial class TestCase
: DataDictionary.ReqRelated
{
public  override  bool find(Object search){
if (search is String ) {
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.TestCaseController.alertChange(aLock, this);
}
private  int aFeature;

public  int getFeature() { return aFeature;}
public  void setFeature(int v) {
  aFeature = v;
  __setDirty(true);
  NotifyControllers(null);
}

private  int aCase;

public  int getCase() { return aCase;}
public  void setCase(int v) {
  aCase = v;
  __setDirty(true);
  NotifyControllers(null);
}

private System.Collections.ArrayList aSteps;

/// <summary>Part of the list interface for Steps</summary>
/// <returns>a collection of all the elements in Steps</returns>
public System.Collections.ArrayList allSteps()
  {
if (aSteps == null){
    setAllSteps( new System.Collections.ArrayList() );
} // If
    return aSteps;
  }

/// <summary>Part of the list interface for Steps</summary>
/// <returns>a collection of all the elements in Steps</returns>
private System.Collections.ArrayList getSteps()
  {
    return allSteps();
  }

/// <summary>Part of the list interface for Steps</summary>
/// <param name="coll">a collection of elements which replaces 
///        Steps's current content.</param>
public void setAllSteps(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aSteps = coll;
    NotifyControllers(null);
  }
public void setAllSteps(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aSteps = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Steps</summary>
/// <param name="el">a Step to add to the collection in 
///           Steps</param>
/// <seealso cref="appendSteps(ICollection)"/>
public void appendSteps(Step el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allSteps().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendSteps(Lock aLock,Step el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allSteps().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Steps</summary>
/// <param name="coll">a collection ofSteps to add to the collection in 
///           Steps</param>
/// <seealso cref="appendSteps(Step)"/>
public void appendSteps(ICollection coll)
  {
  __setDirty(true);
  allSteps().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendSteps(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allSteps().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Steps
/// This insertion function inserts a new element in the
/// collection in Steps</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertSteps(int idx, Step el)
  {
  __setDirty(true);
  allSteps().Insert (idx, el);
NotifyControllers(null);
  }

public void insertSteps(int idx, Step el,Lock aLock)
  {
  __setDirty(true);
  allSteps().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Steps
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfSteps(IXmlBBase el)
  {
  return allSteps().IndexOf (el);
  }

/// <summary>Part of the list interface for Steps
/// This deletion function removes an element from the
/// collection in Steps</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteSteps(int idx)
  {
  __setDirty(true);
  allSteps().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteSteps(int idx,Lock aLock)
  {
  __setDirty(true);
  allSteps().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Steps
/// This deletion function removes an element from the
/// collection in Steps
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeSteps(IXmlBBase obj)
  {
  int idx = indexOfSteps(obj);
  if (idx >= 0) { deleteSteps(idx);
NotifyControllers(null);
   }
  }

public void removeSteps(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfSteps(obj);
  if (idx >= 0) { deleteSteps(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Steps</summary>
/// <returns>the number of elements in Steps</returns>
public int countSteps()
  {
  return allSteps().Count;
  }

/// <summary>Part of the list interface for Steps
/// This function returns an element from the
/// collection in Steps based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Step getSteps(int idx)
{
  return (Step) ( allSteps()[idx]);
}

public TestCase()
{
TestCase obj = this;
aFeature=(0);
aCase=(0);
aSteps=(null);
}

public void copyTo(TestCase other)
{
base.copyTo(other);
other.aFeature = aFeature;
other.aCase = aCase;
other.aSteps = aSteps;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
bool fl911;
Step fl913;

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Steps")){
ctxt.skipWhiteSpace();
fl911 = true ; 
while (fl911) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl911 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl913 = null;
while(ctxt.lookAheadOpeningTag ("<Step")) {
fl913 = acceptor.lAccept_Step(ctxt, "</Step>");
appendSteps(fl913);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Steps>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl924;
bool fl925;
bool fl926;
bool fl927;
bool fl928;
bool fl929;
bool fl930;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl924 = false ; 
fl925 = false ; 
fl926 = false ; 
fl927 = false ; 
fl928 = false ; 
fl929 = false ; 
fl930 = true ; 
while (fl930) { // BeginLoop 
switch (ctxt.current()) {
case 'V':
{
ctxt.advance();
if (ctxt.lookAheadString("erified=")){
indicator = 927;
} else {
indicator = 931;
} // If
break;
} // Case
case 'N':
{
ctxt.advance();
switch (ctxt.current()) {
case 'e':
{
ctxt.advance();
if (ctxt.lookAheadString("edsRequirement=")){
indicator = 928;
} else {
indicator = 931;
} // If
break;
} // Case
case 'a':
{
ctxt.advance();
if (ctxt.lookAhead3('m','e','=')){
indicator = 929;
} else {
indicator = 931;
} // If
break;
} // Case
default:
indicator = 931;
break;
} // Switch
break;
} // Case
case 'I':
{
ctxt.advance();
if (ctxt.lookAheadString("mplemented=")){
indicator = 926;
} else {
indicator = 931;
} // If
break;
} // Case
case 'F':
{
ctxt.advance();
if (ctxt.lookAheadString("eature=")){
indicator = 924;
} else {
indicator = 931;
} // If
break;
} // Case
case 'C':
{
ctxt.advance();
if (ctxt.lookAheadString("ase=")){
indicator = 925;
} else {
indicator = 931;
} // If
break;
} // Case
default:
indicator = 931;
break;
} // Switch
switch (indicator) {
case 924: {
// Handling attribute Feature
// Also handles alien attributes with prefix Feature
if (fl924){
ctxt.fail ("Duplicate attribute: Feature");
} // If
fl924 = true ; 
quoteChar = ctxt.acceptQuote();
this.setFeature(ctxt.fetchInteger());
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 925: {
// Handling attribute Case
// Also handles alien attributes with prefix Case
if (fl925){
ctxt.fail ("Duplicate attribute: Case");
} // If
fl925 = true ; 
quoteChar = ctxt.acceptQuote();
this.setCase(ctxt.fetchInteger());
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 926: {
// Handling attribute Implemented
// Also handles alien attributes with prefix Implemented
if (fl926){
ctxt.fail ("Duplicate attribute: Implemented");
} // If
fl926 = true ; 
quoteChar = ctxt.acceptQuote();
this.setImplemented(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 927: {
// Handling attribute Verified
// Also handles alien attributes with prefix Verified
if (fl927){
ctxt.fail ("Duplicate attribute: Verified");
} // If
fl927 = true ; 
quoteChar = ctxt.acceptQuote();
this.setVerified(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 928: {
// Handling attribute NeedsRequirement
// Also handles alien attributes with prefix NeedsRequirement
if (fl928){
ctxt.fail ("Duplicate attribute: NeedsRequirement");
} // If
fl928 = true ; 
quoteChar = ctxt.acceptQuote();
this.setNeedsRequirement(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 929: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl929){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl929 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 931: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl924){
this.setFeature(9999);
} // If
if (!fl925){
this.setCase(9999);
} // If
if (!fl926){
this.setImplemented( false);
} // If
if (!fl927){
this.setVerified( false);
} // If
if (!fl928){
this.setNeedsRequirement( true);
} // If
fl930 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<TestCase";
  endingTag = "</TestCase>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"TestCase\"");
} // If
pw.Write('\n');
if (this.getFeature() != 9999){
pw.Write(" Feature=\"");
acceptor.unParsePcData(pw, this.getFeature());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getCase() != 9999){
pw.Write(" Case=\"");
acceptor.unParsePcData(pw, this.getCase());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getImplemented()){
pw.Write(" Implemented=\"");
acceptor.unParsePcData(pw, this.getImplemented());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getVerified()){
pw.Write(" Verified=\"");
acceptor.unParsePcData(pw, this.getVerified());
pw.Write('"');
pw.Write('\n');
} // If
if (!this.getNeedsRequirement()){
pw.Write(" NeedsRequirement=\"");
acceptor.unParsePcData(pw, this.getNeedsRequirement());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing Enclosed
// Testing for empty content: Steps
if (countSteps() > 0){
pw.Write("<Steps>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getSteps(), false, "<Step", "</Step>");
pw.Write("</Steps>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Steps
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
for (int i = 0; i < countSteps(); i++) {
  l.Add(getSteps(i));
}
}

}
public partial class Step
: DataDictionary.Namable
{
public  override  bool find(Object search){
if (search is String ) {
if(getDescription().CompareTo((String) search) == 0)return true;
if(getComment().CompareTo((String) search) == 0)return true;
if(getUserComment().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.StepController.alertChange(aLock, this);
}
private  int aTCS_Order;

public  int getTCS_Order() { return aTCS_Order;}
public  void setTCS_Order(int v) {
  aTCS_Order = v;
  __setDirty(true);
  NotifyControllers(null);
}

private  int aDistance;

public  int getDistance() { return aDistance;}
public  void setDistance(int v) {
  aDistance = v;
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aDescription;

public   string  getDescription() { return aDescription;}
public  void setDescription( string  v) {
  aDescription = v;
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aComment;

public   string  getComment() { return aComment;}
public  void setComment( string  v) {
  aComment = v;
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aUserComment;

public   string  getUserComment() { return aUserComment;}
public  void setUserComment( string  v) {
  aUserComment = v;
  __setDirty(true);
  NotifyControllers(null);
}

private  acceptor.ST_IO aIO;

public  acceptor.ST_IO getIO() { return aIO;}
public  void setIO(acceptor.ST_IO v) {
  aIO = v;
  __setDirty(true);
  NotifyControllers(null);
}

public  string   getIO_AsString()
{
  return acceptor.Enum_ST_IO_ToString (aIO);
}

public  bool setIO_AsString( string  v)
{
 acceptor.ST_IO  temp = acceptor.StringTo_Enum_ST_IO(v);
if (temp >= 0){
  aIO = temp;
  __setDirty(true);
  NotifyControllers(null);
  return true;
} // If
return false;
}

private  acceptor.ST_INTERFACE aInterface;

public  acceptor.ST_INTERFACE getInterface() { return aInterface;}
public  void setInterface(acceptor.ST_INTERFACE v) {
  aInterface = v;
  __setDirty(true);
  NotifyControllers(null);
}

public  string   getInterface_AsString()
{
  return acceptor.Enum_ST_INTERFACE_ToString (aInterface);
}

public  bool setInterface_AsString( string  v)
{
 acceptor.ST_INTERFACE  temp = acceptor.StringTo_Enum_ST_INTERFACE(v);
if (temp >= 0){
  aInterface = temp;
  __setDirty(true);
  NotifyControllers(null);
  return true;
} // If
return false;
}

private  acceptor.ST_LEVEL aLevelIN;

public  acceptor.ST_LEVEL getLevelIN() { return aLevelIN;}
public  void setLevelIN(acceptor.ST_LEVEL v) {
  aLevelIN = v;
  __setDirty(true);
  NotifyControllers(null);
}

public  string   getLevelIN_AsString()
{
  return acceptor.Enum_ST_LEVEL_ToString (aLevelIN);
}

public  bool setLevelIN_AsString( string  v)
{
 acceptor.ST_LEVEL  temp = acceptor.StringTo_Enum_ST_LEVEL(v);
if (temp >= 0){
  aLevelIN = temp;
  __setDirty(true);
  NotifyControllers(null);
  return true;
} // If
return false;
}

private  acceptor.ST_LEVEL aLevelOUT;

public  acceptor.ST_LEVEL getLevelOUT() { return aLevelOUT;}
public  void setLevelOUT(acceptor.ST_LEVEL v) {
  aLevelOUT = v;
  __setDirty(true);
  NotifyControllers(null);
}

public  string   getLevelOUT_AsString()
{
  return acceptor.Enum_ST_LEVEL_ToString (aLevelOUT);
}

public  bool setLevelOUT_AsString( string  v)
{
 acceptor.ST_LEVEL  temp = acceptor.StringTo_Enum_ST_LEVEL(v);
if (temp >= 0){
  aLevelOUT = temp;
  __setDirty(true);
  NotifyControllers(null);
  return true;
} // If
return false;
}

private  acceptor.ST_MODE aModeIN;

public  acceptor.ST_MODE getModeIN() { return aModeIN;}
public  void setModeIN(acceptor.ST_MODE v) {
  aModeIN = v;
  __setDirty(true);
  NotifyControllers(null);
}

public  string   getModeIN_AsString()
{
  return acceptor.Enum_ST_MODE_ToString (aModeIN);
}

public  bool setModeIN_AsString( string  v)
{
 acceptor.ST_MODE  temp = acceptor.StringTo_Enum_ST_MODE(v);
if (temp >= 0){
  aModeIN = temp;
  __setDirty(true);
  NotifyControllers(null);
  return true;
} // If
return false;
}

private  acceptor.ST_MODE aModeOUT;

public  acceptor.ST_MODE getModeOUT() { return aModeOUT;}
public  void setModeOUT(acceptor.ST_MODE v) {
  aModeOUT = v;
  __setDirty(true);
  NotifyControllers(null);
}

public  string   getModeOUT_AsString()
{
  return acceptor.Enum_ST_MODE_ToString (aModeOUT);
}

public  bool setModeOUT_AsString( string  v)
{
 acceptor.ST_MODE  temp = acceptor.StringTo_Enum_ST_MODE(v);
if (temp >= 0){
  aModeOUT = temp;
  __setDirty(true);
  NotifyControllers(null);
  return true;
} // If
return false;
}

private  bool aTranslationRequired;

public  bool getTranslationRequired() { return aTranslationRequired;}
public  void setTranslationRequired(bool v) {
  aTranslationRequired = v;
  __setDirty(true);
  NotifyControllers(null);
}

private  bool aTranslated;

public  bool getTranslated() { return aTranslated;}
public  void setTranslated(bool v) {
  aTranslated = v;
  __setDirty(true);
  NotifyControllers(null);
}

private System.Collections.ArrayList aSubSteps;

/// <summary>Part of the list interface for SubSteps</summary>
/// <returns>a collection of all the elements in SubSteps</returns>
public System.Collections.ArrayList allSubSteps()
  {
if (aSubSteps == null){
    setAllSubSteps( new System.Collections.ArrayList() );
} // If
    return aSubSteps;
  }

/// <summary>Part of the list interface for SubSteps</summary>
/// <returns>a collection of all the elements in SubSteps</returns>
private System.Collections.ArrayList getSubSteps()
  {
    return allSubSteps();
  }

/// <summary>Part of the list interface for SubSteps</summary>
/// <param name="coll">a collection of elements which replaces 
///        SubSteps's current content.</param>
public void setAllSubSteps(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aSubSteps = coll;
    NotifyControllers(null);
  }
public void setAllSubSteps(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aSubSteps = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SubSteps</summary>
/// <param name="el">a SubStep to add to the collection in 
///           SubSteps</param>
/// <seealso cref="appendSubSteps(ICollection)"/>
public void appendSubSteps(SubStep el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allSubSteps().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendSubSteps(Lock aLock,SubStep el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allSubSteps().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for SubSteps</summary>
/// <param name="coll">a collection ofSubSteps to add to the collection in 
///           SubSteps</param>
/// <seealso cref="appendSubSteps(SubStep)"/>
public void appendSubSteps(ICollection coll)
  {
  __setDirty(true);
  allSubSteps().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendSubSteps(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allSubSteps().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SubSteps
/// This insertion function inserts a new element in the
/// collection in SubSteps</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertSubSteps(int idx, SubStep el)
  {
  __setDirty(true);
  allSubSteps().Insert (idx, el);
NotifyControllers(null);
  }

public void insertSubSteps(int idx, SubStep el,Lock aLock)
  {
  __setDirty(true);
  allSubSteps().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SubSteps
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfSubSteps(IXmlBBase el)
  {
  return allSubSteps().IndexOf (el);
  }

/// <summary>Part of the list interface for SubSteps
/// This deletion function removes an element from the
/// collection in SubSteps</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteSubSteps(int idx)
  {
  __setDirty(true);
  allSubSteps().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteSubSteps(int idx,Lock aLock)
  {
  __setDirty(true);
  allSubSteps().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SubSteps
/// This deletion function removes an element from the
/// collection in SubSteps
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeSubSteps(IXmlBBase obj)
  {
  int idx = indexOfSubSteps(obj);
  if (idx >= 0) { deleteSubSteps(idx);
NotifyControllers(null);
   }
  }

public void removeSubSteps(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfSubSteps(obj);
  if (idx >= 0) { deleteSubSteps(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for SubSteps</summary>
/// <returns>the number of elements in SubSteps</returns>
public int countSubSteps()
  {
  return allSubSteps().Count;
  }

/// <summary>Part of the list interface for SubSteps
/// This function returns an element from the
/// collection in SubSteps based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public SubStep getSubSteps(int idx)
{
  return (SubStep) ( allSubSteps()[idx]);
}

private System.Collections.ArrayList aMessages;

/// <summary>Part of the list interface for Messages</summary>
/// <returns>a collection of all the elements in Messages</returns>
public System.Collections.ArrayList allMessages()
  {
if (aMessages == null){
    setAllMessages( new System.Collections.ArrayList() );
} // If
    return aMessages;
  }

/// <summary>Part of the list interface for Messages</summary>
/// <returns>a collection of all the elements in Messages</returns>
private System.Collections.ArrayList getMessages()
  {
    return allMessages();
  }

/// <summary>Part of the list interface for Messages</summary>
/// <param name="coll">a collection of elements which replaces 
///        Messages's current content.</param>
public void setAllMessages(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aMessages = coll;
    NotifyControllers(null);
  }
public void setAllMessages(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aMessages = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Messages</summary>
/// <param name="el">a DBMessage to add to the collection in 
///           Messages</param>
/// <seealso cref="appendMessages(ICollection)"/>
public void appendMessages(DBMessage el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allMessages().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendMessages(Lock aLock,DBMessage el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allMessages().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Messages</summary>
/// <param name="coll">a collection ofDBMessages to add to the collection in 
///           Messages</param>
/// <seealso cref="appendMessages(DBMessage)"/>
public void appendMessages(ICollection coll)
  {
  __setDirty(true);
  allMessages().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendMessages(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allMessages().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Messages
/// This insertion function inserts a new element in the
/// collection in Messages</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertMessages(int idx, DBMessage el)
  {
  __setDirty(true);
  allMessages().Insert (idx, el);
NotifyControllers(null);
  }

public void insertMessages(int idx, DBMessage el,Lock aLock)
  {
  __setDirty(true);
  allMessages().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Messages
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfMessages(IXmlBBase el)
  {
  return allMessages().IndexOf (el);
  }

/// <summary>Part of the list interface for Messages
/// This deletion function removes an element from the
/// collection in Messages</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteMessages(int idx)
  {
  __setDirty(true);
  allMessages().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteMessages(int idx,Lock aLock)
  {
  __setDirty(true);
  allMessages().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Messages
/// This deletion function removes an element from the
/// collection in Messages
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeMessages(IXmlBBase obj)
  {
  int idx = indexOfMessages(obj);
  if (idx >= 0) { deleteMessages(idx);
NotifyControllers(null);
   }
  }

public void removeMessages(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfMessages(obj);
  if (idx >= 0) { deleteMessages(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Messages</summary>
/// <returns>the number of elements in Messages</returns>
public int countMessages()
  {
  return allMessages().Count;
  }

/// <summary>Part of the list interface for Messages
/// This function returns an element from the
/// collection in Messages based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public DBMessage getMessages(int idx)
{
  return (DBMessage) ( allMessages()[idx]);
}

public Step()
{
Step obj = this;
aTCS_Order=(0);
aDistance=(0);
aDescription=(null);
aComment=(null);
aUserComment=(null);
aIO=(0);
aInterface=(0);
aLevelIN=(0);
aLevelOUT=(0);
aModeIN=(0);
aModeOUT=(0);
aTranslationRequired=(false);
aTranslated=(false);
aSubSteps=(null);
aMessages=(null);
}

public void copyTo(Step other)
{
base.copyTo(other);
other.aTCS_Order = aTCS_Order;
other.aDistance = aDistance;
other.aDescription = aDescription;
other.aComment = aComment;
other.aUserComment = aUserComment;
other.aIO = aIO;
other.aInterface = aInterface;
other.aLevelIN = aLevelIN;
other.aLevelOUT = aLevelOUT;
other.aModeIN = aModeIN;
other.aModeOUT = aModeOUT;
other.aTranslationRequired = aTranslationRequired;
other.aTranslated = aTranslated;
other.aSubSteps = aSubSteps;
other.aMessages = aMessages;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
bool fl940;
bool fl941;
bool fl942;
bool fl943;
SubStep fl945;
bool fl956;
DBMessage fl958;

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Description")){
ctxt.skipWhiteSpace();
fl940 = true ; 
while (fl940) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl940 = false ; 
} // If
} // While
ctxt.accept('>');
// Indicator
// Parse PC data
this.setDescription(acceptor.lAcceptPcData(ctxt, -1, '<',XmlBContext.WS_PRESERVE));
// Regexp
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Description>");
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Comment")){
ctxt.skipWhiteSpace();
fl941 = true ; 
while (fl941) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl941 = false ; 
} // If
} // While
ctxt.accept('>');
// Indicator
// Parse PC data
this.setComment(acceptor.lAcceptPcData(ctxt, -1, '<',XmlBContext.WS_PRESERVE));
// Regexp
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Comment>");
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<UserComment")){
ctxt.skipWhiteSpace();
fl942 = true ; 
while (fl942) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl942 = false ; 
} // If
} // While
ctxt.accept('>');
// Indicator
// Parse PC data
this.setUserComment(acceptor.lAcceptPcData(ctxt, -1, '<',XmlBContext.WS_PRESERVE));
// Regexp
ctxt.skipWhiteSpace();
ctxt.acceptString ("</UserComment>");
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<SubSteps")){
ctxt.skipWhiteSpace();
fl943 = true ; 
while (fl943) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl943 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl945 = null;
while(ctxt.lookAheadOpeningTag ("<SubStep")) {
fl945 = acceptor.lAccept_SubStep(ctxt, "</SubStep>");
appendSubSteps(fl945);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</SubSteps>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Messsages")){
ctxt.skipWhiteSpace();
fl956 = true ; 
while (fl956) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl956 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl958 = null;
while(ctxt.lookAheadOpeningTag ("<DBMessage")) {
fl958 = acceptor.lAccept_DBMessage(ctxt, "</DBMessage>");
appendMessages(fl958);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Messsages>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl969;
bool fl970;
bool fl971;
bool fl972;
bool fl973;
bool fl974;
bool fl975;
bool fl976;
bool fl977;
bool fl978;
bool fl979;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl969 = false ; 
fl970 = false ; 
fl971 = false ; 
fl972 = false ; 
fl973 = false ; 
fl974 = false ; 
fl975 = false ; 
fl976 = false ; 
fl977 = false ; 
fl978 = false ; 
fl979 = true ; 
while (fl979) { // BeginLoop 
switch (ctxt.current()) {
case 'T':
{
ctxt.advance();
switch (ctxt.current()) {
case 'r':
{
ctxt.advance();
if (ctxt.lookAheadString("anslat")){
switch (ctxt.current()) {
case 'i':
{
ctxt.advance();
if (ctxt.lookAheadString("onRequired=")){
indicator = 976;
} else {
indicator = 980;
} // If
break;
} // Case
case 'e':
{
ctxt.advance();
if (ctxt.lookAhead2('d','=')){
indicator = 977;
} else {
indicator = 980;
} // If
break;
} // Case
default:
indicator = 980;
break;
} // Switch
} else {
indicator = 980;
} // If
break;
} // Case
case 'C':
{
ctxt.advance();
if (ctxt.lookAheadString("S_Order=")){
indicator = 969;
} else {
indicator = 980;
} // If
break;
} // Case
default:
indicator = 980;
break;
} // Switch
break;
} // Case
case 'N':
{
ctxt.advance();
if (ctxt.lookAheadString("ame=")){
indicator = 978;
} else {
indicator = 980;
} // If
break;
} // Case
case 'M':
{
ctxt.advance();
if (ctxt.lookAhead3('o','d','e')){
switch (ctxt.current()) {
case 'O':
{
ctxt.advance();
if (ctxt.lookAhead3('U','T','=')){
indicator = 975;
} else {
indicator = 980;
} // If
break;
} // Case
case 'I':
{
ctxt.advance();
if (ctxt.lookAhead2('N','=')){
indicator = 974;
} else {
indicator = 980;
} // If
break;
} // Case
default:
indicator = 980;
break;
} // Switch
} else {
indicator = 980;
} // If
break;
} // Case
case 'L':
{
ctxt.advance();
if (ctxt.lookAheadString("evel")){
switch (ctxt.current()) {
case 'O':
{
ctxt.advance();
if (ctxt.lookAhead3('U','T','=')){
indicator = 973;
} else {
indicator = 980;
} // If
break;
} // Case
case 'I':
{
ctxt.advance();
if (ctxt.lookAhead2('N','=')){
indicator = 972;
} else {
indicator = 980;
} // If
break;
} // Case
default:
indicator = 980;
break;
} // Switch
} else {
indicator = 980;
} // If
break;
} // Case
case 'I':
{
ctxt.advance();
if (ctxt.lookAhead2('O','=')){
indicator = 971;
} else {
indicator = 980;
} // If
break;
} // Case
case 'D':
{
ctxt.advance();
if (ctxt.lookAheadString("istance=")){
indicator = 970;
} else {
indicator = 980;
} // If
break;
} // Case
default:
indicator = 980;
break;
} // Switch
switch (indicator) {
case 969: {
// Handling attribute TCS_Order
// Also handles alien attributes with prefix TCS_Order
if (fl969){
ctxt.fail ("Duplicate attribute: TCS_Order");
} // If
fl969 = true ; 
quoteChar = ctxt.acceptQuote();
this.setTCS_Order(ctxt.fetchInteger());
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 970: {
// Handling attribute Distance
// Also handles alien attributes with prefix Distance
if (fl970){
ctxt.fail ("Duplicate attribute: Distance");
} // If
fl970 = true ; 
quoteChar = ctxt.acceptQuote();
this.setDistance(ctxt.fetchInteger());
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 971: {
// Handling attribute IO
// Also handles alien attributes with prefix IO
if (fl971){
ctxt.fail ("Duplicate attribute: IO");
} // If
fl971 = true ; 
quoteChar = ctxt.acceptQuote();
this.setIO(acceptor.lAcceptEnum_ST_IO(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 972: {
// Handling attribute LevelIN
// Also handles alien attributes with prefix LevelIN
if (fl972){
ctxt.fail ("Duplicate attribute: LevelIN");
} // If
fl972 = true ; 
quoteChar = ctxt.acceptQuote();
this.setLevelIN(acceptor.lAcceptEnum_ST_LEVEL(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 973: {
// Handling attribute LevelOUT
// Also handles alien attributes with prefix LevelOUT
if (fl973){
ctxt.fail ("Duplicate attribute: LevelOUT");
} // If
fl973 = true ; 
quoteChar = ctxt.acceptQuote();
this.setLevelOUT(acceptor.lAcceptEnum_ST_LEVEL(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 974: {
// Handling attribute ModeIN
// Also handles alien attributes with prefix ModeIN
if (fl974){
ctxt.fail ("Duplicate attribute: ModeIN");
} // If
fl974 = true ; 
quoteChar = ctxt.acceptQuote();
this.setModeIN(acceptor.lAcceptEnum_ST_MODE(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 975: {
// Handling attribute ModeOUT
// Also handles alien attributes with prefix ModeOUT
if (fl975){
ctxt.fail ("Duplicate attribute: ModeOUT");
} // If
fl975 = true ; 
quoteChar = ctxt.acceptQuote();
this.setModeOUT(acceptor.lAcceptEnum_ST_MODE(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 976: {
// Handling attribute TranslationRequired
// Also handles alien attributes with prefix TranslationRequired
if (fl976){
ctxt.fail ("Duplicate attribute: TranslationRequired");
} // If
fl976 = true ; 
quoteChar = ctxt.acceptQuote();
this.setTranslationRequired(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 977: {
// Handling attribute Translated
// Also handles alien attributes with prefix Translated
if (fl977){
ctxt.fail ("Duplicate attribute: Translated");
} // If
fl977 = true ; 
quoteChar = ctxt.acceptQuote();
this.setTranslated(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 978: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl978){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl978 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 980: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl969){
this.setTCS_Order(0);
} // If
if (!fl970){
this.setDistance(0);
} // If
if (!fl971){
this.setIO(acceptor.ST_IO.StIO_NA);
} // If
if (!fl972){
this.setLevelIN(acceptor.ST_LEVEL.StLevel_NA);
} // If
if (!fl973){
this.setLevelOUT(acceptor.ST_LEVEL.StLevel_NA);
} // If
if (!fl974){
this.setModeIN(acceptor.ST_MODE.Mode_NA);
} // If
if (!fl975){
this.setModeOUT(acceptor.ST_MODE.Mode_NA);
} // If
if (!fl976){
this.setTranslationRequired( true);
} // If
if (!fl977){
this.setTranslated( false);
} // If
fl979 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<Step";
  endingTag = "</Step>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"Step\"");
} // If
pw.Write('\n');
if (this.getTCS_Order() != 0){
pw.Write(" TCS_Order=\"");
acceptor.unParsePcData(pw, this.getTCS_Order());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getDistance() != 0){
pw.Write(" Distance=\"");
acceptor.unParsePcData(pw, this.getDistance());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getIO() != 0){
pw.Write(" IO=\"");
acceptor.unParsePcData(pw,
  acceptor.Enum_ST_IO_ToString(this.getIO()));
pw.Write('"');
pw.Write('\n');
} // If
if (this.getLevelIN() != 0){
pw.Write(" LevelIN=\"");
acceptor.unParsePcData(pw,
  acceptor.Enum_ST_LEVEL_ToString(this.getLevelIN()));
pw.Write('"');
pw.Write('\n');
} // If
if (this.getLevelOUT() != 0){
pw.Write(" LevelOUT=\"");
acceptor.unParsePcData(pw,
  acceptor.Enum_ST_LEVEL_ToString(this.getLevelOUT()));
pw.Write('"');
pw.Write('\n');
} // If
if (this.getModeIN() != 0){
pw.Write(" ModeIN=\"");
acceptor.unParsePcData(pw,
  acceptor.Enum_ST_MODE_ToString(this.getModeIN()));
pw.Write('"');
pw.Write('\n');
} // If
if (this.getModeOUT() != 0){
pw.Write(" ModeOUT=\"");
acceptor.unParsePcData(pw,
  acceptor.Enum_ST_MODE_ToString(this.getModeOUT()));
pw.Write('"');
pw.Write('\n');
} // If
if (!this.getTranslationRequired()){
pw.Write(" TranslationRequired=\"");
acceptor.unParsePcData(pw, this.getTranslationRequired());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getTranslated()){
pw.Write(" Translated=\"");
acceptor.unParsePcData(pw, this.getTranslated());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing Enclosed
// Testing for empty content: Description
if (this.getDescription() != null){
pw.Write("<Description>");
// Unparsing PcData
acceptor.unParsePcData(pw, this.getDescription());
pw.Write("</Description>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Description
// Unparsing Enclosed
// Testing for empty content: Comment
if (this.getComment() != null){
pw.Write("<Comment>");
// Unparsing PcData
acceptor.unParsePcData(pw, this.getComment());
pw.Write("</Comment>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Comment
// Unparsing Enclosed
// Testing for empty content: UserComment
if (this.getUserComment() != null){
pw.Write("<UserComment>");
// Unparsing PcData
acceptor.unParsePcData(pw, this.getUserComment());
pw.Write("</UserComment>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: UserComment
// Unparsing Enclosed
// Testing for empty content: SubSteps
if (countSubSteps() > 0){
pw.Write("<SubSteps>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getSubSteps(), false, "<SubStep", "</SubStep>");
pw.Write("</SubSteps>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: SubSteps
// Unparsing Enclosed
// Testing for empty content: Messages
if (countMessages() > 0){
pw.Write("<Messsages>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getMessages(), false, "<DBMessage", "</DBMessage>");
pw.Write("</Messsages>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Messages
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
for (int i = 0; i < countSubSteps(); i++) {
  l.Add(getSubSteps(i));
}
for (int i = 0; i < countMessages(); i++) {
  l.Add(getMessages(i));
}
}

}
public partial class SubStep
: DataDictionary.Namable
{
public  override  bool find(Object search){
if (search is String ) {
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.SubStepController.alertChange(aLock, this);
}
private System.Collections.ArrayList aActions;

/// <summary>Part of the list interface for Actions</summary>
/// <returns>a collection of all the elements in Actions</returns>
public System.Collections.ArrayList allActions()
  {
if (aActions == null){
    setAllActions( new System.Collections.ArrayList() );
} // If
    return aActions;
  }

/// <summary>Part of the list interface for Actions</summary>
/// <returns>a collection of all the elements in Actions</returns>
private System.Collections.ArrayList getActions()
  {
    return allActions();
  }

/// <summary>Part of the list interface for Actions</summary>
/// <param name="coll">a collection of elements which replaces 
///        Actions's current content.</param>
public void setAllActions(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aActions = coll;
    NotifyControllers(null);
  }
public void setAllActions(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aActions = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Actions</summary>
/// <param name="el">a Action to add to the collection in 
///           Actions</param>
/// <seealso cref="appendActions(ICollection)"/>
public void appendActions(Action el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allActions().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendActions(Lock aLock,Action el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allActions().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Actions</summary>
/// <param name="coll">a collection ofActions to add to the collection in 
///           Actions</param>
/// <seealso cref="appendActions(Action)"/>
public void appendActions(ICollection coll)
  {
  __setDirty(true);
  allActions().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendActions(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allActions().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Actions
/// This insertion function inserts a new element in the
/// collection in Actions</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertActions(int idx, Action el)
  {
  __setDirty(true);
  allActions().Insert (idx, el);
NotifyControllers(null);
  }

public void insertActions(int idx, Action el,Lock aLock)
  {
  __setDirty(true);
  allActions().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Actions
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfActions(IXmlBBase el)
  {
  return allActions().IndexOf (el);
  }

/// <summary>Part of the list interface for Actions
/// This deletion function removes an element from the
/// collection in Actions</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteActions(int idx)
  {
  __setDirty(true);
  allActions().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteActions(int idx,Lock aLock)
  {
  __setDirty(true);
  allActions().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Actions
/// This deletion function removes an element from the
/// collection in Actions
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeActions(IXmlBBase obj)
  {
  int idx = indexOfActions(obj);
  if (idx >= 0) { deleteActions(idx);
NotifyControllers(null);
   }
  }

public void removeActions(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfActions(obj);
  if (idx >= 0) { deleteActions(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Actions</summary>
/// <returns>the number of elements in Actions</returns>
public int countActions()
  {
  return allActions().Count;
  }

/// <summary>Part of the list interface for Actions
/// This function returns an element from the
/// collection in Actions based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Action getActions(int idx)
{
  return (Action) ( allActions()[idx]);
}

private System.Collections.ArrayList aExpectations;

/// <summary>Part of the list interface for Expectations</summary>
/// <returns>a collection of all the elements in Expectations</returns>
public System.Collections.ArrayList allExpectations()
  {
if (aExpectations == null){
    setAllExpectations( new System.Collections.ArrayList() );
} // If
    return aExpectations;
  }

/// <summary>Part of the list interface for Expectations</summary>
/// <returns>a collection of all the elements in Expectations</returns>
private System.Collections.ArrayList getExpectations()
  {
    return allExpectations();
  }

/// <summary>Part of the list interface for Expectations</summary>
/// <param name="coll">a collection of elements which replaces 
///        Expectations's current content.</param>
public void setAllExpectations(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aExpectations = coll;
    NotifyControllers(null);
  }
public void setAllExpectations(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aExpectations = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Expectations</summary>
/// <param name="el">a Expectation to add to the collection in 
///           Expectations</param>
/// <seealso cref="appendExpectations(ICollection)"/>
public void appendExpectations(Expectation el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allExpectations().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendExpectations(Lock aLock,Expectation el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allExpectations().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Expectations</summary>
/// <param name="coll">a collection ofExpectations to add to the collection in 
///           Expectations</param>
/// <seealso cref="appendExpectations(Expectation)"/>
public void appendExpectations(ICollection coll)
  {
  __setDirty(true);
  allExpectations().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendExpectations(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allExpectations().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Expectations
/// This insertion function inserts a new element in the
/// collection in Expectations</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertExpectations(int idx, Expectation el)
  {
  __setDirty(true);
  allExpectations().Insert (idx, el);
NotifyControllers(null);
  }

public void insertExpectations(int idx, Expectation el,Lock aLock)
  {
  __setDirty(true);
  allExpectations().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Expectations
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfExpectations(IXmlBBase el)
  {
  return allExpectations().IndexOf (el);
  }

/// <summary>Part of the list interface for Expectations
/// This deletion function removes an element from the
/// collection in Expectations</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteExpectations(int idx)
  {
  __setDirty(true);
  allExpectations().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteExpectations(int idx,Lock aLock)
  {
  __setDirty(true);
  allExpectations().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Expectations
/// This deletion function removes an element from the
/// collection in Expectations
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeExpectations(IXmlBBase obj)
  {
  int idx = indexOfExpectations(obj);
  if (idx >= 0) { deleteExpectations(idx);
NotifyControllers(null);
   }
  }

public void removeExpectations(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfExpectations(obj);
  if (idx >= 0) { deleteExpectations(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Expectations</summary>
/// <returns>the number of elements in Expectations</returns>
public int countExpectations()
  {
  return allExpectations().Count;
  }

/// <summary>Part of the list interface for Expectations
/// This function returns an element from the
/// collection in Expectations based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Expectation getExpectations(int idx)
{
  return (Expectation) ( allExpectations()[idx]);
}

private  bool aSkipEngine;

public  bool getSkipEngine() { return aSkipEngine;}
public  void setSkipEngine(bool v) {
  aSkipEngine = v;
  __setDirty(true);
  NotifyControllers(null);
}

public SubStep()
{
SubStep obj = this;
aActions=(null);
aExpectations=(null);
aSkipEngine=(false);
}

public void copyTo(SubStep other)
{
base.copyTo(other);
other.aActions = aActions;
other.aExpectations = aExpectations;
other.aSkipEngine = aSkipEngine;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
bool fl996;
Action fl998;
bool fl1009;
Expectation fl1011;

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Actions")){
ctxt.skipWhiteSpace();
fl996 = true ; 
while (fl996) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl996 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl998 = null;
while(ctxt.lookAheadOpeningTag ("<Action")) {
fl998 = acceptor.lAccept_Action(ctxt, null);
appendActions(fl998);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Actions>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Expectations")){
ctxt.skipWhiteSpace();
fl1009 = true ; 
while (fl1009) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1009 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl1011 = null;
while(ctxt.lookAheadOpeningTag ("<Expectation")) {
fl1011 = acceptor.lAccept_Expectation(ctxt, "</Expectation>");
appendExpectations(fl1011);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Expectations>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl1022;
bool fl1023;
bool fl1024;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl1022 = false ; 
fl1023 = false ; 
fl1024 = true ; 
while (fl1024) { // BeginLoop 
switch (ctxt.current()) {
case 'S':
{
ctxt.advance();
if (ctxt.lookAheadString("kipEngine=")){
indicator = 1022;
} else {
indicator = 1025;
} // If
break;
} // Case
case 'N':
{
ctxt.advance();
if (ctxt.lookAheadString("ame=")){
indicator = 1023;
} else {
indicator = 1025;
} // If
break;
} // Case
default:
indicator = 1025;
break;
} // Switch
switch (indicator) {
case 1022: {
// Handling attribute SkipEngine
// Also handles alien attributes with prefix SkipEngine
if (fl1022){
ctxt.fail ("Duplicate attribute: SkipEngine");
} // If
fl1022 = true ; 
quoteChar = ctxt.acceptQuote();
this.setSkipEngine(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1023: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl1023){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl1023 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 1025: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl1022){
this.setSkipEngine( false);
} // If
fl1024 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<SubStep";
  endingTag = "</SubStep>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"SubStep\"");
} // If
pw.Write('\n');
if (this.getSkipEngine()){
pw.Write(" SkipEngine=\"");
acceptor.unParsePcData(pw, this.getSkipEngine());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing Enclosed
// Testing for empty content: Actions
if (countActions() > 0){
pw.Write("<Actions>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getActions(), false, null, null);
pw.Write("</Actions>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Actions
// Unparsing Enclosed
// Testing for empty content: Expectations
if (countExpectations() > 0){
pw.Write("<Expectations>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getExpectations(), false, "<Expectation", "</Expectation>");
pw.Write("</Expectations>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Expectations
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
for (int i = 0; i < countActions(); i++) {
  l.Add(getActions(i));
}
for (int i = 0; i < countExpectations(); i++) {
  l.Add(getExpectations(i));
}
}

}
public partial class Expectation
: DataDictionary.Namable
{
public  override  bool find(Object search){
if (search is String ) {
if(getVariable().CompareTo((String) search) == 0)return true;
if(getValue().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.ExpectationController.alertChange(aLock, this);
}
private   string  aVariable;

public   string  getVariable() { return aVariable;}
public  void setVariable( string  v) {
  aVariable = v;
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aValue;

public   string  getValue() { return aValue;}
public  void setValue( string  v) {
  aValue = v;
  __setDirty(true);
  NotifyControllers(null);
}

private  bool aBlocking;

public  bool getBlocking() { return aBlocking;}
public  void setBlocking(bool v) {
  aBlocking = v;
  __setDirty(true);
  NotifyControllers(null);
}

private  double aDeadLine;

public  double getDeadLine() { return aDeadLine;}
public  void setDeadLine(double v) {
  aDeadLine = v;
  __setDirty(true);
  NotifyControllers(null);
}

public Expectation()
{
Expectation obj = this;
aVariable=(null);
aValue=(null);
aBlocking=(false);
aDeadLine=(0.0);
}

public void copyTo(Expectation other)
{
base.copyTo(other);
other.aVariable = aVariable;
other.aValue = aValue;
other.aBlocking = aBlocking;
other.aDeadLine = aDeadLine;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219

base.parseBody(ctxt);
// Indicator
// Parse PC data
this.setValue(acceptor.lAcceptPcData(ctxt, -1, '<',XmlBContext.WS_PRESERVE));
// Regexp
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl1029;
bool fl1030;
bool fl1031;
bool fl1032;
bool fl1033;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl1029 = false ; 
fl1030 = false ; 
fl1031 = false ; 
fl1032 = false ; 
fl1033 = true ; 
while (fl1033) { // BeginLoop 
switch (ctxt.current()) {
case 'V':
{
ctxt.advance();
if (ctxt.lookAheadString("ariable=")){
indicator = 1029;
} else {
indicator = 1034;
} // If
break;
} // Case
case 'N':
{
ctxt.advance();
if (ctxt.lookAheadString("ame=")){
indicator = 1032;
} else {
indicator = 1034;
} // If
break;
} // Case
case 'D':
{
ctxt.advance();
if (ctxt.lookAheadString("eadLine=")){
indicator = 1031;
} else {
indicator = 1034;
} // If
break;
} // Case
case 'B':
{
ctxt.advance();
if (ctxt.lookAheadString("locking=")){
indicator = 1030;
} else {
indicator = 1034;
} // If
break;
} // Case
default:
indicator = 1034;
break;
} // Switch
switch (indicator) {
case 1029: {
// Handling attribute Variable
// Also handles alien attributes with prefix Variable
if (fl1029){
ctxt.fail ("Duplicate attribute: Variable");
} // If
fl1029 = true ; 
quoteChar = ctxt.acceptQuote();
this.setVariable((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1030: {
// Handling attribute Blocking
// Also handles alien attributes with prefix Blocking
if (fl1030){
ctxt.fail ("Duplicate attribute: Blocking");
} // If
fl1030 = true ; 
quoteChar = ctxt.acceptQuote();
this.setBlocking(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1031: {
// Handling attribute DeadLine
// Also handles alien attributes with prefix DeadLine
if (fl1031){
ctxt.fail ("Duplicate attribute: DeadLine");
} // If
fl1031 = true ; 
quoteChar = ctxt.acceptQuote();
this.setDeadLine(ctxt.fetchDouble());
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1032: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl1032){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl1032 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 1034: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl1029){
ctxt.fail ("Mandatory attribute missing: Variable in Expectation");
} // If
if (!fl1030){
this.setBlocking( false);
} // If
if (!fl1031){
this.setDeadLine(0.0);
} // If
fl1033 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<Expectation";
  endingTag = "</Expectation>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"Expectation\"");
} // If
pw.Write('\n');
pw.Write(" Variable=\"");
acceptor.unParsePcData(pw, this.getVariable());
pw.Write('"');
pw.Write('\n');
if (this.getBlocking()){
pw.Write(" Blocking=\"");
acceptor.unParsePcData(pw, this.getBlocking());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getDeadLine() != 0){
pw.Write(" DeadLine=\"");
acceptor.unParsePcData(pw, this.getDeadLine());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing PcData
acceptor.unParsePcData(pw, this.getValue());
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
}

}
public partial class DBMessage
: DataDictionary.Namable
{
public  override  bool find(Object search){
if (search is String ) {
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.DBMessageController.alertChange(aLock, this);
}
private  int aMessageOrder;

public  int getMessageOrder() { return aMessageOrder;}
public  void setMessageOrder(int v) {
  aMessageOrder = v;
  __setDirty(true);
  NotifyControllers(null);
}

private  acceptor.DBMessageType aMessageType;

public  acceptor.DBMessageType getMessageType() { return aMessageType;}
public  void setMessageType(acceptor.DBMessageType v) {
  aMessageType = v;
  __setDirty(true);
  NotifyControllers(null);
}

public  string   getMessageType_AsString()
{
  return acceptor.Enum_DBMessageType_ToString (aMessageType);
}

public  bool setMessageType_AsString( string  v)
{
 acceptor.DBMessageType  temp = acceptor.StringTo_Enum_DBMessageType(v);
if (temp >= 0){
  aMessageType = temp;
  __setDirty(true);
  NotifyControllers(null);
  return true;
} // If
return false;
}

private System.Collections.ArrayList aFields;

/// <summary>Part of the list interface for Fields</summary>
/// <returns>a collection of all the elements in Fields</returns>
public System.Collections.ArrayList allFields()
  {
if (aFields == null){
    setAllFields( new System.Collections.ArrayList() );
} // If
    return aFields;
  }

/// <summary>Part of the list interface for Fields</summary>
/// <returns>a collection of all the elements in Fields</returns>
private System.Collections.ArrayList getFields()
  {
    return allFields();
  }

/// <summary>Part of the list interface for Fields</summary>
/// <param name="coll">a collection of elements which replaces 
///        Fields's current content.</param>
public void setAllFields(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aFields = coll;
    NotifyControllers(null);
  }
public void setAllFields(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aFields = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Fields</summary>
/// <param name="el">a DBField to add to the collection in 
///           Fields</param>
/// <seealso cref="appendFields(ICollection)"/>
public void appendFields(DBField el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allFields().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendFields(Lock aLock,DBField el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allFields().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Fields</summary>
/// <param name="coll">a collection ofDBFields to add to the collection in 
///           Fields</param>
/// <seealso cref="appendFields(DBField)"/>
public void appendFields(ICollection coll)
  {
  __setDirty(true);
  allFields().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendFields(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allFields().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Fields
/// This insertion function inserts a new element in the
/// collection in Fields</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertFields(int idx, DBField el)
  {
  __setDirty(true);
  allFields().Insert (idx, el);
NotifyControllers(null);
  }

public void insertFields(int idx, DBField el,Lock aLock)
  {
  __setDirty(true);
  allFields().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Fields
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfFields(IXmlBBase el)
  {
  return allFields().IndexOf (el);
  }

/// <summary>Part of the list interface for Fields
/// This deletion function removes an element from the
/// collection in Fields</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteFields(int idx)
  {
  __setDirty(true);
  allFields().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteFields(int idx,Lock aLock)
  {
  __setDirty(true);
  allFields().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Fields
/// This deletion function removes an element from the
/// collection in Fields
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeFields(IXmlBBase obj)
  {
  int idx = indexOfFields(obj);
  if (idx >= 0) { deleteFields(idx);
NotifyControllers(null);
   }
  }

public void removeFields(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfFields(obj);
  if (idx >= 0) { deleteFields(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Fields</summary>
/// <returns>the number of elements in Fields</returns>
public int countFields()
  {
  return allFields().Count;
  }

/// <summary>Part of the list interface for Fields
/// This function returns an element from the
/// collection in Fields based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public DBField getFields(int idx)
{
  return (DBField) ( allFields()[idx]);
}

private System.Collections.ArrayList aPackets;

/// <summary>Part of the list interface for Packets</summary>
/// <returns>a collection of all the elements in Packets</returns>
public System.Collections.ArrayList allPackets()
  {
if (aPackets == null){
    setAllPackets( new System.Collections.ArrayList() );
} // If
    return aPackets;
  }

/// <summary>Part of the list interface for Packets</summary>
/// <returns>a collection of all the elements in Packets</returns>
private System.Collections.ArrayList getPackets()
  {
    return allPackets();
  }

/// <summary>Part of the list interface for Packets</summary>
/// <param name="coll">a collection of elements which replaces 
///        Packets's current content.</param>
public void setAllPackets(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aPackets = coll;
    NotifyControllers(null);
  }
public void setAllPackets(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aPackets = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Packets</summary>
/// <param name="el">a DBPacket to add to the collection in 
///           Packets</param>
/// <seealso cref="appendPackets(ICollection)"/>
public void appendPackets(DBPacket el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allPackets().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendPackets(Lock aLock,DBPacket el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allPackets().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Packets</summary>
/// <param name="coll">a collection ofDBPackets to add to the collection in 
///           Packets</param>
/// <seealso cref="appendPackets(DBPacket)"/>
public void appendPackets(ICollection coll)
  {
  __setDirty(true);
  allPackets().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendPackets(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allPackets().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Packets
/// This insertion function inserts a new element in the
/// collection in Packets</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertPackets(int idx, DBPacket el)
  {
  __setDirty(true);
  allPackets().Insert (idx, el);
NotifyControllers(null);
  }

public void insertPackets(int idx, DBPacket el,Lock aLock)
  {
  __setDirty(true);
  allPackets().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Packets
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfPackets(IXmlBBase el)
  {
  return allPackets().IndexOf (el);
  }

/// <summary>Part of the list interface for Packets
/// This deletion function removes an element from the
/// collection in Packets</summary>
/// <param name="idx">the index of the element to remove</param>
public void deletePackets(int idx)
  {
  __setDirty(true);
  allPackets().RemoveAt(idx);
NotifyControllers(null);
  }

public void deletePackets(int idx,Lock aLock)
  {
  __setDirty(true);
  allPackets().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Packets
/// This deletion function removes an element from the
/// collection in Packets
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removePackets(IXmlBBase obj)
  {
  int idx = indexOfPackets(obj);
  if (idx >= 0) { deletePackets(idx);
NotifyControllers(null);
   }
  }

public void removePackets(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfPackets(obj);
  if (idx >= 0) { deletePackets(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Packets</summary>
/// <returns>the number of elements in Packets</returns>
public int countPackets()
  {
  return allPackets().Count;
  }

/// <summary>Part of the list interface for Packets
/// This function returns an element from the
/// collection in Packets based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public DBPacket getPackets(int idx)
{
  return (DBPacket) ( allPackets()[idx]);
}

public DBMessage()
{
DBMessage obj = this;
aMessageOrder=(0);
aMessageType=(0);
aFields=(null);
aPackets=(null);
}

public void copyTo(DBMessage other)
{
base.copyTo(other);
other.aMessageOrder = aMessageOrder;
other.aMessageType = aMessageType;
other.aFields = aFields;
other.aPackets = aPackets;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
bool fl1040;
DBField fl1042;
bool fl1053;
DBPacket fl1055;

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Fields")){
ctxt.skipWhiteSpace();
fl1040 = true ; 
while (fl1040) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1040 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl1042 = null;
while(ctxt.lookAheadOpeningTag ("<DBField")) {
fl1042 = acceptor.lAccept_DBField(ctxt, "</DBField>");
appendFields(fl1042);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Fields>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Packets")){
ctxt.skipWhiteSpace();
fl1053 = true ; 
while (fl1053) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1053 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl1055 = null;
while(ctxt.lookAheadOpeningTag ("<DBPacket")) {
fl1055 = acceptor.lAccept_DBPacket(ctxt, "</DBPacket>");
appendPackets(fl1055);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Packets>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl1066;
bool fl1067;
bool fl1068;
bool fl1069;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl1066 = false ; 
fl1067 = false ; 
fl1068 = false ; 
fl1069 = true ; 
while (fl1069) { // BeginLoop 
switch (ctxt.current()) {
case 'N':
{
ctxt.advance();
if (ctxt.lookAheadString("ame=")){
indicator = 1068;
} else {
indicator = 1070;
} // If
break;
} // Case
case 'M':
{
ctxt.advance();
if (ctxt.lookAheadString("essage")){
switch (ctxt.current()) {
case 'T':
{
ctxt.advance();
if (ctxt.lookAheadString("ype=")){
indicator = 1067;
} else {
indicator = 1070;
} // If
break;
} // Case
case 'O':
{
ctxt.advance();
if (ctxt.lookAheadString("rder=")){
indicator = 1066;
} else {
indicator = 1070;
} // If
break;
} // Case
default:
indicator = 1070;
break;
} // Switch
} else {
indicator = 1070;
} // If
break;
} // Case
default:
indicator = 1070;
break;
} // Switch
switch (indicator) {
case 1066: {
// Handling attribute MessageOrder
// Also handles alien attributes with prefix MessageOrder
if (fl1066){
ctxt.fail ("Duplicate attribute: MessageOrder");
} // If
fl1066 = true ; 
quoteChar = ctxt.acceptQuote();
this.setMessageOrder(ctxt.fetchInteger());
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1067: {
// Handling attribute MessageType
// Also handles alien attributes with prefix MessageType
if (fl1067){
ctxt.fail ("Duplicate attribute: MessageType");
} // If
fl1067 = true ; 
quoteChar = ctxt.acceptQuote();
this.setMessageType(acceptor.lAcceptEnum_DBMessageType(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1068: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl1068){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl1068 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 1070: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl1066){
this.setMessageOrder(0);
} // If
if (!fl1067){
this.setMessageType(acceptor.DBMessageType.aEUROBALISE);
} // If
fl1069 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<DBMessage";
  endingTag = "</DBMessage>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"DBMessage\"");
} // If
pw.Write('\n');
if (this.getMessageOrder() != 0){
pw.Write(" MessageOrder=\"");
acceptor.unParsePcData(pw, this.getMessageOrder());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getMessageType() != 0){
pw.Write(" MessageType=\"");
acceptor.unParsePcData(pw,
  acceptor.Enum_DBMessageType_ToString(this.getMessageType()));
pw.Write('"');
pw.Write('\n');
} // If
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing Enclosed
// Testing for empty content: Fields
if (countFields() > 0){
pw.Write("<Fields>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getFields(), false, "<DBField", "</DBField>");
pw.Write("</Fields>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Fields
// Unparsing Enclosed
// Testing for empty content: Packets
if (countPackets() > 0){
pw.Write("<Packets>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getPackets(), false, "<DBPacket", "</DBPacket>");
pw.Write("</Packets>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Packets
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
for (int i = 0; i < countFields(); i++) {
  l.Add(getFields(i));
}
for (int i = 0; i < countPackets(); i++) {
  l.Add(getPackets(i));
}
}

}
public partial class DBPacket
: DataDictionary.Namable
{
public  override  bool find(Object search){
if (search is String ) {
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.DBPacketController.alertChange(aLock, this);
}
private System.Collections.ArrayList aFields;

/// <summary>Part of the list interface for Fields</summary>
/// <returns>a collection of all the elements in Fields</returns>
public System.Collections.ArrayList allFields()
  {
if (aFields == null){
    setAllFields( new System.Collections.ArrayList() );
} // If
    return aFields;
  }

/// <summary>Part of the list interface for Fields</summary>
/// <returns>a collection of all the elements in Fields</returns>
private System.Collections.ArrayList getFields()
  {
    return allFields();
  }

/// <summary>Part of the list interface for Fields</summary>
/// <param name="coll">a collection of elements which replaces 
///        Fields's current content.</param>
public void setAllFields(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aFields = coll;
    NotifyControllers(null);
  }
public void setAllFields(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aFields = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Fields</summary>
/// <param name="el">a DBField to add to the collection in 
///           Fields</param>
/// <seealso cref="appendFields(ICollection)"/>
public void appendFields(DBField el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allFields().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendFields(Lock aLock,DBField el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allFields().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Fields</summary>
/// <param name="coll">a collection ofDBFields to add to the collection in 
///           Fields</param>
/// <seealso cref="appendFields(DBField)"/>
public void appendFields(ICollection coll)
  {
  __setDirty(true);
  allFields().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendFields(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allFields().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Fields
/// This insertion function inserts a new element in the
/// collection in Fields</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertFields(int idx, DBField el)
  {
  __setDirty(true);
  allFields().Insert (idx, el);
NotifyControllers(null);
  }

public void insertFields(int idx, DBField el,Lock aLock)
  {
  __setDirty(true);
  allFields().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Fields
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfFields(IXmlBBase el)
  {
  return allFields().IndexOf (el);
  }

/// <summary>Part of the list interface for Fields
/// This deletion function removes an element from the
/// collection in Fields</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteFields(int idx)
  {
  __setDirty(true);
  allFields().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteFields(int idx,Lock aLock)
  {
  __setDirty(true);
  allFields().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Fields
/// This deletion function removes an element from the
/// collection in Fields
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeFields(IXmlBBase obj)
  {
  int idx = indexOfFields(obj);
  if (idx >= 0) { deleteFields(idx);
NotifyControllers(null);
   }
  }

public void removeFields(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfFields(obj);
  if (idx >= 0) { deleteFields(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Fields</summary>
/// <returns>the number of elements in Fields</returns>
public int countFields()
  {
  return allFields().Count;
  }

/// <summary>Part of the list interface for Fields
/// This function returns an element from the
/// collection in Fields based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public DBField getFields(int idx)
{
  return (DBField) ( allFields()[idx]);
}

public DBPacket()
{
DBPacket obj = this;
aFields=(null);
}

public void copyTo(DBPacket other)
{
base.copyTo(other);
other.aFields = aFields;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
bool fl1076;
DBField fl1078;

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Fields")){
ctxt.skipWhiteSpace();
fl1076 = true ; 
while (fl1076) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1076 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl1078 = null;
while(ctxt.lookAheadOpeningTag ("<DBField")) {
fl1078 = acceptor.lAccept_DBField(ctxt, "</DBField>");
appendFields(fl1078);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Fields>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl1089;
bool fl1090;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl1089 = false ; 
fl1090 = true ; 
while (fl1090) { // BeginLoop 
if (ctxt.lookAheadString("Name=")){
indicator = 1089;
} else {
indicator = 1091;
} // If
switch (indicator) {
case 1089: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl1089){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl1089 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 1091: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1090 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<DBPacket";
  endingTag = "</DBPacket>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"DBPacket\"");
} // If
pw.Write('\n');
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing Enclosed
// Testing for empty content: Fields
if (countFields() > 0){
pw.Write("<Fields>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getFields(), false, "<DBField", "</DBField>");
pw.Write("</Fields>");
// No formula father defined
pw.Write('\n');
} // If
// After Testing for empty content: Fields
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
for (int i = 0; i < countFields(); i++) {
  l.Add(getFields(i));
}
}

}
public partial class DBField
: DataDictionary.Namable
{
public  override  bool find(Object search){
if (search is String ) {
if(getVariable().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.DBFieldController.alertChange(aLock, this);
}
private   string  aVariable;

public   string  getVariable() { return aVariable;}
public  void setVariable( string  v) {
  aVariable = v;
  __setDirty(true);
  NotifyControllers(null);
}

private  int aValue;

public  int getValue() { return aValue;}
public  void setValue(int v) {
  aValue = v;
  __setDirty(true);
  NotifyControllers(null);
}

public DBField()
{
DBField obj = this;
aVariable=(null);
aValue=(0);
}

public void copyTo(DBField other)
{
base.copyTo(other);
other.aVariable = aVariable;
other.aValue = aValue;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
bool fl1093;

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Variable")){
ctxt.skipWhiteSpace();
fl1093 = true ; 
while (fl1093) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1093 = false ; 
} // If
} // While
ctxt.accept('>');
// Indicator
// Parse PC data
this.setVariable(acceptor.lAcceptPcData(ctxt, -1, '<',XmlBContext.WS_PRESERVE));
// Regexp
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Variable>");
} // If
// End enclosed
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl1094;
bool fl1095;
bool fl1096;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl1094 = false ; 
fl1095 = false ; 
fl1096 = true ; 
while (fl1096) { // BeginLoop 
switch (ctxt.current()) {
case 'V':
{
ctxt.advance();
if (ctxt.lookAheadString("alue=")){
indicator = 1094;
} else {
indicator = 1097;
} // If
break;
} // Case
case 'N':
{
ctxt.advance();
if (ctxt.lookAheadString("ame=")){
indicator = 1095;
} else {
indicator = 1097;
} // If
break;
} // Case
default:
indicator = 1097;
break;
} // Switch
switch (indicator) {
case 1094: {
// Handling attribute Value
// Also handles alien attributes with prefix Value
if (fl1094){
ctxt.fail ("Duplicate attribute: Value");
} // If
fl1094 = true ; 
quoteChar = ctxt.acceptQuote();
this.setValue(ctxt.fetchInteger());
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1095: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl1095){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl1095 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 1097: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl1094){
this.setValue(0);
} // If
fl1096 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<DBField";
  endingTag = "</DBField>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"DBField\"");
} // If
pw.Write('\n');
if (this.getValue() != 0){
pw.Write(" Value=\"");
acceptor.unParsePcData(pw, this.getValue());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing Enclosed
// Testing for empty content: Variable
if (this.getVariable() != null){
pw.Write("<Variable>");
// Unparsing PcData
acceptor.unParsePcData(pw, this.getVariable());
pw.Write("</Variable>");
// No formula father defined
pw.Write('\n');
} // If
// After Testing for empty content: Variable
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
}

}
public partial class TranslationDictionary
: DataDictionary.Namable
{
public  override  bool find(Object search){
if (search is String ) {
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.TranslationDictionaryController.alertChange(aLock, this);
}
private System.Collections.ArrayList aFolders;

/// <summary>Part of the list interface for Folders</summary>
/// <returns>a collection of all the elements in Folders</returns>
public System.Collections.ArrayList allFolders()
  {
if (aFolders == null){
    setAllFolders( new System.Collections.ArrayList() );
} // If
    return aFolders;
  }

/// <summary>Part of the list interface for Folders</summary>
/// <returns>a collection of all the elements in Folders</returns>
private System.Collections.ArrayList getFolders()
  {
    return allFolders();
  }

/// <summary>Part of the list interface for Folders</summary>
/// <param name="coll">a collection of elements which replaces 
///        Folders's current content.</param>
public void setAllFolders(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aFolders = coll;
    NotifyControllers(null);
  }
public void setAllFolders(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aFolders = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Folders</summary>
/// <param name="el">a Folder to add to the collection in 
///           Folders</param>
/// <seealso cref="appendFolders(ICollection)"/>
public void appendFolders(Folder el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allFolders().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendFolders(Lock aLock,Folder el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allFolders().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Folders</summary>
/// <param name="coll">a collection ofFolders to add to the collection in 
///           Folders</param>
/// <seealso cref="appendFolders(Folder)"/>
public void appendFolders(ICollection coll)
  {
  __setDirty(true);
  allFolders().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendFolders(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allFolders().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Folders
/// This insertion function inserts a new element in the
/// collection in Folders</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertFolders(int idx, Folder el)
  {
  __setDirty(true);
  allFolders().Insert (idx, el);
NotifyControllers(null);
  }

public void insertFolders(int idx, Folder el,Lock aLock)
  {
  __setDirty(true);
  allFolders().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Folders
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfFolders(IXmlBBase el)
  {
  return allFolders().IndexOf (el);
  }

/// <summary>Part of the list interface for Folders
/// This deletion function removes an element from the
/// collection in Folders</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteFolders(int idx)
  {
  __setDirty(true);
  allFolders().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteFolders(int idx,Lock aLock)
  {
  __setDirty(true);
  allFolders().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Folders
/// This deletion function removes an element from the
/// collection in Folders
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeFolders(IXmlBBase obj)
  {
  int idx = indexOfFolders(obj);
  if (idx >= 0) { deleteFolders(idx);
NotifyControllers(null);
   }
  }

public void removeFolders(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfFolders(obj);
  if (idx >= 0) { deleteFolders(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Folders</summary>
/// <returns>the number of elements in Folders</returns>
public int countFolders()
  {
  return allFolders().Count;
  }

/// <summary>Part of the list interface for Folders
/// This function returns an element from the
/// collection in Folders based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Folder getFolders(int idx)
{
  return (Folder) ( allFolders()[idx]);
}

private System.Collections.ArrayList aTranslations;

/// <summary>Part of the list interface for Translations</summary>
/// <returns>a collection of all the elements in Translations</returns>
public System.Collections.ArrayList allTranslations()
  {
if (aTranslations == null){
    setAllTranslations( new System.Collections.ArrayList() );
} // If
    return aTranslations;
  }

/// <summary>Part of the list interface for Translations</summary>
/// <returns>a collection of all the elements in Translations</returns>
private System.Collections.ArrayList getTranslations()
  {
    return allTranslations();
  }

/// <summary>Part of the list interface for Translations</summary>
/// <param name="coll">a collection of elements which replaces 
///        Translations's current content.</param>
public void setAllTranslations(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aTranslations = coll;
    NotifyControllers(null);
  }
public void setAllTranslations(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aTranslations = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Translations</summary>
/// <param name="el">a Translation to add to the collection in 
///           Translations</param>
/// <seealso cref="appendTranslations(ICollection)"/>
public void appendTranslations(Translation el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allTranslations().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendTranslations(Lock aLock,Translation el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allTranslations().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Translations</summary>
/// <param name="coll">a collection ofTranslations to add to the collection in 
///           Translations</param>
/// <seealso cref="appendTranslations(Translation)"/>
public void appendTranslations(ICollection coll)
  {
  __setDirty(true);
  allTranslations().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendTranslations(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allTranslations().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Translations
/// This insertion function inserts a new element in the
/// collection in Translations</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertTranslations(int idx, Translation el)
  {
  __setDirty(true);
  allTranslations().Insert (idx, el);
NotifyControllers(null);
  }

public void insertTranslations(int idx, Translation el,Lock aLock)
  {
  __setDirty(true);
  allTranslations().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Translations
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfTranslations(IXmlBBase el)
  {
  return allTranslations().IndexOf (el);
  }

/// <summary>Part of the list interface for Translations
/// This deletion function removes an element from the
/// collection in Translations</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteTranslations(int idx)
  {
  __setDirty(true);
  allTranslations().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteTranslations(int idx,Lock aLock)
  {
  __setDirty(true);
  allTranslations().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Translations
/// This deletion function removes an element from the
/// collection in Translations
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeTranslations(IXmlBBase obj)
  {
  int idx = indexOfTranslations(obj);
  if (idx >= 0) { deleteTranslations(idx);
NotifyControllers(null);
   }
  }

public void removeTranslations(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfTranslations(obj);
  if (idx >= 0) { deleteTranslations(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Translations</summary>
/// <returns>the number of elements in Translations</returns>
public int countTranslations()
  {
  return allTranslations().Count;
  }

/// <summary>Part of the list interface for Translations
/// This function returns an element from the
/// collection in Translations based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Translation getTranslations(int idx)
{
  return (Translation) ( allTranslations()[idx]);
}

public TranslationDictionary()
{
TranslationDictionary obj = this;
aFolders=(null);
aTranslations=(null);
}

public void copyTo(TranslationDictionary other)
{
base.copyTo(other);
other.aFolders = aFolders;
other.aTranslations = aTranslations;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
bool fl1101;
Folder fl1103;
bool fl1114;
Translation fl1116;

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Folders")){
ctxt.skipWhiteSpace();
fl1101 = true ; 
while (fl1101) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1101 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl1103 = null;
while(ctxt.lookAheadOpeningTag ("<Folder")) {
fl1103 = acceptor.lAccept_Folder(ctxt, "</Folder>");
appendFolders(fl1103);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Folders>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Translations")){
ctxt.skipWhiteSpace();
fl1114 = true ; 
while (fl1114) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1114 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl1116 = null;
while(ctxt.lookAheadOpeningTag ("<Translation")) {
fl1116 = acceptor.lAccept_Translation(ctxt, "</Translation>");
appendTranslations(fl1116);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Translations>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl1127;
bool fl1128;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl1127 = false ; 
fl1128 = true ; 
while (fl1128) { // BeginLoop 
if (ctxt.lookAheadString("Name=")){
indicator = 1127;
} else {
indicator = 1129;
} // If
switch (indicator) {
case 1127: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl1127){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl1127 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 1129: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1128 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<TranslationDictionary";
  endingTag = "</TranslationDictionary>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"TranslationDictionary\"");
} // If
pw.Write('\n');
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing Enclosed
// Testing for empty content: Folders
if (countFolders() > 0){
pw.Write("<Folders>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getFolders(), false, "<Folder", "</Folder>");
pw.Write("</Folders>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Folders
// Unparsing Enclosed
// Testing for empty content: Translations
if (countTranslations() > 0){
pw.Write("<Translations>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getTranslations(), false, "<Translation", "</Translation>");
pw.Write("</Translations>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Translations
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
for (int i = 0; i < countFolders(); i++) {
  l.Add(getFolders(i));
}
for (int i = 0; i < countTranslations(); i++) {
  l.Add(getTranslations(i));
}
}

}
public partial class Folder
: DataDictionary.Namable
{
public  override  bool find(Object search){
if (search is String ) {
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.FolderController.alertChange(aLock, this);
}
private System.Collections.ArrayList aFolders;

/// <summary>Part of the list interface for Folders</summary>
/// <returns>a collection of all the elements in Folders</returns>
public System.Collections.ArrayList allFolders()
  {
if (aFolders == null){
    setAllFolders( new System.Collections.ArrayList() );
} // If
    return aFolders;
  }

/// <summary>Part of the list interface for Folders</summary>
/// <returns>a collection of all the elements in Folders</returns>
private System.Collections.ArrayList getFolders()
  {
    return allFolders();
  }

/// <summary>Part of the list interface for Folders</summary>
/// <param name="coll">a collection of elements which replaces 
///        Folders's current content.</param>
public void setAllFolders(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aFolders = coll;
    NotifyControllers(null);
  }
public void setAllFolders(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aFolders = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Folders</summary>
/// <param name="el">a Folder to add to the collection in 
///           Folders</param>
/// <seealso cref="appendFolders(ICollection)"/>
public void appendFolders(Folder el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allFolders().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendFolders(Lock aLock,Folder el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allFolders().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Folders</summary>
/// <param name="coll">a collection ofFolders to add to the collection in 
///           Folders</param>
/// <seealso cref="appendFolders(Folder)"/>
public void appendFolders(ICollection coll)
  {
  __setDirty(true);
  allFolders().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendFolders(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allFolders().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Folders
/// This insertion function inserts a new element in the
/// collection in Folders</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertFolders(int idx, Folder el)
  {
  __setDirty(true);
  allFolders().Insert (idx, el);
NotifyControllers(null);
  }

public void insertFolders(int idx, Folder el,Lock aLock)
  {
  __setDirty(true);
  allFolders().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Folders
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfFolders(IXmlBBase el)
  {
  return allFolders().IndexOf (el);
  }

/// <summary>Part of the list interface for Folders
/// This deletion function removes an element from the
/// collection in Folders</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteFolders(int idx)
  {
  __setDirty(true);
  allFolders().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteFolders(int idx,Lock aLock)
  {
  __setDirty(true);
  allFolders().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Folders
/// This deletion function removes an element from the
/// collection in Folders
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeFolders(IXmlBBase obj)
  {
  int idx = indexOfFolders(obj);
  if (idx >= 0) { deleteFolders(idx);
NotifyControllers(null);
   }
  }

public void removeFolders(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfFolders(obj);
  if (idx >= 0) { deleteFolders(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Folders</summary>
/// <returns>the number of elements in Folders</returns>
public int countFolders()
  {
  return allFolders().Count;
  }

/// <summary>Part of the list interface for Folders
/// This function returns an element from the
/// collection in Folders based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Folder getFolders(int idx)
{
  return (Folder) ( allFolders()[idx]);
}

private System.Collections.ArrayList aTranslations;

/// <summary>Part of the list interface for Translations</summary>
/// <returns>a collection of all the elements in Translations</returns>
public System.Collections.ArrayList allTranslations()
  {
if (aTranslations == null){
    setAllTranslations( new System.Collections.ArrayList() );
} // If
    return aTranslations;
  }

/// <summary>Part of the list interface for Translations</summary>
/// <returns>a collection of all the elements in Translations</returns>
private System.Collections.ArrayList getTranslations()
  {
    return allTranslations();
  }

/// <summary>Part of the list interface for Translations</summary>
/// <param name="coll">a collection of elements which replaces 
///        Translations's current content.</param>
public void setAllTranslations(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aTranslations = coll;
    NotifyControllers(null);
  }
public void setAllTranslations(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aTranslations = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Translations</summary>
/// <param name="el">a Translation to add to the collection in 
///           Translations</param>
/// <seealso cref="appendTranslations(ICollection)"/>
public void appendTranslations(Translation el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allTranslations().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendTranslations(Lock aLock,Translation el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allTranslations().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Translations</summary>
/// <param name="coll">a collection ofTranslations to add to the collection in 
///           Translations</param>
/// <seealso cref="appendTranslations(Translation)"/>
public void appendTranslations(ICollection coll)
  {
  __setDirty(true);
  allTranslations().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendTranslations(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allTranslations().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Translations
/// This insertion function inserts a new element in the
/// collection in Translations</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertTranslations(int idx, Translation el)
  {
  __setDirty(true);
  allTranslations().Insert (idx, el);
NotifyControllers(null);
  }

public void insertTranslations(int idx, Translation el,Lock aLock)
  {
  __setDirty(true);
  allTranslations().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Translations
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfTranslations(IXmlBBase el)
  {
  return allTranslations().IndexOf (el);
  }

/// <summary>Part of the list interface for Translations
/// This deletion function removes an element from the
/// collection in Translations</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteTranslations(int idx)
  {
  __setDirty(true);
  allTranslations().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteTranslations(int idx,Lock aLock)
  {
  __setDirty(true);
  allTranslations().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Translations
/// This deletion function removes an element from the
/// collection in Translations
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeTranslations(IXmlBBase obj)
  {
  int idx = indexOfTranslations(obj);
  if (idx >= 0) { deleteTranslations(idx);
NotifyControllers(null);
   }
  }

public void removeTranslations(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfTranslations(obj);
  if (idx >= 0) { deleteTranslations(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Translations</summary>
/// <returns>the number of elements in Translations</returns>
public int countTranslations()
  {
  return allTranslations().Count;
  }

/// <summary>Part of the list interface for Translations
/// This function returns an element from the
/// collection in Translations based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Translation getTranslations(int idx)
{
  return (Translation) ( allTranslations()[idx]);
}

public Folder()
{
Folder obj = this;
aFolders=(null);
aTranslations=(null);
}

public void copyTo(Folder other)
{
base.copyTo(other);
other.aFolders = aFolders;
other.aTranslations = aTranslations;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
bool fl1131;
Folder fl1133;
bool fl1144;
Translation fl1146;

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Folders")){
ctxt.skipWhiteSpace();
fl1131 = true ; 
while (fl1131) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1131 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl1133 = null;
while(ctxt.lookAheadOpeningTag ("<Folder")) {
fl1133 = acceptor.lAccept_Folder(ctxt, "</Folder>");
appendFolders(fl1133);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Folders>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Translations")){
ctxt.skipWhiteSpace();
fl1144 = true ; 
while (fl1144) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1144 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl1146 = null;
while(ctxt.lookAheadOpeningTag ("<Translation")) {
fl1146 = acceptor.lAccept_Translation(ctxt, "</Translation>");
appendTranslations(fl1146);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Translations>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl1157;
bool fl1158;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl1157 = false ; 
fl1158 = true ; 
while (fl1158) { // BeginLoop 
if (ctxt.lookAheadString("Name=")){
indicator = 1157;
} else {
indicator = 1159;
} // If
switch (indicator) {
case 1157: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl1157){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl1157 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 1159: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1158 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<Folder";
  endingTag = "</Folder>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"Folder\"");
} // If
pw.Write('\n');
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing Enclosed
// Testing for empty content: Folders
if (countFolders() > 0){
pw.Write("<Folders>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getFolders(), false, "<Folder", "</Folder>");
pw.Write("</Folders>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Folders
// Unparsing Enclosed
// Testing for empty content: Translations
if (countTranslations() > 0){
pw.Write("<Translations>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getTranslations(), false, "<Translation", "</Translation>");
pw.Write("</Translations>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Translations
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
for (int i = 0; i < countFolders(); i++) {
  l.Add(getFolders(i));
}
for (int i = 0; i < countTranslations(); i++) {
  l.Add(getTranslations(i));
}
}

}
public partial class Translation
: DataDictionary.Namable
{
public  override  bool find(Object search){
if (search is String ) {
if(getComment().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.TranslationController.alertChange(aLock, this);
}
private System.Collections.ArrayList aSourceTexts;

/// <summary>Part of the list interface for SourceTexts</summary>
/// <returns>a collection of all the elements in SourceTexts</returns>
public System.Collections.ArrayList allSourceTexts()
  {
if (aSourceTexts == null){
    setAllSourceTexts( new System.Collections.ArrayList() );
} // If
    return aSourceTexts;
  }

/// <summary>Part of the list interface for SourceTexts</summary>
/// <returns>a collection of all the elements in SourceTexts</returns>
private System.Collections.ArrayList getSourceTexts()
  {
    return allSourceTexts();
  }

/// <summary>Part of the list interface for SourceTexts</summary>
/// <param name="coll">a collection of elements which replaces 
///        SourceTexts's current content.</param>
public void setAllSourceTexts(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aSourceTexts = coll;
    NotifyControllers(null);
  }
public void setAllSourceTexts(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aSourceTexts = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SourceTexts</summary>
/// <param name="el">a SourceText to add to the collection in 
///           SourceTexts</param>
/// <seealso cref="appendSourceTexts(ICollection)"/>
public void appendSourceTexts(SourceText el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allSourceTexts().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendSourceTexts(Lock aLock,SourceText el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allSourceTexts().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for SourceTexts</summary>
/// <param name="coll">a collection ofSourceTexts to add to the collection in 
///           SourceTexts</param>
/// <seealso cref="appendSourceTexts(SourceText)"/>
public void appendSourceTexts(ICollection coll)
  {
  __setDirty(true);
  allSourceTexts().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendSourceTexts(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allSourceTexts().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SourceTexts
/// This insertion function inserts a new element in the
/// collection in SourceTexts</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertSourceTexts(int idx, SourceText el)
  {
  __setDirty(true);
  allSourceTexts().Insert (idx, el);
NotifyControllers(null);
  }

public void insertSourceTexts(int idx, SourceText el,Lock aLock)
  {
  __setDirty(true);
  allSourceTexts().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SourceTexts
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfSourceTexts(IXmlBBase el)
  {
  return allSourceTexts().IndexOf (el);
  }

/// <summary>Part of the list interface for SourceTexts
/// This deletion function removes an element from the
/// collection in SourceTexts</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteSourceTexts(int idx)
  {
  __setDirty(true);
  allSourceTexts().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteSourceTexts(int idx,Lock aLock)
  {
  __setDirty(true);
  allSourceTexts().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SourceTexts
/// This deletion function removes an element from the
/// collection in SourceTexts
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeSourceTexts(IXmlBBase obj)
  {
  int idx = indexOfSourceTexts(obj);
  if (idx >= 0) { deleteSourceTexts(idx);
NotifyControllers(null);
   }
  }

public void removeSourceTexts(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfSourceTexts(obj);
  if (idx >= 0) { deleteSourceTexts(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for SourceTexts</summary>
/// <returns>the number of elements in SourceTexts</returns>
public int countSourceTexts()
  {
  return allSourceTexts().Count;
  }

/// <summary>Part of the list interface for SourceTexts
/// This function returns an element from the
/// collection in SourceTexts based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public SourceText getSourceTexts(int idx)
{
  return (SourceText) ( allSourceTexts()[idx]);
}

private  bool aImplemented;

public  bool getImplemented() { return aImplemented;}
public  void setImplemented(bool v) {
  aImplemented = v;
  __setDirty(true);
  NotifyControllers(null);
}

private System.Collections.ArrayList aSubSteps;

/// <summary>Part of the list interface for SubSteps</summary>
/// <returns>a collection of all the elements in SubSteps</returns>
public System.Collections.ArrayList allSubSteps()
  {
if (aSubSteps == null){
    setAllSubSteps( new System.Collections.ArrayList() );
} // If
    return aSubSteps;
  }

/// <summary>Part of the list interface for SubSteps</summary>
/// <returns>a collection of all the elements in SubSteps</returns>
private System.Collections.ArrayList getSubSteps()
  {
    return allSubSteps();
  }

/// <summary>Part of the list interface for SubSteps</summary>
/// <param name="coll">a collection of elements which replaces 
///        SubSteps's current content.</param>
public void setAllSubSteps(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aSubSteps = coll;
    NotifyControllers(null);
  }
public void setAllSubSteps(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aSubSteps = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SubSteps</summary>
/// <param name="el">a SubStep to add to the collection in 
///           SubSteps</param>
/// <seealso cref="appendSubSteps(ICollection)"/>
public void appendSubSteps(SubStep el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allSubSteps().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendSubSteps(Lock aLock,SubStep el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allSubSteps().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for SubSteps</summary>
/// <param name="coll">a collection ofSubSteps to add to the collection in 
///           SubSteps</param>
/// <seealso cref="appendSubSteps(SubStep)"/>
public void appendSubSteps(ICollection coll)
  {
  __setDirty(true);
  allSubSteps().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendSubSteps(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allSubSteps().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SubSteps
/// This insertion function inserts a new element in the
/// collection in SubSteps</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertSubSteps(int idx, SubStep el)
  {
  __setDirty(true);
  allSubSteps().Insert (idx, el);
NotifyControllers(null);
  }

public void insertSubSteps(int idx, SubStep el,Lock aLock)
  {
  __setDirty(true);
  allSubSteps().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SubSteps
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfSubSteps(IXmlBBase el)
  {
  return allSubSteps().IndexOf (el);
  }

/// <summary>Part of the list interface for SubSteps
/// This deletion function removes an element from the
/// collection in SubSteps</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteSubSteps(int idx)
  {
  __setDirty(true);
  allSubSteps().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteSubSteps(int idx,Lock aLock)
  {
  __setDirty(true);
  allSubSteps().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for SubSteps
/// This deletion function removes an element from the
/// collection in SubSteps
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeSubSteps(IXmlBBase obj)
  {
  int idx = indexOfSubSteps(obj);
  if (idx >= 0) { deleteSubSteps(idx);
NotifyControllers(null);
   }
  }

public void removeSubSteps(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfSubSteps(obj);
  if (idx >= 0) { deleteSubSteps(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for SubSteps</summary>
/// <returns>the number of elements in SubSteps</returns>
public int countSubSteps()
  {
  return allSubSteps().Count;
  }

/// <summary>Part of the list interface for SubSteps
/// This function returns an element from the
/// collection in SubSteps based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public SubStep getSubSteps(int idx)
{
  return (SubStep) ( allSubSteps()[idx]);
}

private   string  aComment;

public   string  getComment() { return aComment;}
public  void setComment( string  v) {
  aComment = v;
  __setDirty(true);
  NotifyControllers(null);
}

public Translation()
{
Translation obj = this;
aSourceTexts=(null);
aImplemented=(false);
aSubSteps=(null);
aComment=(null);
}

public void copyTo(Translation other)
{
base.copyTo(other);
other.aSourceTexts = aSourceTexts;
other.aImplemented = aImplemented;
other.aSubSteps = aSubSteps;
other.aComment = aComment;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
bool fl1161;
SourceText fl1163;
bool fl1174;
SubStep fl1176;
bool fl1187;

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<SourceTexts")){
ctxt.skipWhiteSpace();
fl1161 = true ; 
while (fl1161) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1161 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl1163 = null;
while(ctxt.lookAheadOpeningTag ("<SourceText")) {
fl1163 = acceptor.lAccept_SourceText(ctxt, "</SourceText>");
appendSourceTexts(fl1163);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</SourceTexts>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<SubSteps")){
ctxt.skipWhiteSpace();
fl1174 = true ; 
while (fl1174) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1174 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl1176 = null;
while(ctxt.lookAheadOpeningTag ("<SubStep")) {
fl1176 = acceptor.lAccept_SubStep(ctxt, "</SubStep>");
appendSubSteps(fl1176);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</SubSteps>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Comment")){
ctxt.skipWhiteSpace();
fl1187 = true ; 
while (fl1187) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1187 = false ; 
} // If
} // While
ctxt.accept('>');
// Indicator
// Parse PC data
this.setComment(acceptor.lAcceptPcData(ctxt, -1, '<',XmlBContext.WS_PRESERVE));
// Regexp
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Comment>");
} // If
// End enclosed
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl1188;
bool fl1189;
bool fl1190;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl1188 = false ; 
fl1189 = false ; 
fl1190 = true ; 
while (fl1190) { // BeginLoop 
switch (ctxt.current()) {
case 'N':
{
ctxt.advance();
if (ctxt.lookAheadString("ame=")){
indicator = 1189;
} else {
indicator = 1191;
} // If
break;
} // Case
case 'I':
{
ctxt.advance();
if (ctxt.lookAheadString("mplemented=")){
indicator = 1188;
} else {
indicator = 1191;
} // If
break;
} // Case
default:
indicator = 1191;
break;
} // Switch
switch (indicator) {
case 1188: {
// Handling attribute Implemented
// Also handles alien attributes with prefix Implemented
if (fl1188){
ctxt.fail ("Duplicate attribute: Implemented");
} // If
fl1188 = true ; 
quoteChar = ctxt.acceptQuote();
this.setImplemented(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1189: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl1189){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl1189 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 1191: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl1188){
this.setImplemented( false);
} // If
fl1190 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<Translation";
  endingTag = "</Translation>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"Translation\"");
} // If
pw.Write('\n');
if (this.getImplemented()){
pw.Write(" Implemented=\"");
acceptor.unParsePcData(pw, this.getImplemented());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing Enclosed
// Testing for empty content: SourceTexts
if (countSourceTexts() > 0){
pw.Write("<SourceTexts>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getSourceTexts(), false, "<SourceText", "</SourceText>");
pw.Write("</SourceTexts>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: SourceTexts
// Unparsing Enclosed
// Testing for empty content: SubSteps
if (countSubSteps() > 0){
pw.Write("<SubSteps>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getSubSteps(), false, "<SubStep", "</SubStep>");
pw.Write("</SubSteps>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: SubSteps
// Unparsing Enclosed
// Testing for empty content: Comment
if (this.getComment() != null){
pw.Write("<Comment>");
// Unparsing PcData
acceptor.unParsePcData(pw, this.getComment());
pw.Write("</Comment>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Comment
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
for (int i = 0; i < countSourceTexts(); i++) {
  l.Add(getSourceTexts(i));
}
for (int i = 0; i < countSubSteps(); i++) {
  l.Add(getSubSteps(i));
}
}

}
public partial class SourceText
: DataDictionary.Namable
{
public  override  bool find(Object search){
if (search is String ) {
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.SourceTextController.alertChange(aLock, this);
}
public SourceText()
{
SourceText obj = this;
}

public void copyTo(SourceText other)
{
base.copyTo(other);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl1195;
bool fl1196;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl1195 = false ; 
fl1196 = true ; 
while (fl1196) { // BeginLoop 
if (ctxt.lookAheadString("Name=")){
indicator = 1195;
} else {
indicator = 1197;
} // If
switch (indicator) {
case 1195: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl1195){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl1195 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 1197: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1196 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<SourceText";
  endingTag = "</SourceText>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"SourceText\"");
} // If
pw.Write('\n');
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
}

}
public partial class ShortcutDictionary
: DataDictionary.Namable
{
public  override  bool find(Object search){
if (search is String ) {
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.ShortcutDictionaryController.alertChange(aLock, this);
}
private System.Collections.ArrayList aFolders;

/// <summary>Part of the list interface for Folders</summary>
/// <returns>a collection of all the elements in Folders</returns>
public System.Collections.ArrayList allFolders()
  {
if (aFolders == null){
    setAllFolders( new System.Collections.ArrayList() );
} // If
    return aFolders;
  }

/// <summary>Part of the list interface for Folders</summary>
/// <returns>a collection of all the elements in Folders</returns>
private System.Collections.ArrayList getFolders()
  {
    return allFolders();
  }

/// <summary>Part of the list interface for Folders</summary>
/// <param name="coll">a collection of elements which replaces 
///        Folders's current content.</param>
public void setAllFolders(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aFolders = coll;
    NotifyControllers(null);
  }
public void setAllFolders(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aFolders = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Folders</summary>
/// <param name="el">a ShortcutFolder to add to the collection in 
///           Folders</param>
/// <seealso cref="appendFolders(ICollection)"/>
public void appendFolders(ShortcutFolder el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allFolders().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendFolders(Lock aLock,ShortcutFolder el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allFolders().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Folders</summary>
/// <param name="coll">a collection ofShortcutFolders to add to the collection in 
///           Folders</param>
/// <seealso cref="appendFolders(ShortcutFolder)"/>
public void appendFolders(ICollection coll)
  {
  __setDirty(true);
  allFolders().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendFolders(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allFolders().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Folders
/// This insertion function inserts a new element in the
/// collection in Folders</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertFolders(int idx, ShortcutFolder el)
  {
  __setDirty(true);
  allFolders().Insert (idx, el);
NotifyControllers(null);
  }

public void insertFolders(int idx, ShortcutFolder el,Lock aLock)
  {
  __setDirty(true);
  allFolders().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Folders
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfFolders(IXmlBBase el)
  {
  return allFolders().IndexOf (el);
  }

/// <summary>Part of the list interface for Folders
/// This deletion function removes an element from the
/// collection in Folders</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteFolders(int idx)
  {
  __setDirty(true);
  allFolders().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteFolders(int idx,Lock aLock)
  {
  __setDirty(true);
  allFolders().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Folders
/// This deletion function removes an element from the
/// collection in Folders
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeFolders(IXmlBBase obj)
  {
  int idx = indexOfFolders(obj);
  if (idx >= 0) { deleteFolders(idx);
NotifyControllers(null);
   }
  }

public void removeFolders(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfFolders(obj);
  if (idx >= 0) { deleteFolders(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Folders</summary>
/// <returns>the number of elements in Folders</returns>
public int countFolders()
  {
  return allFolders().Count;
  }

/// <summary>Part of the list interface for Folders
/// This function returns an element from the
/// collection in Folders based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public ShortcutFolder getFolders(int idx)
{
  return (ShortcutFolder) ( allFolders()[idx]);
}

private System.Collections.ArrayList aShortcuts;

/// <summary>Part of the list interface for Shortcuts</summary>
/// <returns>a collection of all the elements in Shortcuts</returns>
public System.Collections.ArrayList allShortcuts()
  {
if (aShortcuts == null){
    setAllShortcuts( new System.Collections.ArrayList() );
} // If
    return aShortcuts;
  }

/// <summary>Part of the list interface for Shortcuts</summary>
/// <returns>a collection of all the elements in Shortcuts</returns>
private System.Collections.ArrayList getShortcuts()
  {
    return allShortcuts();
  }

/// <summary>Part of the list interface for Shortcuts</summary>
/// <param name="coll">a collection of elements which replaces 
///        Shortcuts's current content.</param>
public void setAllShortcuts(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aShortcuts = coll;
    NotifyControllers(null);
  }
public void setAllShortcuts(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aShortcuts = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Shortcuts</summary>
/// <param name="el">a Shortcut to add to the collection in 
///           Shortcuts</param>
/// <seealso cref="appendShortcuts(ICollection)"/>
public void appendShortcuts(Shortcut el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allShortcuts().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendShortcuts(Lock aLock,Shortcut el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allShortcuts().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Shortcuts</summary>
/// <param name="coll">a collection ofShortcuts to add to the collection in 
///           Shortcuts</param>
/// <seealso cref="appendShortcuts(Shortcut)"/>
public void appendShortcuts(ICollection coll)
  {
  __setDirty(true);
  allShortcuts().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendShortcuts(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allShortcuts().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Shortcuts
/// This insertion function inserts a new element in the
/// collection in Shortcuts</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertShortcuts(int idx, Shortcut el)
  {
  __setDirty(true);
  allShortcuts().Insert (idx, el);
NotifyControllers(null);
  }

public void insertShortcuts(int idx, Shortcut el,Lock aLock)
  {
  __setDirty(true);
  allShortcuts().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Shortcuts
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfShortcuts(IXmlBBase el)
  {
  return allShortcuts().IndexOf (el);
  }

/// <summary>Part of the list interface for Shortcuts
/// This deletion function removes an element from the
/// collection in Shortcuts</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteShortcuts(int idx)
  {
  __setDirty(true);
  allShortcuts().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteShortcuts(int idx,Lock aLock)
  {
  __setDirty(true);
  allShortcuts().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Shortcuts
/// This deletion function removes an element from the
/// collection in Shortcuts
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeShortcuts(IXmlBBase obj)
  {
  int idx = indexOfShortcuts(obj);
  if (idx >= 0) { deleteShortcuts(idx);
NotifyControllers(null);
   }
  }

public void removeShortcuts(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfShortcuts(obj);
  if (idx >= 0) { deleteShortcuts(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Shortcuts</summary>
/// <returns>the number of elements in Shortcuts</returns>
public int countShortcuts()
  {
  return allShortcuts().Count;
  }

/// <summary>Part of the list interface for Shortcuts
/// This function returns an element from the
/// collection in Shortcuts based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Shortcut getShortcuts(int idx)
{
  return (Shortcut) ( allShortcuts()[idx]);
}

public ShortcutDictionary()
{
ShortcutDictionary obj = this;
aFolders=(null);
aShortcuts=(null);
}

public void copyTo(ShortcutDictionary other)
{
base.copyTo(other);
other.aFolders = aFolders;
other.aShortcuts = aShortcuts;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
bool fl1199;
ShortcutFolder fl1201;
bool fl1212;
Shortcut fl1214;

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Folders")){
ctxt.skipWhiteSpace();
fl1199 = true ; 
while (fl1199) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1199 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl1201 = null;
while(ctxt.lookAheadOpeningTag ("<ShortcutFolder")) {
fl1201 = acceptor.lAccept_ShortcutFolder(ctxt, "</ShortcutFolder>");
appendFolders(fl1201);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Folders>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Shortcuts")){
ctxt.skipWhiteSpace();
fl1212 = true ; 
while (fl1212) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1212 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl1214 = null;
while(ctxt.lookAheadOpeningTag ("<Shortcut")) {
fl1214 = acceptor.lAccept_Shortcut(ctxt, "</Shortcut>");
appendShortcuts(fl1214);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Shortcuts>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl1225;
bool fl1226;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl1225 = false ; 
fl1226 = true ; 
while (fl1226) { // BeginLoop 
if (ctxt.lookAheadString("Name=")){
indicator = 1225;
} else {
indicator = 1227;
} // If
switch (indicator) {
case 1225: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl1225){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl1225 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 1227: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1226 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<ShortcutDictionary";
  endingTag = "</ShortcutDictionary>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"ShortcutDictionary\"");
} // If
pw.Write('\n');
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing Enclosed
// Testing for empty content: Folders
if (countFolders() > 0){
pw.Write("<Folders>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getFolders(), false, "<ShortcutFolder", "</ShortcutFolder>");
pw.Write("</Folders>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Folders
// Unparsing Enclosed
// Testing for empty content: Shortcuts
if (countShortcuts() > 0){
pw.Write("<Shortcuts>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getShortcuts(), false, "<Shortcut", "</Shortcut>");
pw.Write("</Shortcuts>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Shortcuts
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
for (int i = 0; i < countFolders(); i++) {
  l.Add(getFolders(i));
}
for (int i = 0; i < countShortcuts(); i++) {
  l.Add(getShortcuts(i));
}
}

}
public partial class ShortcutFolder
: DataDictionary.Namable
{
public  override  bool find(Object search){
if (search is String ) {
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.ShortcutFolderController.alertChange(aLock, this);
}
private System.Collections.ArrayList aFolders;

/// <summary>Part of the list interface for Folders</summary>
/// <returns>a collection of all the elements in Folders</returns>
public System.Collections.ArrayList allFolders()
  {
if (aFolders == null){
    setAllFolders( new System.Collections.ArrayList() );
} // If
    return aFolders;
  }

/// <summary>Part of the list interface for Folders</summary>
/// <returns>a collection of all the elements in Folders</returns>
private System.Collections.ArrayList getFolders()
  {
    return allFolders();
  }

/// <summary>Part of the list interface for Folders</summary>
/// <param name="coll">a collection of elements which replaces 
///        Folders's current content.</param>
public void setAllFolders(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aFolders = coll;
    NotifyControllers(null);
  }
public void setAllFolders(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aFolders = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Folders</summary>
/// <param name="el">a ShortcutFolder to add to the collection in 
///           Folders</param>
/// <seealso cref="appendFolders(ICollection)"/>
public void appendFolders(ShortcutFolder el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allFolders().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendFolders(Lock aLock,ShortcutFolder el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allFolders().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Folders</summary>
/// <param name="coll">a collection ofShortcutFolders to add to the collection in 
///           Folders</param>
/// <seealso cref="appendFolders(ShortcutFolder)"/>
public void appendFolders(ICollection coll)
  {
  __setDirty(true);
  allFolders().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendFolders(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allFolders().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Folders
/// This insertion function inserts a new element in the
/// collection in Folders</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertFolders(int idx, ShortcutFolder el)
  {
  __setDirty(true);
  allFolders().Insert (idx, el);
NotifyControllers(null);
  }

public void insertFolders(int idx, ShortcutFolder el,Lock aLock)
  {
  __setDirty(true);
  allFolders().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Folders
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfFolders(IXmlBBase el)
  {
  return allFolders().IndexOf (el);
  }

/// <summary>Part of the list interface for Folders
/// This deletion function removes an element from the
/// collection in Folders</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteFolders(int idx)
  {
  __setDirty(true);
  allFolders().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteFolders(int idx,Lock aLock)
  {
  __setDirty(true);
  allFolders().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Folders
/// This deletion function removes an element from the
/// collection in Folders
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeFolders(IXmlBBase obj)
  {
  int idx = indexOfFolders(obj);
  if (idx >= 0) { deleteFolders(idx);
NotifyControllers(null);
   }
  }

public void removeFolders(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfFolders(obj);
  if (idx >= 0) { deleteFolders(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Folders</summary>
/// <returns>the number of elements in Folders</returns>
public int countFolders()
  {
  return allFolders().Count;
  }

/// <summary>Part of the list interface for Folders
/// This function returns an element from the
/// collection in Folders based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public ShortcutFolder getFolders(int idx)
{
  return (ShortcutFolder) ( allFolders()[idx]);
}

private System.Collections.ArrayList aShortcuts;

/// <summary>Part of the list interface for Shortcuts</summary>
/// <returns>a collection of all the elements in Shortcuts</returns>
public System.Collections.ArrayList allShortcuts()
  {
if (aShortcuts == null){
    setAllShortcuts( new System.Collections.ArrayList() );
} // If
    return aShortcuts;
  }

/// <summary>Part of the list interface for Shortcuts</summary>
/// <returns>a collection of all the elements in Shortcuts</returns>
private System.Collections.ArrayList getShortcuts()
  {
    return allShortcuts();
  }

/// <summary>Part of the list interface for Shortcuts</summary>
/// <param name="coll">a collection of elements which replaces 
///        Shortcuts's current content.</param>
public void setAllShortcuts(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aShortcuts = coll;
    NotifyControllers(null);
  }
public void setAllShortcuts(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aShortcuts = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Shortcuts</summary>
/// <param name="el">a Shortcut to add to the collection in 
///           Shortcuts</param>
/// <seealso cref="appendShortcuts(ICollection)"/>
public void appendShortcuts(Shortcut el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allShortcuts().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendShortcuts(Lock aLock,Shortcut el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allShortcuts().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Shortcuts</summary>
/// <param name="coll">a collection ofShortcuts to add to the collection in 
///           Shortcuts</param>
/// <seealso cref="appendShortcuts(Shortcut)"/>
public void appendShortcuts(ICollection coll)
  {
  __setDirty(true);
  allShortcuts().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendShortcuts(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allShortcuts().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Shortcuts
/// This insertion function inserts a new element in the
/// collection in Shortcuts</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertShortcuts(int idx, Shortcut el)
  {
  __setDirty(true);
  allShortcuts().Insert (idx, el);
NotifyControllers(null);
  }

public void insertShortcuts(int idx, Shortcut el,Lock aLock)
  {
  __setDirty(true);
  allShortcuts().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Shortcuts
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfShortcuts(IXmlBBase el)
  {
  return allShortcuts().IndexOf (el);
  }

/// <summary>Part of the list interface for Shortcuts
/// This deletion function removes an element from the
/// collection in Shortcuts</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteShortcuts(int idx)
  {
  __setDirty(true);
  allShortcuts().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteShortcuts(int idx,Lock aLock)
  {
  __setDirty(true);
  allShortcuts().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Shortcuts
/// This deletion function removes an element from the
/// collection in Shortcuts
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeShortcuts(IXmlBBase obj)
  {
  int idx = indexOfShortcuts(obj);
  if (idx >= 0) { deleteShortcuts(idx);
NotifyControllers(null);
   }
  }

public void removeShortcuts(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfShortcuts(obj);
  if (idx >= 0) { deleteShortcuts(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Shortcuts</summary>
/// <returns>the number of elements in Shortcuts</returns>
public int countShortcuts()
  {
  return allShortcuts().Count;
  }

/// <summary>Part of the list interface for Shortcuts
/// This function returns an element from the
/// collection in Shortcuts based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Shortcut getShortcuts(int idx)
{
  return (Shortcut) ( allShortcuts()[idx]);
}

public ShortcutFolder()
{
ShortcutFolder obj = this;
aFolders=(null);
aShortcuts=(null);
}

public void copyTo(ShortcutFolder other)
{
base.copyTo(other);
other.aFolders = aFolders;
other.aShortcuts = aShortcuts;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
bool fl1229;
ShortcutFolder fl1231;
bool fl1242;
Shortcut fl1244;

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Folders")){
ctxt.skipWhiteSpace();
fl1229 = true ; 
while (fl1229) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1229 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl1231 = null;
while(ctxt.lookAheadOpeningTag ("<ShortcutFolder")) {
fl1231 = acceptor.lAccept_ShortcutFolder(ctxt, "</ShortcutFolder>");
appendFolders(fl1231);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Folders>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Shortcuts")){
ctxt.skipWhiteSpace();
fl1242 = true ; 
while (fl1242) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1242 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl1244 = null;
while(ctxt.lookAheadOpeningTag ("<Shortcut")) {
fl1244 = acceptor.lAccept_Shortcut(ctxt, "</Shortcut>");
appendShortcuts(fl1244);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Shortcuts>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl1255;
bool fl1256;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl1255 = false ; 
fl1256 = true ; 
while (fl1256) { // BeginLoop 
if (ctxt.lookAheadString("Name=")){
indicator = 1255;
} else {
indicator = 1257;
} // If
switch (indicator) {
case 1255: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl1255){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl1255 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 1257: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1256 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<ShortcutFolder";
  endingTag = "</ShortcutFolder>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"ShortcutFolder\"");
} // If
pw.Write('\n');
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing Enclosed
// Testing for empty content: Folders
if (countFolders() > 0){
pw.Write("<Folders>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getFolders(), false, "<ShortcutFolder", "</ShortcutFolder>");
pw.Write("</Folders>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Folders
// Unparsing Enclosed
// Testing for empty content: Shortcuts
if (countShortcuts() > 0){
pw.Write("<Shortcuts>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getShortcuts(), false, "<Shortcut", "</Shortcut>");
pw.Write("</Shortcuts>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Shortcuts
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
for (int i = 0; i < countFolders(); i++) {
  l.Add(getFolders(i));
}
for (int i = 0; i < countShortcuts(); i++) {
  l.Add(getShortcuts(i));
}
}

}
public partial class Shortcut
: DataDictionary.Namable
{
public  override  bool find(Object search){
if (search is String ) {
if(getShortcutName().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.ShortcutController.alertChange(aLock, this);
}
private   string  aShortcutName;

public   string  getShortcutName() { return aShortcutName;}
public  void setShortcutName( string  v) {
  aShortcutName = v;
  __setDirty(true);
  NotifyControllers(null);
}

public Shortcut()
{
Shortcut obj = this;
aShortcutName=(null);
}

public void copyTo(Shortcut other)
{
base.copyTo(other);
other.aShortcutName = aShortcutName;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
bool fl1259;

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<ShortcutName")){
ctxt.skipWhiteSpace();
fl1259 = true ; 
while (fl1259) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1259 = false ; 
} // If
} // While
ctxt.accept('>');
// Indicator
// Parse PC data
this.setShortcutName(acceptor.lAcceptPcData(ctxt, -1, '<',XmlBContext.WS_PRESERVE));
// Regexp
ctxt.skipWhiteSpace();
ctxt.acceptString ("</ShortcutName>");
} // If
// End enclosed
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl1260;
bool fl1261;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl1260 = false ; 
fl1261 = true ; 
while (fl1261) { // BeginLoop 
if (ctxt.lookAheadString("Name=")){
indicator = 1260;
} else {
indicator = 1262;
} // If
switch (indicator) {
case 1260: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl1260){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl1260 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 1262: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1261 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<Shortcut";
  endingTag = "</Shortcut>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"Shortcut\"");
} // If
pw.Write('\n');
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing Enclosed
// Testing for empty content: ShortcutName
if (this.getShortcutName() != null){
pw.Write("<ShortcutName>");
// Unparsing PcData
acceptor.unParsePcData(pw, this.getShortcutName());
pw.Write("</ShortcutName>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: ShortcutName
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
}

}
public partial class Specification
: DataDictionary.Namable
{
public  override  bool find(Object search){
if (search is String ) {
if(getVersion().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.SpecificationController.alertChange(aLock, this);
}
private   string  aVersion;

public   string  getVersion() { return aVersion;}
public  void setVersion( string  v) {
  aVersion = v;
  __setDirty(true);
  NotifyControllers(null);
}

private System.Collections.ArrayList aChapters;

/// <summary>Part of the list interface for Chapters</summary>
/// <returns>a collection of all the elements in Chapters</returns>
public System.Collections.ArrayList allChapters()
  {
if (aChapters == null){
    setAllChapters( new System.Collections.ArrayList() );
} // If
    return aChapters;
  }

/// <summary>Part of the list interface for Chapters</summary>
/// <returns>a collection of all the elements in Chapters</returns>
private System.Collections.ArrayList getChapters()
  {
    return allChapters();
  }

/// <summary>Part of the list interface for Chapters</summary>
/// <param name="coll">a collection of elements which replaces 
///        Chapters's current content.</param>
public void setAllChapters(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aChapters = coll;
    NotifyControllers(null);
  }
public void setAllChapters(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aChapters = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Chapters</summary>
/// <param name="el">a Chapter to add to the collection in 
///           Chapters</param>
/// <seealso cref="appendChapters(ICollection)"/>
public void appendChapters(Chapter el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allChapters().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendChapters(Lock aLock,Chapter el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allChapters().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Chapters</summary>
/// <param name="coll">a collection ofChapters to add to the collection in 
///           Chapters</param>
/// <seealso cref="appendChapters(Chapter)"/>
public void appendChapters(ICollection coll)
  {
  __setDirty(true);
  allChapters().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendChapters(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allChapters().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Chapters
/// This insertion function inserts a new element in the
/// collection in Chapters</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertChapters(int idx, Chapter el)
  {
  __setDirty(true);
  allChapters().Insert (idx, el);
NotifyControllers(null);
  }

public void insertChapters(int idx, Chapter el,Lock aLock)
  {
  __setDirty(true);
  allChapters().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Chapters
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfChapters(IXmlBBase el)
  {
  return allChapters().IndexOf (el);
  }

/// <summary>Part of the list interface for Chapters
/// This deletion function removes an element from the
/// collection in Chapters</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteChapters(int idx)
  {
  __setDirty(true);
  allChapters().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteChapters(int idx,Lock aLock)
  {
  __setDirty(true);
  allChapters().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Chapters
/// This deletion function removes an element from the
/// collection in Chapters
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeChapters(IXmlBBase obj)
  {
  int idx = indexOfChapters(obj);
  if (idx >= 0) { deleteChapters(idx);
NotifyControllers(null);
   }
  }

public void removeChapters(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfChapters(obj);
  if (idx >= 0) { deleteChapters(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Chapters</summary>
/// <returns>the number of elements in Chapters</returns>
public int countChapters()
  {
  return allChapters().Count;
  }

/// <summary>Part of the list interface for Chapters
/// This function returns an element from the
/// collection in Chapters based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Chapter getChapters(int idx)
{
  return (Chapter) ( allChapters()[idx]);
}

public Specification()
{
Specification obj = this;
aVersion=(null);
aChapters=(null);
}

public void copyTo(Specification other)
{
base.copyTo(other);
other.aVersion = aVersion;
other.aChapters = aChapters;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
Chapter fl1265;

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
// Repeat
ctxt.skipWhiteSpace();
fl1265 = null;
while(ctxt.lookAheadOpeningTag ("<Chapter")) {
fl1265 = acceptor.lAccept_Chapter(ctxt, "</Chapter>");
appendChapters(fl1265);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl1276;
bool fl1277;
bool fl1278;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl1276 = false ; 
fl1277 = false ; 
fl1278 = true ; 
while (fl1278) { // BeginLoop 
switch (ctxt.current()) {
case 'v':
{
ctxt.advance();
if (ctxt.lookAheadString("ersion=")){
indicator = 1276;
} else {
indicator = 1279;
} // If
break;
} // Case
case 'N':
{
ctxt.advance();
if (ctxt.lookAheadString("ame=")){
indicator = 1277;
} else {
indicator = 1279;
} // If
break;
} // Case
default:
indicator = 1279;
break;
} // Switch
switch (indicator) {
case 1276: {
// Handling attribute version
// Also handles alien attributes with prefix version
if (fl1276){
ctxt.fail ("Duplicate attribute: version");
} // If
fl1276 = true ; 
quoteChar = ctxt.acceptQuote();
this.setVersion((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1277: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl1277){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl1277 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 1279: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1278 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<Specification";
  endingTag = "</Specification>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"Specification\"");
} // If
pw.Write('\n');
if (this.getVersion() != null){
pw.Write(" version=\"");
acceptor.unParsePcData(pw, this.getVersion());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getChapters(), false, "<Chapter", "</Chapter>");
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
for (int i = 0; i < countChapters(); i++) {
  l.Add(getChapters(i));
}
}

}
public partial class Chapter
: DataDictionary.Namable
{
public  override  bool find(Object search){
if (search is String ) {
if(getId().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.ChapterController.alertChange(aLock, this);
}
private   string  aId;

public   string  getId() { return aId;}
public  void setId( string  v) {
  aId = v;
  __setDirty(true);
  NotifyControllers(null);
}

private System.Collections.ArrayList aParagraphs;

/// <summary>Part of the list interface for Paragraphs</summary>
/// <returns>a collection of all the elements in Paragraphs</returns>
public System.Collections.ArrayList allParagraphs()
  {
if (aParagraphs == null){
    setAllParagraphs( new System.Collections.ArrayList() );
} // If
    return aParagraphs;
  }

/// <summary>Part of the list interface for Paragraphs</summary>
/// <returns>a collection of all the elements in Paragraphs</returns>
private System.Collections.ArrayList getParagraphs()
  {
    return allParagraphs();
  }

/// <summary>Part of the list interface for Paragraphs</summary>
/// <param name="coll">a collection of elements which replaces 
///        Paragraphs's current content.</param>
public void setAllParagraphs(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aParagraphs = coll;
    NotifyControllers(null);
  }
public void setAllParagraphs(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aParagraphs = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Paragraphs</summary>
/// <param name="el">a Paragraph to add to the collection in 
///           Paragraphs</param>
/// <seealso cref="appendParagraphs(ICollection)"/>
public void appendParagraphs(Paragraph el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allParagraphs().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendParagraphs(Lock aLock,Paragraph el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allParagraphs().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Paragraphs</summary>
/// <param name="coll">a collection ofParagraphs to add to the collection in 
///           Paragraphs</param>
/// <seealso cref="appendParagraphs(Paragraph)"/>
public void appendParagraphs(ICollection coll)
  {
  __setDirty(true);
  allParagraphs().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendParagraphs(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allParagraphs().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Paragraphs
/// This insertion function inserts a new element in the
/// collection in Paragraphs</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertParagraphs(int idx, Paragraph el)
  {
  __setDirty(true);
  allParagraphs().Insert (idx, el);
NotifyControllers(null);
  }

public void insertParagraphs(int idx, Paragraph el,Lock aLock)
  {
  __setDirty(true);
  allParagraphs().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Paragraphs
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfParagraphs(IXmlBBase el)
  {
  return allParagraphs().IndexOf (el);
  }

/// <summary>Part of the list interface for Paragraphs
/// This deletion function removes an element from the
/// collection in Paragraphs</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteParagraphs(int idx)
  {
  __setDirty(true);
  allParagraphs().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteParagraphs(int idx,Lock aLock)
  {
  __setDirty(true);
  allParagraphs().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Paragraphs
/// This deletion function removes an element from the
/// collection in Paragraphs
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeParagraphs(IXmlBBase obj)
  {
  int idx = indexOfParagraphs(obj);
  if (idx >= 0) { deleteParagraphs(idx);
NotifyControllers(null);
   }
  }

public void removeParagraphs(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfParagraphs(obj);
  if (idx >= 0) { deleteParagraphs(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Paragraphs</summary>
/// <returns>the number of elements in Paragraphs</returns>
public int countParagraphs()
  {
  return allParagraphs().Count;
  }

/// <summary>Part of the list interface for Paragraphs
/// This function returns an element from the
/// collection in Paragraphs based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Paragraph getParagraphs(int idx)
{
  return (Paragraph) ( allParagraphs()[idx]);
}

private System.Collections.ArrayList aTypeSpecs;

/// <summary>Part of the list interface for TypeSpecs</summary>
/// <returns>a collection of all the elements in TypeSpecs</returns>
public System.Collections.ArrayList allTypeSpecs()
  {
if (aTypeSpecs == null){
    setAllTypeSpecs( new System.Collections.ArrayList() );
} // If
    return aTypeSpecs;
  }

/// <summary>Part of the list interface for TypeSpecs</summary>
/// <returns>a collection of all the elements in TypeSpecs</returns>
private System.Collections.ArrayList getTypeSpecs()
  {
    return allTypeSpecs();
  }

/// <summary>Part of the list interface for TypeSpecs</summary>
/// <param name="coll">a collection of elements which replaces 
///        TypeSpecs's current content.</param>
public void setAllTypeSpecs(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aTypeSpecs = coll;
    NotifyControllers(null);
  }
public void setAllTypeSpecs(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aTypeSpecs = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for TypeSpecs</summary>
/// <param name="el">a TypeSpec to add to the collection in 
///           TypeSpecs</param>
/// <seealso cref="appendTypeSpecs(ICollection)"/>
public void appendTypeSpecs(TypeSpec el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allTypeSpecs().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendTypeSpecs(Lock aLock,TypeSpec el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allTypeSpecs().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for TypeSpecs</summary>
/// <param name="coll">a collection ofTypeSpecs to add to the collection in 
///           TypeSpecs</param>
/// <seealso cref="appendTypeSpecs(TypeSpec)"/>
public void appendTypeSpecs(ICollection coll)
  {
  __setDirty(true);
  allTypeSpecs().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendTypeSpecs(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allTypeSpecs().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for TypeSpecs
/// This insertion function inserts a new element in the
/// collection in TypeSpecs</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertTypeSpecs(int idx, TypeSpec el)
  {
  __setDirty(true);
  allTypeSpecs().Insert (idx, el);
NotifyControllers(null);
  }

public void insertTypeSpecs(int idx, TypeSpec el,Lock aLock)
  {
  __setDirty(true);
  allTypeSpecs().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for TypeSpecs
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfTypeSpecs(IXmlBBase el)
  {
  return allTypeSpecs().IndexOf (el);
  }

/// <summary>Part of the list interface for TypeSpecs
/// This deletion function removes an element from the
/// collection in TypeSpecs</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteTypeSpecs(int idx)
  {
  __setDirty(true);
  allTypeSpecs().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteTypeSpecs(int idx,Lock aLock)
  {
  __setDirty(true);
  allTypeSpecs().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for TypeSpecs
/// This deletion function removes an element from the
/// collection in TypeSpecs
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeTypeSpecs(IXmlBBase obj)
  {
  int idx = indexOfTypeSpecs(obj);
  if (idx >= 0) { deleteTypeSpecs(idx);
NotifyControllers(null);
   }
  }

public void removeTypeSpecs(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfTypeSpecs(obj);
  if (idx >= 0) { deleteTypeSpecs(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for TypeSpecs</summary>
/// <returns>the number of elements in TypeSpecs</returns>
public int countTypeSpecs()
  {
  return allTypeSpecs().Count;
  }

/// <summary>Part of the list interface for TypeSpecs
/// This function returns an element from the
/// collection in TypeSpecs based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public TypeSpec getTypeSpecs(int idx)
{
  return (TypeSpec) ( allTypeSpecs()[idx]);
}

public Chapter()
{
Chapter obj = this;
aId=(null);
aParagraphs=(null);
aTypeSpecs=(null);
}

public void copyTo(Chapter other)
{
base.copyTo(other);
other.aId = aId;
other.aParagraphs = aParagraphs;
other.aTypeSpecs = aTypeSpecs;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
Paragraph fl1284;
TypeSpec fl1296;

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
// Repeat
ctxt.skipWhiteSpace();
fl1284 = null;
while(ctxt.lookAheadOpeningTag ("<Paragraph")) {
fl1284 = acceptor.lAccept_Paragraph(ctxt, "</Paragraph>");
appendParagraphs(fl1284);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
// Repeat
ctxt.skipWhiteSpace();
fl1296 = null;
while(ctxt.lookAheadOpeningTag ("<TypeSpec")) {
fl1296 = acceptor.lAccept_TypeSpec(ctxt, null);
appendTypeSpecs(fl1296);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl1307;
bool fl1308;
bool fl1309;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl1307 = false ; 
fl1308 = false ; 
fl1309 = true ; 
while (fl1309) { // BeginLoop 
switch (ctxt.current()) {
case 'i':
{
ctxt.advance();
if (ctxt.lookAhead2('d','=')){
indicator = 1307;
} else {
indicator = 1310;
} // If
break;
} // Case
case 'N':
{
ctxt.advance();
if (ctxt.lookAheadString("ame=")){
indicator = 1308;
} else {
indicator = 1310;
} // If
break;
} // Case
default:
indicator = 1310;
break;
} // Switch
switch (indicator) {
case 1307: {
// Handling attribute id
// Also handles alien attributes with prefix id
if (fl1307){
ctxt.fail ("Duplicate attribute: id");
} // If
fl1307 = true ; 
quoteChar = ctxt.acceptQuote();
this.setId((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1308: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl1308){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl1308 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 1310: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl1307){
ctxt.fail ("Mandatory attribute missing: id in Chapter");
} // If
fl1309 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<Chapter";
  endingTag = "</Chapter>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"Chapter\"");
} // If
pw.Write('\n');
pw.Write(" id=\"");
acceptor.unParsePcData(pw, this.getId());
pw.Write('"');
pw.Write('\n');
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getParagraphs(), false, "<Paragraph", "</Paragraph>");
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getTypeSpecs(), false, null, null);
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
for (int i = 0; i < countParagraphs(); i++) {
  l.Add(getParagraphs(i));
}
for (int i = 0; i < countTypeSpecs(); i++) {
  l.Add(getTypeSpecs(i));
}
}

}
public partial class Paragraph
: DataDictionary.ReferencesParagraph
{
public  override  bool find(Object search){
if (search is String ) {
if(getId().CompareTo((String) search) == 0)return true;
if(getBl().CompareTo((String) search) == 0)return true;
if(getText().CompareTo((String) search) == 0)return true;
if(getVersion().CompareTo((String) search) == 0)return true;
if(getFunctionalBlockName().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.ParagraphController.alertChange(aLock, this);
}
private   string  aId;

public   string  getId() { return aId;}
public  void setId( string  v) {
  aId = v;
  __setDirty(true);
  NotifyControllers(null);
}

private  acceptor.Paragraph_type aType;

public  acceptor.Paragraph_type getType() { return aType;}
public  void setType(acceptor.Paragraph_type v) {
  aType = v;
  __setDirty(true);
  NotifyControllers(null);
}

public  string   getType_AsString()
{
  return acceptor.Enum_Paragraph_type_ToString (aType);
}

public  bool setType_AsString( string  v)
{
 acceptor.Paragraph_type  temp = acceptor.StringTo_Enum_Paragraph_type(v);
if (temp >= 0){
  aType = temp;
  __setDirty(true);
  NotifyControllers(null);
  return true;
} // If
return false;
}

private  acceptor.Paragraph_scope aScope;

public  acceptor.Paragraph_scope getScope() { return aScope;}
public  void setScope(acceptor.Paragraph_scope v) {
  aScope = v;
  __setDirty(true);
  NotifyControllers(null);
}

public  string   getScope_AsString()
{
  return acceptor.Enum_Paragraph_scope_ToString (aScope);
}

public  bool setScope_AsString( string  v)
{
 acceptor.Paragraph_scope  temp = acceptor.StringTo_Enum_Paragraph_scope(v);
if (temp >= 0){
  aScope = temp;
  __setDirty(true);
  NotifyControllers(null);
  return true;
} // If
return false;
}

private   string  aBl;

public   string  getBl() { return aBl;}
public  void setBl( string  v) {
  aBl = v;
  __setDirty(true);
  NotifyControllers(null);
}

private  bool aOptional;

public  bool getOptional() { return aOptional;}
public  void setOptional(bool v) {
  aOptional = v;
  __setDirty(true);
  NotifyControllers(null);
}

private System.Collections.ArrayList aTypeSpecs;

/// <summary>Part of the list interface for TypeSpecs</summary>
/// <returns>a collection of all the elements in TypeSpecs</returns>
public System.Collections.ArrayList allTypeSpecs()
  {
if (aTypeSpecs == null){
    setAllTypeSpecs( new System.Collections.ArrayList() );
} // If
    return aTypeSpecs;
  }

/// <summary>Part of the list interface for TypeSpecs</summary>
/// <returns>a collection of all the elements in TypeSpecs</returns>
private System.Collections.ArrayList getTypeSpecs()
  {
    return allTypeSpecs();
  }

/// <summary>Part of the list interface for TypeSpecs</summary>
/// <param name="coll">a collection of elements which replaces 
///        TypeSpecs's current content.</param>
public void setAllTypeSpecs(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aTypeSpecs = coll;
    NotifyControllers(null);
  }
public void setAllTypeSpecs(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aTypeSpecs = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for TypeSpecs</summary>
/// <param name="el">a TypeSpec to add to the collection in 
///           TypeSpecs</param>
/// <seealso cref="appendTypeSpecs(ICollection)"/>
public void appendTypeSpecs(TypeSpec el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allTypeSpecs().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendTypeSpecs(Lock aLock,TypeSpec el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allTypeSpecs().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for TypeSpecs</summary>
/// <param name="coll">a collection ofTypeSpecs to add to the collection in 
///           TypeSpecs</param>
/// <seealso cref="appendTypeSpecs(TypeSpec)"/>
public void appendTypeSpecs(ICollection coll)
  {
  __setDirty(true);
  allTypeSpecs().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendTypeSpecs(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allTypeSpecs().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for TypeSpecs
/// This insertion function inserts a new element in the
/// collection in TypeSpecs</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertTypeSpecs(int idx, TypeSpec el)
  {
  __setDirty(true);
  allTypeSpecs().Insert (idx, el);
NotifyControllers(null);
  }

public void insertTypeSpecs(int idx, TypeSpec el,Lock aLock)
  {
  __setDirty(true);
  allTypeSpecs().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for TypeSpecs
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfTypeSpecs(IXmlBBase el)
  {
  return allTypeSpecs().IndexOf (el);
  }

/// <summary>Part of the list interface for TypeSpecs
/// This deletion function removes an element from the
/// collection in TypeSpecs</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteTypeSpecs(int idx)
  {
  __setDirty(true);
  allTypeSpecs().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteTypeSpecs(int idx,Lock aLock)
  {
  __setDirty(true);
  allTypeSpecs().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for TypeSpecs
/// This deletion function removes an element from the
/// collection in TypeSpecs
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeTypeSpecs(IXmlBBase obj)
  {
  int idx = indexOfTypeSpecs(obj);
  if (idx >= 0) { deleteTypeSpecs(idx);
NotifyControllers(null);
   }
  }

public void removeTypeSpecs(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfTypeSpecs(obj);
  if (idx >= 0) { deleteTypeSpecs(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for TypeSpecs</summary>
/// <returns>the number of elements in TypeSpecs</returns>
public int countTypeSpecs()
  {
  return allTypeSpecs().Count;
  }

/// <summary>Part of the list interface for TypeSpecs
/// This function returns an element from the
/// collection in TypeSpecs based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public TypeSpec getTypeSpecs(int idx)
{
  return (TypeSpec) ( allTypeSpecs()[idx]);
}

private   string  aText;

public   string  getText() { return aText;}
public  void setText( string  v) {
  aText = v;
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aVersion;

public   string  getVersion() { return aVersion;}
public  void setVersion( string  v) {
  aVersion = v;
  __setDirty(true);
  NotifyControllers(null);
}

private  bool aReviewed;

public  bool getReviewed() { return aReviewed;}
public  void setReviewed(bool v) {
  aReviewed = v;
  __setDirty(true);
  NotifyControllers(null);
}

private  acceptor.SPEC_IMPLEMENTED_ENUM aImplementationStatus;

public  acceptor.SPEC_IMPLEMENTED_ENUM getImplementationStatus() { return aImplementationStatus;}
public  void setImplementationStatus(acceptor.SPEC_IMPLEMENTED_ENUM v) {
  aImplementationStatus = v;
  __setDirty(true);
  NotifyControllers(null);
}

public  string   getImplementationStatus_AsString()
{
  return acceptor.Enum_SPEC_IMPLEMENTED_ENUM_ToString (aImplementationStatus);
}

public  bool setImplementationStatus_AsString( string  v)
{
 acceptor.SPEC_IMPLEMENTED_ENUM  temp = acceptor.StringTo_Enum_SPEC_IMPLEMENTED_ENUM(v);
if (temp >= 0){
  aImplementationStatus = temp;
  __setDirty(true);
  NotifyControllers(null);
  return true;
} // If
return false;
}

private System.Collections.ArrayList aParagraphs;

/// <summary>Part of the list interface for Paragraphs</summary>
/// <returns>a collection of all the elements in Paragraphs</returns>
public System.Collections.ArrayList allParagraphs()
  {
if (aParagraphs == null){
    setAllParagraphs( new System.Collections.ArrayList() );
} // If
    return aParagraphs;
  }

/// <summary>Part of the list interface for Paragraphs</summary>
/// <returns>a collection of all the elements in Paragraphs</returns>
private System.Collections.ArrayList getParagraphs()
  {
    return allParagraphs();
  }

/// <summary>Part of the list interface for Paragraphs</summary>
/// <param name="coll">a collection of elements which replaces 
///        Paragraphs's current content.</param>
public void setAllParagraphs(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aParagraphs = coll;
    NotifyControllers(null);
  }
public void setAllParagraphs(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aParagraphs = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Paragraphs</summary>
/// <param name="el">a Paragraph to add to the collection in 
///           Paragraphs</param>
/// <seealso cref="appendParagraphs(ICollection)"/>
public void appendParagraphs(Paragraph el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allParagraphs().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendParagraphs(Lock aLock,Paragraph el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allParagraphs().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Paragraphs</summary>
/// <param name="coll">a collection ofParagraphs to add to the collection in 
///           Paragraphs</param>
/// <seealso cref="appendParagraphs(Paragraph)"/>
public void appendParagraphs(ICollection coll)
  {
  __setDirty(true);
  allParagraphs().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendParagraphs(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allParagraphs().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Paragraphs
/// This insertion function inserts a new element in the
/// collection in Paragraphs</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertParagraphs(int idx, Paragraph el)
  {
  __setDirty(true);
  allParagraphs().Insert (idx, el);
NotifyControllers(null);
  }

public void insertParagraphs(int idx, Paragraph el,Lock aLock)
  {
  __setDirty(true);
  allParagraphs().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Paragraphs
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfParagraphs(IXmlBBase el)
  {
  return allParagraphs().IndexOf (el);
  }

/// <summary>Part of the list interface for Paragraphs
/// This deletion function removes an element from the
/// collection in Paragraphs</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteParagraphs(int idx)
  {
  __setDirty(true);
  allParagraphs().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteParagraphs(int idx,Lock aLock)
  {
  __setDirty(true);
  allParagraphs().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Paragraphs
/// This deletion function removes an element from the
/// collection in Paragraphs
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeParagraphs(IXmlBBase obj)
  {
  int idx = indexOfParagraphs(obj);
  if (idx >= 0) { deleteParagraphs(idx);
NotifyControllers(null);
   }
  }

public void removeParagraphs(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfParagraphs(obj);
  if (idx >= 0) { deleteParagraphs(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Paragraphs</summary>
/// <returns>the number of elements in Paragraphs</returns>
public int countParagraphs()
  {
  return allParagraphs().Count;
  }

/// <summary>Part of the list interface for Paragraphs
/// This function returns an element from the
/// collection in Paragraphs based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public Paragraph getParagraphs(int idx)
{
  return (Paragraph) ( allParagraphs()[idx]);
}

private  ParagraphRevision aRevision;

public  ParagraphRevision getRevision() { return aRevision;}
public  void setRevision(ParagraphRevision v) {
  aRevision = v;
  if ( v != null ) { 
    v.setFather(this);
  }
  __setDirty(true);
  NotifyControllers(null);
}

private  Message aMessage;

public  Message getMessage() { return aMessage;}
public  void setMessage(Message v) {
  aMessage = v;
  if ( v != null ) { 
    v.setFather(this);
  }
  __setDirty(true);
  NotifyControllers(null);
}

private  bool aMoreInfoRequired;

public  bool getMoreInfoRequired() { return aMoreInfoRequired;}
public  void setMoreInfoRequired(bool v) {
  aMoreInfoRequired = v;
  __setDirty(true);
  NotifyControllers(null);
}

private  bool aSpecIssue;

public  bool getSpecIssue() { return aSpecIssue;}
public  void setSpecIssue(bool v) {
  aSpecIssue = v;
  __setDirty(true);
  NotifyControllers(null);
}

private  bool aFunctionalBlock;

public  bool getFunctionalBlock() { return aFunctionalBlock;}
public  void setFunctionalBlock(bool v) {
  aFunctionalBlock = v;
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aFunctionalBlockName;

public   string  getFunctionalBlockName() { return aFunctionalBlockName;}
public  void setFunctionalBlockName( string  v) {
  aFunctionalBlockName = v;
  __setDirty(true);
  NotifyControllers(null);
}

public Paragraph()
{
Paragraph obj = this;
aId=(null);
aType=(0);
aScope=(0);
aBl=(null);
aOptional=(false);
aTypeSpecs=(null);
aText=(null);
aVersion=(null);
aReviewed=(false);
aImplementationStatus=(0);
aParagraphs=(null);
aRevision=(null);
aMessage=(null);
aMoreInfoRequired=(false);
aSpecIssue=(false);
aFunctionalBlock=(false);
aFunctionalBlockName=(null);
}

public void copyTo(Paragraph other)
{
base.copyTo(other);
other.aId = aId;
other.aType = aType;
other.aScope = aScope;
other.aBl = aBl;
other.aOptional = aOptional;
other.aTypeSpecs = aTypeSpecs;
other.aText = aText;
other.aVersion = aVersion;
other.aReviewed = aReviewed;
other.aImplementationStatus = aImplementationStatus;
other.aParagraphs = aParagraphs;
other.aRevision = aRevision;
other.aMessage = aMessage;
other.aMoreInfoRequired = aMoreInfoRequired;
other.aSpecIssue = aSpecIssue;
other.aFunctionalBlock = aFunctionalBlock;
other.aFunctionalBlockName = aFunctionalBlockName;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
bool fl1314;
Paragraph fl1316;
TypeSpec fl1328;

ctxt.skipWhiteSpace();
base.parseBody(ctxt);
// Indicator
// Parse PC data
this.setText(acceptor.lAcceptPcData(ctxt, -1, '<',XmlBContext.WS_PRESERVE));
// Regexp
// Element Ref : Message
ctxt.skipWhiteSpace();
// If optional...
if (ctxt.lookAheadOpeningTag("<Message")){
// Parsing sub element
this.setMessage(acceptor.lAccept_Message(ctxt,null));
setSon(this.getMessage());
// Endif optional...
} // If
ctxt.skipWhiteSpace();
// Element Ref : ParagraphRevision
ctxt.skipWhiteSpace();
// If optional...
if (ctxt.lookAheadOpeningTag("<ParagraphRevision")){
// Parsing sub element
this.setRevision(acceptor.lAccept_ParagraphRevision(ctxt,null));
setSon(this.getRevision());
// Endif optional...
} // If
ctxt.skipWhiteSpace();
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Sub")){
ctxt.skipWhiteSpace();
fl1314 = true ; 
while (fl1314) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1314 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Repeat
ctxt.skipWhiteSpace();
fl1316 = null;
while(ctxt.lookAheadOpeningTag ("<Paragraph")) {
fl1316 = acceptor.lAccept_Paragraph(ctxt, "</Paragraph>");
appendParagraphs(fl1316);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Sub>");
} // If
} // If
// End enclosed
// Repeat
ctxt.skipWhiteSpace();
fl1328 = null;
while(ctxt.lookAheadOpeningTag ("<TypeSpec")) {
fl1328 = acceptor.lAccept_TypeSpec(ctxt, null);
appendTypeSpecs(fl1328);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl1339;
bool fl1340;
bool fl1341;
bool fl1342;
bool fl1343;
bool fl1344;
bool fl1345;
bool fl1346;
bool fl1347;
bool fl1348;
bool fl1349;
bool fl1350;
bool fl1351;
bool fl1352;
bool fl1353;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl1339 = false ; 
fl1340 = false ; 
fl1341 = false ; 
fl1342 = false ; 
fl1343 = false ; 
fl1344 = false ; 
fl1345 = false ; 
fl1346 = false ; 
fl1347 = false ; 
fl1348 = false ; 
fl1349 = false ; 
fl1350 = false ; 
fl1351 = false ; 
fl1352 = false ; 
fl1353 = true ; 
while (fl1353) { // BeginLoop 
switch (ctxt.current()) {
case 'v':
{
ctxt.advance();
if (ctxt.lookAheadString("ersion=")){
indicator = 1347;
} else {
indicator = 1354;
} // If
break;
} // Case
case 't':
{
ctxt.advance();
if (ctxt.lookAheadString("ype=")){
indicator = 1340;
} else {
indicator = 1354;
} // If
break;
} // Case
case 's':
{
ctxt.advance();
switch (ctxt.current()) {
case 't':
{
ctxt.advance();
if (ctxt.lookAheadString("atus=")){
indicator = 1346;
} else {
indicator = 1354;
} // If
break;
} // Case
case 'p':
{
ctxt.advance();
if (ctxt.lookAheadString("ecIssue=")){
indicator = 1349;
} else {
indicator = 1354;
} // If
break;
} // Case
case 'c':
{
ctxt.advance();
if (ctxt.lookAheadString("ope=")){
indicator = 1341;
} else {
indicator = 1354;
} // If
break;
} // Case
default:
indicator = 1354;
break;
} // Switch
break;
} // Case
case 'r':
{
ctxt.advance();
if (ctxt.lookAheadString("eviewed=")){
indicator = 1345;
} else {
indicator = 1354;
} // If
break;
} // Case
case 'o':
{
ctxt.advance();
if (ctxt.lookAheadString("ptional=")){
indicator = 1343;
} else {
indicator = 1354;
} // If
break;
} // Case
case 'n':
{
ctxt.advance();
if (ctxt.lookAheadString("ame=")){
indicator = 1344;
} else {
indicator = 1354;
} // If
break;
} // Case
case 'i':
{
ctxt.advance();
switch (ctxt.current()) {
case 'n':
{
ctxt.advance();
if (ctxt.lookAheadString("foRequired=")){
indicator = 1348;
} else {
indicator = 1354;
} // If
break;
} // Case
case 'd':
{
ctxt.advance();
if (ctxt.lookAhead1('=')){
indicator = 1339;
} else {
indicator = 1354;
} // If
break;
} // Case
default:
indicator = 1354;
break;
} // Switch
break;
} // Case
case 'f':
{
ctxt.advance();
if (ctxt.lookAheadString("unctionalBlock")){
switch (ctxt.current()) {
case 'N':
{
ctxt.advance();
if (ctxt.lookAheadString("ame=")){
indicator = 1351;
} else {
indicator = 1354;
} // If
break;
} // Case
case '=':
{
ctxt.advance();
indicator = 1350;
break;
} // Case
default:
indicator = 1354;
break;
} // Switch
} else {
indicator = 1354;
} // If
break;
} // Case
case 'b':
{
ctxt.advance();
if (ctxt.lookAhead2('l','=')){
indicator = 1342;
} else {
indicator = 1354;
} // If
break;
} // Case
case 'N':
{
ctxt.advance();
if (ctxt.lookAheadString("ame=")){
indicator = 1352;
} else {
indicator = 1354;
} // If
break;
} // Case
default:
indicator = 1354;
break;
} // Switch
switch (indicator) {
case 1339: {
// Handling attribute id
// Also handles alien attributes with prefix id
if (fl1339){
ctxt.fail ("Duplicate attribute: id");
} // If
fl1339 = true ; 
quoteChar = ctxt.acceptQuote();
this.setId((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1340: {
// Handling attribute type
// Also handles alien attributes with prefix type
if (fl1340){
ctxt.fail ("Duplicate attribute: type");
} // If
fl1340 = true ; 
quoteChar = ctxt.acceptQuote();
this.setType(acceptor.lAcceptEnum_Paragraph_type(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1341: {
// Handling attribute scope
// Also handles alien attributes with prefix scope
if (fl1341){
ctxt.fail ("Duplicate attribute: scope");
} // If
fl1341 = true ; 
quoteChar = ctxt.acceptQuote();
this.setScope(acceptor.lAcceptEnum_Paragraph_scope(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1342: {
// Handling attribute bl
// Also handles alien attributes with prefix bl
if (fl1342){
ctxt.fail ("Duplicate attribute: bl");
} // If
fl1342 = true ; 
quoteChar = ctxt.acceptQuote();
this.setBl((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1343: {
// Handling attribute optional
// Also handles alien attributes with prefix optional
if (fl1343){
ctxt.fail ("Duplicate attribute: optional");
} // If
fl1343 = true ; 
quoteChar = ctxt.acceptQuote();
this.setOptional(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1344: {
// Handling attribute name
// Also handles alien attributes with prefix name
if (fl1344){
ctxt.fail ("Duplicate attribute: name");
} // If
fl1344 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1345: {
// Handling attribute reviewed
// Also handles alien attributes with prefix reviewed
if (fl1345){
ctxt.fail ("Duplicate attribute: reviewed");
} // If
fl1345 = true ; 
quoteChar = ctxt.acceptQuote();
this.setReviewed(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1346: {
// Handling attribute status
// Also handles alien attributes with prefix status
if (fl1346){
ctxt.fail ("Duplicate attribute: status");
} // If
fl1346 = true ; 
quoteChar = ctxt.acceptQuote();
this.setImplementationStatus(acceptor.lAcceptEnum_SPEC_IMPLEMENTED_ENUM(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1347: {
// Handling attribute version
// Also handles alien attributes with prefix version
if (fl1347){
ctxt.fail ("Duplicate attribute: version");
} // If
fl1347 = true ; 
quoteChar = ctxt.acceptQuote();
this.setVersion((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1348: {
// Handling attribute infoRequired
// Also handles alien attributes with prefix infoRequired
if (fl1348){
ctxt.fail ("Duplicate attribute: infoRequired");
} // If
fl1348 = true ; 
quoteChar = ctxt.acceptQuote();
this.setMoreInfoRequired(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1349: {
// Handling attribute specIssue
// Also handles alien attributes with prefix specIssue
if (fl1349){
ctxt.fail ("Duplicate attribute: specIssue");
} // If
fl1349 = true ; 
quoteChar = ctxt.acceptQuote();
this.setSpecIssue(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1350: {
// Handling attribute functionalBlock
// Also handles alien attributes with prefix functionalBlock
if (fl1350){
ctxt.fail ("Duplicate attribute: functionalBlock");
} // If
fl1350 = true ; 
quoteChar = ctxt.acceptQuote();
this.setFunctionalBlock(acceptor.lAcceptBoolean(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1351: {
// Handling attribute functionalBlockName
// Also handles alien attributes with prefix functionalBlockName
if (fl1351){
ctxt.fail ("Duplicate attribute: functionalBlockName");
} // If
fl1351 = true ; 
quoteChar = ctxt.acceptQuote();
this.setFunctionalBlockName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1352: {
// Handling attribute Name
// Also handles alien attributes with prefix Name
if (fl1352){
ctxt.fail ("Duplicate attribute: Name");
} // If
fl1352 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 1354: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl1339){
ctxt.fail ("Mandatory attribute missing: id in Paragraph");
} // If
if (!fl1340){
this.setType(acceptor.Paragraph_type.aREQUIREMENT);
} // If
if (!fl1341){
this.setScope(acceptor.Paragraph_scope.aOBU_AND_TRACK);
} // If
if (!fl1342){
this.setBl("");
} // If
if (!fl1343){
this.setOptional( true);
} // If
if (!fl1344){
this.setName("");
} // If
if (!fl1345){
this.setReviewed( false);
} // If
if (!fl1346){
this.setImplementationStatus(acceptor.SPEC_IMPLEMENTED_ENUM.Impl_NA);
} // If
if (!fl1347){
this.setVersion("3.0.0");
} // If
if (!fl1348){
this.setMoreInfoRequired( false);
} // If
if (!fl1349){
this.setSpecIssue( false);
} // If
if (!fl1350){
this.setFunctionalBlock( false);
} // If
if (!fl1351){
this.setFunctionalBlockName("");
} // If
fl1353 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219
if (headingTag == null) {
  headingTag = "<Paragraph";
  endingTag = "</Paragraph>";
}

pw.Write(headingTag);
if (typeId){
pw.Write(" xsi:type=\"Paragraph\"");
} // If
pw.Write('\n');
pw.Write(" id=\"");
acceptor.unParsePcData(pw, this.getId());
pw.Write('"');
pw.Write('\n');
if (this.getType() != 0){
pw.Write(" type=\"");
acceptor.unParsePcData(pw,
  acceptor.Enum_Paragraph_type_ToString(this.getType()));
pw.Write('"');
pw.Write('\n');
} // If
if (this.getScope() != 0){
pw.Write(" scope=\"");
acceptor.unParsePcData(pw,
  acceptor.Enum_Paragraph_scope_ToString(this.getScope()));
pw.Write('"');
pw.Write('\n');
} // If
if (this.getBl() != null){
pw.Write(" bl=\"");
acceptor.unParsePcData(pw, this.getBl());
pw.Write('"');
pw.Write('\n');
} // If
if (!this.getOptional()){
pw.Write(" optional=\"");
acceptor.unParsePcData(pw, this.getOptional());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getName() != null){
pw.Write(" name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getReviewed()){
pw.Write(" reviewed=\"");
acceptor.unParsePcData(pw, this.getReviewed());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getImplementationStatus() != 0){
pw.Write(" status=\"");
acceptor.unParsePcData(pw,
  acceptor.Enum_SPEC_IMPLEMENTED_ENUM_ToString(this.getImplementationStatus()));
pw.Write('"');
pw.Write('\n');
} // If
if (this.getVersion() != null){
pw.Write(" version=\"");
acceptor.unParsePcData(pw, this.getVersion());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getMoreInfoRequired()){
pw.Write(" infoRequired=\"");
acceptor.unParsePcData(pw, this.getMoreInfoRequired());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getSpecIssue()){
pw.Write(" specIssue=\"");
acceptor.unParsePcData(pw, this.getSpecIssue());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getFunctionalBlock()){
pw.Write(" functionalBlock=\"");
acceptor.unParsePcData(pw, this.getFunctionalBlock());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getFunctionalBlockName() != null){
pw.Write(" functionalBlockName=\"");
acceptor.unParsePcData(pw, this.getFunctionalBlockName());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getName() != null){
pw.Write(" Name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
unParseBody(pw);
pw.Write(endingTag);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

base.unParseBody(pw);
// Unparsing PcData
acceptor.unParsePcData(pw, this.getText());
// Unparsing ElementRef
if (this.getMessage() != null){
unParse(pw, this.getMessage(), false, null, null);
} // If
// Unparsing ElementRef
if (this.getRevision() != null){
unParse(pw, this.getRevision(), false, null, null);
} // If
// Unparsing Enclosed
// Testing for empty content: Paragraphs
if (countParagraphs() > 0){
pw.Write("<Sub>");
pw.Write('\n');
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getParagraphs(), false, "<Paragraph", "</Paragraph>");
pw.Write("</Sub>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Paragraphs
// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getTypeSpecs(), false, null, null);
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
 base.subElements(l);
for (int i = 0; i < countTypeSpecs(); i++) {
  l.Add(getTypeSpecs(i));
}
for (int i = 0; i < countParagraphs(); i++) {
  l.Add(getParagraphs(i));
}
l.Add(this.getRevision());
l.Add(this.getMessage());
}

}
public partial class Message
: XmlBBase
{
public  override  bool find(Object search){
if (search is String ) {
if(getDescription().CompareTo((String) search) == 0)return true;
if(getBl().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.MessageController.alertChange(aLock, this);
}
private   string  aDescription;

public   string  getDescription() { return aDescription;}
public  void setDescription( string  v) {
  aDescription = v;
  __setDirty(true);
  NotifyControllers(null);
}

private  acceptor.Message_media aMedia;

public  acceptor.Message_media getMedia() { return aMedia;}
public  void setMedia(acceptor.Message_media v) {
  aMedia = v;
  __setDirty(true);
  NotifyControllers(null);
}

public  string   getMedia_AsString()
{
  return acceptor.Enum_Message_media_ToString (aMedia);
}

public  bool setMedia_AsString( string  v)
{
 acceptor.Message_media  temp = acceptor.StringTo_Enum_Message_media(v);
if (temp >= 0){
  aMedia = temp;
  __setDirty(true);
  NotifyControllers(null);
  return true;
} // If
return false;
}

private   string  aBl;

public   string  getBl() { return aBl;}
public  void setBl( string  v) {
  aBl = v;
  __setDirty(true);
  NotifyControllers(null);
}

private System.Collections.ArrayList aMsgVariables;

/// <summary>Part of the list interface for MsgVariables</summary>
/// <returns>a collection of all the elements in MsgVariables</returns>
public System.Collections.ArrayList allMsgVariables()
  {
if (aMsgVariables == null){
    setAllMsgVariables( new System.Collections.ArrayList() );
} // If
    return aMsgVariables;
  }

/// <summary>Part of the list interface for MsgVariables</summary>
/// <returns>a collection of all the elements in MsgVariables</returns>
private System.Collections.ArrayList getMsgVariables()
  {
    return allMsgVariables();
  }

/// <summary>Part of the list interface for MsgVariables</summary>
/// <param name="coll">a collection of elements which replaces 
///        MsgVariables's current content.</param>
public void setAllMsgVariables(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aMsgVariables = coll;
    NotifyControllers(null);
  }
public void setAllMsgVariables(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aMsgVariables = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for MsgVariables</summary>
/// <param name="el">a MsgVariable to add to the collection in 
///           MsgVariables</param>
/// <seealso cref="appendMsgVariables(ICollection)"/>
public void appendMsgVariables(MsgVariable el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allMsgVariables().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendMsgVariables(Lock aLock,MsgVariable el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allMsgVariables().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for MsgVariables</summary>
/// <param name="coll">a collection ofMsgVariables to add to the collection in 
///           MsgVariables</param>
/// <seealso cref="appendMsgVariables(MsgVariable)"/>
public void appendMsgVariables(ICollection coll)
  {
  __setDirty(true);
  allMsgVariables().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendMsgVariables(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allMsgVariables().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for MsgVariables
/// This insertion function inserts a new element in the
/// collection in MsgVariables</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertMsgVariables(int idx, MsgVariable el)
  {
  __setDirty(true);
  allMsgVariables().Insert (idx, el);
NotifyControllers(null);
  }

public void insertMsgVariables(int idx, MsgVariable el,Lock aLock)
  {
  __setDirty(true);
  allMsgVariables().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for MsgVariables
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfMsgVariables(IXmlBBase el)
  {
  return allMsgVariables().IndexOf (el);
  }

/// <summary>Part of the list interface for MsgVariables
/// This deletion function removes an element from the
/// collection in MsgVariables</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteMsgVariables(int idx)
  {
  __setDirty(true);
  allMsgVariables().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteMsgVariables(int idx,Lock aLock)
  {
  __setDirty(true);
  allMsgVariables().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for MsgVariables
/// This deletion function removes an element from the
/// collection in MsgVariables
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeMsgVariables(IXmlBBase obj)
  {
  int idx = indexOfMsgVariables(obj);
  if (idx >= 0) { deleteMsgVariables(idx);
NotifyControllers(null);
   }
  }

public void removeMsgVariables(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfMsgVariables(obj);
  if (idx >= 0) { deleteMsgVariables(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for MsgVariables</summary>
/// <returns>the number of elements in MsgVariables</returns>
public int countMsgVariables()
  {
  return allMsgVariables().Count;
  }

/// <summary>Part of the list interface for MsgVariables
/// This function returns an element from the
/// collection in MsgVariables based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public MsgVariable getMsgVariables(int idx)
{
  return (MsgVariable) ( allMsgVariables()[idx]);
}

public Message()
{
Message obj = this;
aDescription=(null);
aMedia=(0);
aBl=(null);
aMsgVariables=(null);
}

public void copyTo(Message other)
{
other.aDescription = aDescription;
other.aMedia = aMedia;
other.aBl = aBl;
other.aMsgVariables = aMsgVariables;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
MsgVariable fl1374;

ctxt.skipWhiteSpace();
// Repeat
ctxt.skipWhiteSpace();
fl1374 = null;
while(ctxt.lookAheadOpeningTag ("<MsgVariable")) {
fl1374 = acceptor.lAccept_MsgVariable(ctxt, null);
appendMsgVariables(fl1374);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl1385;
bool fl1386;
bool fl1387;
bool fl1388;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl1385 = false ; 
fl1386 = false ; 
fl1387 = false ; 
fl1388 = true ; 
while (fl1388) { // BeginLoop 
switch (ctxt.current()) {
case 'm':
{
ctxt.advance();
if (ctxt.lookAheadString("edia=")){
indicator = 1386;
} else {
indicator = 1389;
} // If
break;
} // Case
case 'd':
{
ctxt.advance();
if (ctxt.lookAheadString("escription=")){
indicator = 1385;
} else {
indicator = 1389;
} // If
break;
} // Case
case 'b':
{
ctxt.advance();
if (ctxt.lookAhead2('l','=')){
indicator = 1387;
} else {
indicator = 1389;
} // If
break;
} // Case
default:
indicator = 1389;
break;
} // Switch
switch (indicator) {
case 1385: {
// Handling attribute description
// Also handles alien attributes with prefix description
if (fl1385){
ctxt.fail ("Duplicate attribute: description");
} // If
fl1385 = true ; 
quoteChar = ctxt.acceptQuote();
this.setDescription((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1386: {
// Handling attribute media
// Also handles alien attributes with prefix media
if (fl1386){
ctxt.fail ("Duplicate attribute: media");
} // If
fl1386 = true ; 
quoteChar = ctxt.acceptQuote();
this.setMedia(acceptor.lAcceptEnum_Message_media(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1387: {
// Handling attribute bl
// Also handles alien attributes with prefix bl
if (fl1387){
ctxt.fail ("Duplicate attribute: bl");
} // If
fl1387 = true ; 
quoteChar = ctxt.acceptQuote();
this.setBl((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 1389: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl1385){
ctxt.fail ("Mandatory attribute missing: description in Message");
} // If
if (!fl1386){
ctxt.fail ("Mandatory attribute missing: media in Message");
} // If
fl1388 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString ("</Message>");
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

pw.Write("<Message");
if (typeId){
pw.Write(" xsi:type=\"Message\"");
} // If
pw.Write('\n');
pw.Write(" description=\"");
acceptor.unParsePcData(pw, this.getDescription());
pw.Write('"');
pw.Write('\n');
pw.Write(" media=\"");
acceptor.unParsePcData(pw,
  acceptor.Enum_Message_media_ToString(this.getMedia()));
pw.Write('"');
pw.Write('\n');
if (this.getBl() != null){
pw.Write(" bl=\"");
acceptor.unParsePcData(pw, this.getBl());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write("</Message>");
pw.Write('\n');
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getMsgVariables(), false, null, null);
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
for (int i = 0; i < countMsgVariables(); i++) {
  l.Add(getMsgVariables(i));
}
}

}
public partial class MsgVariable
: XmlBBase
{
public  override  bool find(Object search){
if (search is String ) {
if(getName().CompareTo((String) search) == 0)return true;
if(getLength().CompareTo((String) search) == 0)return true;
if(getComment().CompareTo((String) search) == 0)return true;
if(getBl().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.MsgVariableController.alertChange(aLock, this);
}
private   string  aName;

public   string  getName() { return aName;}
public  void setName( string  v) {
  aName = v;
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aLength;

public   string  getLength() { return aLength;}
public  void setLength( string  v) {
  aLength = v;
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aComment;

public   string  getComment() { return aComment;}
public  void setComment( string  v) {
  aComment = v;
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aBl;

public   string  getBl() { return aBl;}
public  void setBl( string  v) {
  aBl = v;
  __setDirty(true);
  NotifyControllers(null);
}

private System.Collections.ArrayList aMsgVariables;

/// <summary>Part of the list interface for MsgVariables</summary>
/// <returns>a collection of all the elements in MsgVariables</returns>
public System.Collections.ArrayList allMsgVariables()
  {
if (aMsgVariables == null){
    setAllMsgVariables( new System.Collections.ArrayList() );
} // If
    return aMsgVariables;
  }

/// <summary>Part of the list interface for MsgVariables</summary>
/// <returns>a collection of all the elements in MsgVariables</returns>
private System.Collections.ArrayList getMsgVariables()
  {
    return allMsgVariables();
  }

/// <summary>Part of the list interface for MsgVariables</summary>
/// <param name="coll">a collection of elements which replaces 
///        MsgVariables's current content.</param>
public void setAllMsgVariables(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aMsgVariables = coll;
    NotifyControllers(null);
  }
public void setAllMsgVariables(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aMsgVariables = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for MsgVariables</summary>
/// <param name="el">a MsgVariable to add to the collection in 
///           MsgVariables</param>
/// <seealso cref="appendMsgVariables(ICollection)"/>
public void appendMsgVariables(MsgVariable el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allMsgVariables().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendMsgVariables(Lock aLock,MsgVariable el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allMsgVariables().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for MsgVariables</summary>
/// <param name="coll">a collection ofMsgVariables to add to the collection in 
///           MsgVariables</param>
/// <seealso cref="appendMsgVariables(MsgVariable)"/>
public void appendMsgVariables(ICollection coll)
  {
  __setDirty(true);
  allMsgVariables().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendMsgVariables(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allMsgVariables().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for MsgVariables
/// This insertion function inserts a new element in the
/// collection in MsgVariables</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertMsgVariables(int idx, MsgVariable el)
  {
  __setDirty(true);
  allMsgVariables().Insert (idx, el);
NotifyControllers(null);
  }

public void insertMsgVariables(int idx, MsgVariable el,Lock aLock)
  {
  __setDirty(true);
  allMsgVariables().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for MsgVariables
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfMsgVariables(IXmlBBase el)
  {
  return allMsgVariables().IndexOf (el);
  }

/// <summary>Part of the list interface for MsgVariables
/// This deletion function removes an element from the
/// collection in MsgVariables</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteMsgVariables(int idx)
  {
  __setDirty(true);
  allMsgVariables().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteMsgVariables(int idx,Lock aLock)
  {
  __setDirty(true);
  allMsgVariables().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for MsgVariables
/// This deletion function removes an element from the
/// collection in MsgVariables
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeMsgVariables(IXmlBBase obj)
  {
  int idx = indexOfMsgVariables(obj);
  if (idx >= 0) { deleteMsgVariables(idx);
NotifyControllers(null);
   }
  }

public void removeMsgVariables(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfMsgVariables(obj);
  if (idx >= 0) { deleteMsgVariables(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for MsgVariables</summary>
/// <returns>the number of elements in MsgVariables</returns>
public int countMsgVariables()
  {
  return allMsgVariables().Count;
  }

/// <summary>Part of the list interface for MsgVariables
/// This function returns an element from the
/// collection in MsgVariables based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public MsgVariable getMsgVariables(int idx)
{
  return (MsgVariable) ( allMsgVariables()[idx]);
}

public MsgVariable()
{
MsgVariable obj = this;
aName=(null);
aLength=(null);
aComment=(null);
aBl=(null);
aMsgVariables=(null);
}

public void copyTo(MsgVariable other)
{
other.aName = aName;
other.aLength = aLength;
other.aComment = aComment;
other.aBl = aBl;
other.aMsgVariables = aMsgVariables;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
MsgVariable fl1395;

ctxt.skipWhiteSpace();
// Repeat
ctxt.skipWhiteSpace();
fl1395 = null;
while(ctxt.lookAheadOpeningTag ("<MsgVariable")) {
fl1395 = acceptor.lAccept_MsgVariable(ctxt, null);
appendMsgVariables(fl1395);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
// EndRepeat
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl1406;
bool fl1407;
bool fl1408;
bool fl1409;
bool fl1410;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl1406 = false ; 
fl1407 = false ; 
fl1408 = false ; 
fl1409 = false ; 
fl1410 = true ; 
while (fl1410) { // BeginLoop 
switch (ctxt.current()) {
case 'n':
{
ctxt.advance();
if (ctxt.lookAheadString("ame=")){
indicator = 1406;
} else {
indicator = 1411;
} // If
break;
} // Case
case 'l':
{
ctxt.advance();
if (ctxt.lookAheadString("ength=")){
indicator = 1407;
} else {
indicator = 1411;
} // If
break;
} // Case
case 'c':
{
ctxt.advance();
if (ctxt.lookAheadString("omment=")){
indicator = 1408;
} else {
indicator = 1411;
} // If
break;
} // Case
case 'b':
{
ctxt.advance();
if (ctxt.lookAhead2('l','=')){
indicator = 1409;
} else {
indicator = 1411;
} // If
break;
} // Case
default:
indicator = 1411;
break;
} // Switch
switch (indicator) {
case 1406: {
// Handling attribute name
// Also handles alien attributes with prefix name
if (fl1406){
ctxt.fail ("Duplicate attribute: name");
} // If
fl1406 = true ; 
quoteChar = ctxt.acceptQuote();
this.setName((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1407: {
// Handling attribute length
// Also handles alien attributes with prefix length
if (fl1407){
ctxt.fail ("Duplicate attribute: length");
} // If
fl1407 = true ; 
quoteChar = ctxt.acceptQuote();
this.setLength((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1408: {
// Handling attribute comment
// Also handles alien attributes with prefix comment
if (fl1408){
ctxt.fail ("Duplicate attribute: comment");
} // If
fl1408 = true ; 
quoteChar = ctxt.acceptQuote();
this.setComment((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1409: {
// Handling attribute bl
// Also handles alien attributes with prefix bl
if (fl1409){
ctxt.fail ("Duplicate attribute: bl");
} // If
fl1409 = true ; 
quoteChar = ctxt.acceptQuote();
this.setBl((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 1411: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl1406){
ctxt.fail ("Mandatory attribute missing: name in MsgVariable");
} // If
if (!fl1408){
ctxt.fail ("Mandatory attribute missing: comment in MsgVariable");
} // If
fl1410 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString ("</MsgVariable>");
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

pw.Write("<MsgVariable");
if (typeId){
pw.Write(" xsi:type=\"MsgVariable\"");
} // If
pw.Write('\n');
pw.Write(" name=\"");
acceptor.unParsePcData(pw, this.getName());
pw.Write('"');
pw.Write('\n');
if (this.getLength() != null){
pw.Write(" length=\"");
acceptor.unParsePcData(pw, this.getLength());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write(" comment=\"");
acceptor.unParsePcData(pw, this.getComment());
pw.Write('"');
pw.Write('\n');
if (this.getBl() != null){
pw.Write(" bl=\"");
acceptor.unParsePcData(pw, this.getBl());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write("</MsgVariable>");
pw.Write('\n');
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getMsgVariables(), false, null, null);
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
for (int i = 0; i < countMsgVariables(); i++) {
  l.Add(getMsgVariables(i));
}
}

}
public partial class TypeSpec
: XmlBBase
{
public  override  bool find(Object search){
if (search is String ) {
if(getMinimum_value().CompareTo((String) search) == 0)return true;
if(getMaximum_value().CompareTo((String) search) == 0)return true;
if(getResolution_formula().CompareTo((String) search) == 0)return true;
if(getId().CompareTo((String) search) == 0)return true;
if(getBl().CompareTo((String) search) == 0)return true;
if(getDescription().CompareTo((String) search) == 0)return true;
if(getShort_description().CompareTo((String) search) == 0)return true;
if(getReference().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.TypeSpecController.alertChange(aLock, this);
}
private  int aLength;

public  int getLength() { return aLength;}
public  void setLength(int v) {
  aLength = v;
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aMinimum_value;

public   string  getMinimum_value() { return aMinimum_value;}
public  void setMinimum_value( string  v) {
  aMinimum_value = v;
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aMaximum_value;

public   string  getMaximum_value() { return aMaximum_value;}
public  void setMaximum_value( string  v) {
  aMaximum_value = v;
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aResolution_formula;

public   string  getResolution_formula() { return aResolution_formula;}
public  void setResolution_formula( string  v) {
  aResolution_formula = v;
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aId;

public   string  getId() { return aId;}
public  void setId( string  v) {
  aId = v;
  __setDirty(true);
  NotifyControllers(null);
}

private  acceptor.TypeSpec_ertms_type aErtms_type;

public  acceptor.TypeSpec_ertms_type getErtms_type() { return aErtms_type;}
public  void setErtms_type(acceptor.TypeSpec_ertms_type v) {
  aErtms_type = v;
  __setDirty(true);
  NotifyControllers(null);
}

public  string   getErtms_type_AsString()
{
  return acceptor.Enum_TypeSpec_ertms_type_ToString (aErtms_type);
}

public  bool setErtms_type_AsString( string  v)
{
 acceptor.TypeSpec_ertms_type  temp = acceptor.StringTo_Enum_TypeSpec_ertms_type(v);
if (temp >= 0){
  aErtms_type = temp;
  __setDirty(true);
  NotifyControllers(null);
  return true;
} // If
return false;
}

private   string  aBl;

public   string  getBl() { return aBl;}
public  void setBl( string  v) {
  aBl = v;
  __setDirty(true);
  NotifyControllers(null);
}

private  Values aValues;

public  Values getValues() { return aValues;}
public  void setValues(Values v) {
  aValues = v;
  if ( v != null ) { 
    v.setFather(this);
  }
  __setDirty(true);
  NotifyControllers(null);
}

private  char_value aChar_value;

public  char_value getChar_value() { return aChar_value;}
public  void setChar_value(char_value v) {
  aChar_value = v;
  if ( v != null ) { 
    v.setFather(this);
  }
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aDescription;

public   string  getDescription() { return aDescription;}
public  void setDescription( string  v) {
  aDescription = v;
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aShort_description;

public   string  getShort_description() { return aShort_description;}
public  void setShort_description( string  v) {
  aShort_description = v;
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aReference;

public   string  getReference() { return aReference;}
public  void setReference( string  v) {
  aReference = v;
  __setDirty(true);
  NotifyControllers(null);
}

public TypeSpec()
{
TypeSpec obj = this;
aLength=(0);
aMinimum_value=(null);
aMaximum_value=(null);
aResolution_formula=(null);
aId=(null);
aErtms_type=(0);
aBl=(null);
aValues=(null);
aChar_value=(null);
aDescription=(null);
aShort_description=(null);
aReference=(null);
}

public void copyTo(TypeSpec other)
{
other.aLength = aLength;
other.aMinimum_value = aMinimum_value;
other.aMaximum_value = aMaximum_value;
other.aResolution_formula = aResolution_formula;
other.aId = aId;
other.aErtms_type = aErtms_type;
other.aBl = aBl;
other.aValues = aValues;
other.aChar_value = aChar_value;
other.aDescription = aDescription;
other.aShort_description = aShort_description;
other.aReference = aReference;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
bool fl1417;
bool fl1418;
bool fl1419;
int fl1422;

ctxt.skipWhiteSpace();
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<short-description")){
ctxt.skipWhiteSpace();
fl1417 = true ; 
while (fl1417) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1417 = false ; 
} // If
} // While
ctxt.accept('>');
// Indicator
// Parse PC data
this.setShort_description(acceptor.lAcceptPcData(ctxt, -1, '<',XmlBContext.WS_PRESERVE));
// Regexp
ctxt.skipWhiteSpace();
ctxt.acceptString ("</short-description>");
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<Description")){
ctxt.skipWhiteSpace();
fl1418 = true ; 
while (fl1418) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1418 = false ; 
} // If
} // While
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
// Indicator
// Parse PC data
this.setDescription(acceptor.lAcceptPcData(ctxt, -1, '<',XmlBContext.WS_PRESERVE));
// Regexp
ctxt.skipWhiteSpace();
ctxt.acceptString ("</Description>");
} // If
} // If
// End enclosed
ctxt.skipWhiteSpace();
// Optional Enclosed
if (ctxt.lookAheadOpeningTag("<reference")){
ctxt.skipWhiteSpace();
fl1419 = true ; 
while (fl1419) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1419 = false ; 
} // If
} // While
ctxt.accept('>');
// Indicator
// Parse PC data
this.setReference(acceptor.lAcceptPcData(ctxt, -1, '<',XmlBContext.WS_PRESERVE));
// Regexp
ctxt.skipWhiteSpace();
ctxt.acceptString ("</reference>");
} // If
// End enclosed
// Disjunct
ctxt.skipWhiteSpace();
// Nullable formula
fl1422 = ctxt.getPtr();
switch (ctxt.current()) {
case '<':
{
ctxt.advance();
switch (ctxt.current()) {
case 'c':
{
ctxt.advance();
if (ctxt.lookAheadString("har-value")){
indicator = 1421;
} else {
ctxt.moveBack(1);
indicator = 1423;
} // If
break;
} // Case
case 'V':
{
ctxt.advance();
if (ctxt.lookAheadString("alues")){
indicator = 1420;
} else {
ctxt.moveBack(1);
indicator = 1423;
} // If
break;
} // Case
default:
indicator = 1423;
break;
} // Switch
break;
} // Case
default:
indicator = 1423;
break;
} // Switch
switch (indicator) {
// Dispatch Lablel
case 1420: {
ctxt.moveBack(7);
// Element Ref : Values
ctxt.skipWhiteSpace();
// If optional...
if (ctxt.lookAheadOpeningTag("<Values")){
// Parsing sub element
this.setValues(acceptor.lAccept_Values(ctxt,null));
setSon(this.getValues());
// Endif optional...
} // If
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Dispatch Lablel
case 1421: {
ctxt.moveBack(11);
// Element Ref : char-value
ctxt.skipWhiteSpace();
// If optional...
if (ctxt.lookAheadOpeningTag("<char-value")){
// Parsing sub element
this.setChar_value(acceptor.lAccept_char_value(ctxt,null));
setSon(this.getChar_value());
// Endif optional...
} // If
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Optional of PCdata
case 1423: {
ctxt.setPtr(fl1422);
// Doing nothing, optional disj
break;
} // End of dispatch label
} // Dispatch
// End Disjunct
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl1428;
bool fl1429;
bool fl1430;
bool fl1431;
bool fl1432;
bool fl1433;
bool fl1434;
bool fl1435;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl1428 = false ; 
fl1429 = false ; 
fl1430 = false ; 
fl1431 = false ; 
fl1432 = false ; 
fl1433 = false ; 
fl1434 = false ; 
fl1435 = true ; 
while (fl1435) { // BeginLoop 
switch (ctxt.current()) {
case 'r':
{
ctxt.advance();
if (ctxt.lookAheadString("esolution_formula=")){
indicator = 1431;
} else {
indicator = 1436;
} // If
break;
} // Case
case 'm':
{
ctxt.advance();
switch (ctxt.current()) {
case 'i':
{
ctxt.advance();
if (ctxt.lookAheadString("nimum_value=")){
indicator = 1429;
} else {
indicator = 1436;
} // If
break;
} // Case
case 'a':
{
ctxt.advance();
if (ctxt.lookAheadString("ximum_value=")){
indicator = 1430;
} else {
indicator = 1436;
} // If
break;
} // Case
default:
indicator = 1436;
break;
} // Switch
break;
} // Case
case 'l':
{
ctxt.advance();
if (ctxt.lookAheadString("ength=")){
indicator = 1428;
} else {
indicator = 1436;
} // If
break;
} // Case
case 'i':
{
ctxt.advance();
if (ctxt.lookAhead2('d','=')){
indicator = 1432;
} else {
indicator = 1436;
} // If
break;
} // Case
case 'e':
{
ctxt.advance();
if (ctxt.lookAheadString("rtms-type=")){
indicator = 1433;
} else {
indicator = 1436;
} // If
break;
} // Case
case 'b':
{
ctxt.advance();
if (ctxt.lookAhead2('l','=')){
indicator = 1434;
} else {
indicator = 1436;
} // If
break;
} // Case
default:
indicator = 1436;
break;
} // Switch
switch (indicator) {
case 1428: {
// Handling attribute length
// Also handles alien attributes with prefix length
if (fl1428){
ctxt.fail ("Duplicate attribute: length");
} // If
fl1428 = true ; 
quoteChar = ctxt.acceptQuote();
this.setLength(ctxt.fetchInteger());
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1429: {
// Handling attribute minimum_value
// Also handles alien attributes with prefix minimum_value
if (fl1429){
ctxt.fail ("Duplicate attribute: minimum_value");
} // If
fl1429 = true ; 
quoteChar = ctxt.acceptQuote();
this.setMinimum_value((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1430: {
// Handling attribute maximum_value
// Also handles alien attributes with prefix maximum_value
if (fl1430){
ctxt.fail ("Duplicate attribute: maximum_value");
} // If
fl1430 = true ; 
quoteChar = ctxt.acceptQuote();
this.setMaximum_value((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1431: {
// Handling attribute resolution_formula
// Also handles alien attributes with prefix resolution_formula
if (fl1431){
ctxt.fail ("Duplicate attribute: resolution_formula");
} // If
fl1431 = true ; 
quoteChar = ctxt.acceptQuote();
this.setResolution_formula((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1432: {
// Handling attribute id
// Also handles alien attributes with prefix id
if (fl1432){
ctxt.fail ("Duplicate attribute: id");
} // If
fl1432 = true ; 
quoteChar = ctxt.acceptQuote();
this.setId((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1433: {
// Handling attribute ertms-type
// Also handles alien attributes with prefix ertms-type
if (fl1433){
ctxt.fail ("Duplicate attribute: ertms-type");
} // If
fl1433 = true ; 
quoteChar = ctxt.acceptQuote();
this.setErtms_type(acceptor.lAcceptEnum_TypeSpec_ertms_type(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1434: {
// Handling attribute bl
// Also handles alien attributes with prefix bl
if (fl1434){
ctxt.fail ("Duplicate attribute: bl");
} // If
fl1434 = true ; 
quoteChar = ctxt.acceptQuote();
this.setBl((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 1436: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl1428){
ctxt.fail ("Mandatory attribute missing: length in TypeSpec");
} // If
fl1435 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString ("</TypeSpec>");
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

pw.Write("<TypeSpec");
if (typeId){
pw.Write(" xsi:type=\"TypeSpec\"");
} // If
pw.Write('\n');
pw.Write(" length=\"");
acceptor.unParsePcData(pw, this.getLength());
pw.Write('"');
pw.Write('\n');
if (this.getMinimum_value() != null){
pw.Write(" minimum_value=\"");
acceptor.unParsePcData(pw, this.getMinimum_value());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getMaximum_value() != null){
pw.Write(" maximum_value=\"");
acceptor.unParsePcData(pw, this.getMaximum_value());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getResolution_formula() != null){
pw.Write(" resolution_formula=\"");
acceptor.unParsePcData(pw, this.getResolution_formula());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getId() != null){
pw.Write(" id=\"");
acceptor.unParsePcData(pw, this.getId());
pw.Write('"');
pw.Write('\n');
} // If
if (this.getErtms_type() != 0){
pw.Write(" ertms-type=\"");
acceptor.unParsePcData(pw,
  acceptor.Enum_TypeSpec_ertms_type_ToString(this.getErtms_type()));
pw.Write('"');
pw.Write('\n');
} // If
if (this.getBl() != null){
pw.Write(" bl=\"");
acceptor.unParsePcData(pw, this.getBl());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write("</TypeSpec>");
pw.Write('\n');
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

// Unparsing Enclosed
// Testing for empty content: Short-description
if (this.getShort_description() != null){
pw.Write("<short-description>");
// Unparsing PcData
acceptor.unParsePcData(pw, this.getShort_description());
pw.Write("</short-description>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Short-description
// Unparsing Enclosed
// Testing for empty content: Description
if (this.getDescription() != null){
pw.Write("<Description>");
// Unparsing PcData
if (this.getDescription() != null){
acceptor.unParsePcData(pw, this.getDescription());
} // If
pw.Write("</Description>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Description
// Unparsing Enclosed
// Testing for empty content: Reference
if (this.getReference() != null){
pw.Write("<reference>");
// Unparsing PcData
acceptor.unParsePcData(pw, this.getReference());
pw.Write("</reference>");
// Father is not a mixed
pw.Write('\n');
} // If
// After Testing for empty content: Reference
// Unparsing Disjunct
if (this.getValues() != null){
// Unparsing ElementRef
if (this.getValues() != null){
unParse(pw, this.getValues(), false, null, null);
} // If
} else {
if (this.getChar_value() != null){
// Unparsing ElementRef
if (this.getChar_value() != null){
unParse(pw, this.getChar_value(), false, null, null);
} // If
} // If
} // If
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
l.Add(this.getValues());
l.Add(this.getChar_value());
}

}
public partial class Values
: XmlBBase
{
public  override  bool find(Object search){
if (search is String ) {
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.ValuesController.alertChange(aLock, this);
}
private  resolution_formula aResolution_formula_1;

public  resolution_formula getResolution_formula_1() { return aResolution_formula_1;}
public  void setResolution_formula_1(resolution_formula v) {
  aResolution_formula_1 = v;
  if ( v != null ) { 
    v.setFather(this);
  }
  __setDirty(true);
  NotifyControllers(null);
}

private  special_or_reserved_values aSpecial_or_reserved_values;

public  special_or_reserved_values getSpecial_or_reserved_values() { return aSpecial_or_reserved_values;}
public  void setSpecial_or_reserved_values(special_or_reserved_values v) {
  aSpecial_or_reserved_values = v;
  if ( v != null ) { 
    v.setFather(this);
  }
  __setDirty(true);
  NotifyControllers(null);
}

private  special_or_reserved_value aSpecial_or_reserved_value;

public  special_or_reserved_value getSpecial_or_reserved_value() { return aSpecial_or_reserved_value;}
public  void setSpecial_or_reserved_value(special_or_reserved_value v) {
  aSpecial_or_reserved_value = v;
  if ( v != null ) { 
    v.setFather(this);
  }
  __setDirty(true);
  NotifyControllers(null);
}

public Values()
{
Values obj = this;
aResolution_formula_1=(null);
aSpecial_or_reserved_values=(null);
aSpecial_or_reserved_value=(null);
}

public void copyTo(Values other)
{
other.aResolution_formula_1 = aResolution_formula_1;
other.aSpecial_or_reserved_values = aSpecial_or_reserved_values;
other.aSpecial_or_reserved_value = aSpecial_or_reserved_value;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
int fl1448;

ctxt.skipWhiteSpace();
// Element Ref : resolution-formula
ctxt.skipWhiteSpace();
// If optional...
if (ctxt.lookAheadOpeningTag("<resolution-formula")){
// Parsing sub element
this.setResolution_formula_1(acceptor.lAccept_resolution_formula(ctxt,null));
setSon(this.getResolution_formula_1());
// Endif optional...
} // If
ctxt.skipWhiteSpace();
// Disjunct
ctxt.skipWhiteSpace();
// Nullable formula
fl1448 = ctxt.getPtr();
switch (ctxt.current()) {
case '<':
{
ctxt.advance();
if (ctxt.lookAheadString("special-or-reserved-value")){
switch (ctxt.current()) {
case 's':
{
ctxt.advance();
indicator = 1446;
break;
} // Case
default:
indicator = 1447;
break;
} // Switch
} else {
ctxt.moveBack(1);
indicator = 1449;
} // If
break;
} // Case
default:
indicator = 1449;
break;
} // Switch
switch (indicator) {
// Dispatch Lablel
case 1446: {
ctxt.moveBack(27);
// Element Ref : special-or-reserved-values
ctxt.skipWhiteSpace();
// If optional...
if (ctxt.lookAheadOpeningTag("<special-or-reserved-values")){
// Parsing sub element
this.setSpecial_or_reserved_values(acceptor.lAccept_special_or_reserved_values(ctxt,null));
setSon(this.getSpecial_or_reserved_values());
// Endif optional...
} // If
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Dispatch Lablel
case 1447: {
ctxt.moveBack(26);
// Element Ref : special-or-reserved-value
ctxt.skipWhiteSpace();
// If optional...
if (ctxt.lookAheadOpeningTag("<special-or-reserved-value")){
// Parsing sub element
this.setSpecial_or_reserved_value(acceptor.lAccept_special_or_reserved_value(ctxt,null));
setSon(this.getSpecial_or_reserved_value());
// Endif optional...
} // If
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Optional of PCdata
case 1449: {
ctxt.setPtr(fl1448);
// Doing nothing, optional disj
break;
} // End of dispatch label
} // Dispatch
// End Disjunct
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl1453;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
fl1453 = true ; 
while (fl1453) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1453 = false ; 
} // If
} // While
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString ("</Values>");
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

pw.Write("<Values");
if (typeId){
pw.Write(" xsi:type=\"Values\"");
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write("</Values>");
pw.Write('\n');
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

// Unparsing ElementRef
if (this.getResolution_formula_1() != null){
unParse(pw, this.getResolution_formula_1(), false, null, null);
} // If
// Unparsing Disjunct
if (this.getSpecial_or_reserved_values() != null){
// Unparsing ElementRef
if (this.getSpecial_or_reserved_values() != null){
unParse(pw, this.getSpecial_or_reserved_values(), false, null, null);
} // If
} else {
if (this.getSpecial_or_reserved_value() != null){
// Unparsing ElementRef
if (this.getSpecial_or_reserved_value() != null){
unParse(pw, this.getSpecial_or_reserved_value(), false, null, null);
} // If
} // If
} // If
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
l.Add(this.getResolution_formula_1());
l.Add(this.getSpecial_or_reserved_values());
l.Add(this.getSpecial_or_reserved_value());
}

}
public partial class special_or_reserved_values
: XmlBBase
{
public  override  bool find(Object search){
if (search is String ) {
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.special_or_reserved_valuesController.alertChange(aLock, this);
}
private System.Collections.ArrayList aSpecial_or_reserved_values;

/// <summary>Part of the list interface for Special_or_reserved_values</summary>
/// <returns>a collection of all the elements in Special_or_reserved_values</returns>
public System.Collections.ArrayList allSpecial_or_reserved_values()
  {
if (aSpecial_or_reserved_values == null){
    setAllSpecial_or_reserved_values( new System.Collections.ArrayList() );
} // If
    return aSpecial_or_reserved_values;
  }

/// <summary>Part of the list interface for Special_or_reserved_values</summary>
/// <returns>a collection of all the elements in Special_or_reserved_values</returns>
private System.Collections.ArrayList getSpecial_or_reserved_values()
  {
    return allSpecial_or_reserved_values();
  }

/// <summary>Part of the list interface for Special_or_reserved_values</summary>
/// <param name="coll">a collection of elements which replaces 
///        Special_or_reserved_values's current content.</param>
public void setAllSpecial_or_reserved_values(System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aSpecial_or_reserved_values = coll;
    NotifyControllers(null);
  }
public void setAllSpecial_or_reserved_values(Lock aLock,System.Collections.ArrayList coll)
  {
  __setDirty(true);
    aSpecial_or_reserved_values = coll;
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Special_or_reserved_values</summary>
/// <param name="el">a special_or_reserved_value to add to the collection in 
///           Special_or_reserved_values</param>
/// <seealso cref="appendSpecial_or_reserved_values(ICollection)"/>
public void appendSpecial_or_reserved_values(special_or_reserved_value el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allSpecial_or_reserved_values().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(null);
  }

public void appendSpecial_or_reserved_values(Lock aLock,special_or_reserved_value el)
  {
  __setDirty(true);
  el.__setDirty(true);
  allSpecial_or_reserved_values().Add(el);
  acceptor.connectSon (this, el);
NotifyControllers(aLock);
  }
/// <summary>Part of the list interface for Special_or_reserved_values</summary>
/// <param name="coll">a collection ofspecial_or_reserved_values to add to the collection in 
///           Special_or_reserved_values</param>
/// <seealso cref="appendSpecial_or_reserved_values(special_or_reserved_value)"/>
public void appendSpecial_or_reserved_values(ICollection coll)
  {
  __setDirty(true);
  allSpecial_or_reserved_values().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(null);
  }

public void appendSpecial_or_reserved_values(ICollection coll,Lock aLock)
  {
  __setDirty(true);
  allSpecial_or_reserved_values().AddRange(coll);
  acceptor.connectSons (this, coll);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Special_or_reserved_values
/// This insertion function inserts a new element in the
/// collection in Special_or_reserved_values</summary>
/// <param name="idx">the index where the insertion must take place</param>
/// <param name="el">the element to insert</param>
public void insertSpecial_or_reserved_values(int idx, special_or_reserved_value el)
  {
  __setDirty(true);
  allSpecial_or_reserved_values().Insert (idx, el);
NotifyControllers(null);
  }

public void insertSpecial_or_reserved_values(int idx, special_or_reserved_value el,Lock aLock)
  {
  __setDirty(true);
  allSpecial_or_reserved_values().Insert (idx, el);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Special_or_reserved_values
/// This function returns the index of an element in
/// the collection.</summary>
/// <param name="el">the object to look for</param>
/// <returns>the index where it is found, or -1 if it is not.</returns>
public int indexOfSpecial_or_reserved_values(IXmlBBase el)
  {
  return allSpecial_or_reserved_values().IndexOf (el);
  }

/// <summary>Part of the list interface for Special_or_reserved_values
/// This deletion function removes an element from the
/// collection in Special_or_reserved_values</summary>
/// <param name="idx">the index of the element to remove</param>
public void deleteSpecial_or_reserved_values(int idx)
  {
  __setDirty(true);
  allSpecial_or_reserved_values().RemoveAt(idx);
NotifyControllers(null);
  }

public void deleteSpecial_or_reserved_values(int idx,Lock aLock)
  {
  __setDirty(true);
  allSpecial_or_reserved_values().RemoveAt(idx);
NotifyControllers(aLock);
  }

/// <summary>Part of the list interface for Special_or_reserved_values
/// This deletion function removes an element from the
/// collection in Special_or_reserved_values
/// If the object given in parameter is not found in the
/// the collection, this function does nothing.</summary>
/// <param name="obj">the object to remove</param>
public void removeSpecial_or_reserved_values(IXmlBBase obj)
  {
  int idx = indexOfSpecial_or_reserved_values(obj);
  if (idx >= 0) { deleteSpecial_or_reserved_values(idx);
NotifyControllers(null);
   }
  }

public void removeSpecial_or_reserved_values(IXmlBBase obj,Lock aLock)
  {
  int idx = indexOfSpecial_or_reserved_values(obj);
  if (idx >= 0) { deleteSpecial_or_reserved_values(idx);
NotifyControllers(aLock);
  }}

/// <summary>Part of the list interface for Special_or_reserved_values</summary>
/// <returns>the number of elements in Special_or_reserved_values</returns>
public int countSpecial_or_reserved_values()
  {
  return allSpecial_or_reserved_values().Count;
  }

/// <summary>Part of the list interface for Special_or_reserved_values
/// This function returns an element from the
/// collection in Special_or_reserved_values based on an index.</summary>
/// <param name="idx">the index of the element to extract</param>
/// <returns>the extracted element</returns>
public special_or_reserved_value getSpecial_or_reserved_values(int idx)
{
  return (special_or_reserved_value) ( allSpecial_or_reserved_values()[idx]);
}

public special_or_reserved_values()
{
special_or_reserved_values obj = this;
aSpecial_or_reserved_values=(null);
}

public void copyTo(special_or_reserved_values other)
{
other.aSpecial_or_reserved_values = aSpecial_or_reserved_values;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
special_or_reserved_value fl1455;

ctxt.skipWhiteSpace();
// Repeat
ctxt.skipWhiteSpace();
fl1455 = null;
while(ctxt.lookAheadOpeningTag ("<special-or-reserved-value")) {
fl1455 = acceptor.lAccept_special_or_reserved_value(ctxt, null);
appendSpecial_or_reserved_values(fl1455);
ctxt.skipWhiteSpace();
} // -- monomorphic Loop
if (fl1455 == null){
ctxt.fail ("At least one element expected in repetition");
} // If
// EndRepeat
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl1466;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
fl1466 = true ; 
while (fl1466) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1466 = false ; 
} // If
} // While
ctxt.skipWhiteSpace();
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString ("</special-or-reserved-values>");
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

pw.Write("<special-or-reserved-values");
if (typeId){
pw.Write(" xsi:type=\"special-or-reserved-values\"");
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write("</special-or-reserved-values>");
pw.Write('\n');
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

// Unparsing Repeat
// Unparsing repetition
unParse(pw, this.getSpecial_or_reserved_values(), false, null, null);
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
for (int i = 0; i < countSpecial_or_reserved_values(); i++) {
  l.Add(getSpecial_or_reserved_values(i));
}
}

}
public partial class special_or_reserved_value
: XmlBBase
{
public  override  bool find(Object search){
if (search is String ) {
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.special_or_reserved_valueController.alertChange(aLock, this);
}
private  mask aMask;

public  mask getMask() { return aMask;}
public  void setMask(mask v) {
  aMask = v;
  if ( v != null ) { 
    v.setFather(this);
  }
  __setDirty(true);
  NotifyControllers(null);
}

private  match aMatch;

public  match getMatch() { return aMatch;}
public  void setMatch(match v) {
  aMatch = v;
  if ( v != null ) { 
    v.setFather(this);
  }
  __setDirty(true);
  NotifyControllers(null);
}

private  match_range aMatch_range;

public  match_range getMatch_range() { return aMatch_range;}
public  void setMatch_range(match_range v) {
  aMatch_range = v;
  if ( v != null ) { 
    v.setFather(this);
  }
  __setDirty(true);
  NotifyControllers(null);
}

private  meaning aMeaning;

public  meaning getMeaning() { return aMeaning;}
public  void setMeaning(meaning v) {
  aMeaning = v;
  if ( v != null ) { 
    v.setFather(this);
  }
  __setDirty(true);
  NotifyControllers(null);
}

private  value aValue;

public  value getValue() { return aValue;}
public  void setValue(value v) {
  aValue = v;
  if ( v != null ) { 
    v.setFather(this);
  }
  __setDirty(true);
  NotifyControllers(null);
}

public special_or_reserved_value()
{
special_or_reserved_value obj = this;
aMask=(null);
aMatch=(null);
aMatch_range=(null);
aMeaning=(null);
aValue=(null);
}

public void copyTo(special_or_reserved_value other)
{
other.aMask = aMask;
other.aMatch = aMatch;
other.aMatch_range = aMatch_range;
other.aMeaning = aMeaning;
other.aValue = aValue;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
int fl1469;

ctxt.skipWhiteSpace();
// Element Ref : mask
ctxt.skipWhiteSpace();
// If optional...
if (ctxt.lookAheadOpeningTag("<mask")){
// Parsing sub element
this.setMask(acceptor.lAccept_mask(ctxt,null));
setSon(this.getMask());
// Endif optional...
} // If
ctxt.skipWhiteSpace();
// Disjunct
ctxt.skipWhiteSpace();
// Nullable formula
fl1469 = ctxt.getPtr();
switch (ctxt.current()) {
case '<':
{
ctxt.advance();
if (ctxt.lookAheadString("match")){
switch (ctxt.current()) {
case '-':
{
ctxt.advance();
if (ctxt.lookAheadString("range")){
indicator = 1468;
} else {
ctxt.moveBack(1);
indicator = 1467;
} // If
break;
} // Case
default:
indicator = 1467;
break;
} // Switch
} else {
ctxt.moveBack(1);
indicator = 1470;
} // If
break;
} // Case
default:
indicator = 1470;
break;
} // Switch
switch (indicator) {
// Dispatch Lablel
case 1467: {
ctxt.moveBack(6);
// Element Ref : match
ctxt.skipWhiteSpace();
// If optional...
if (ctxt.lookAheadOpeningTag("<match")){
// Parsing sub element
this.setMatch(acceptor.lAccept_match(ctxt,null));
setSon(this.getMatch());
// Endif optional...
} // If
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Dispatch Lablel
case 1468: {
ctxt.moveBack(12);
// Element Ref : match-range
ctxt.skipWhiteSpace();
// If optional...
if (ctxt.lookAheadOpeningTag("<match-range")){
// Parsing sub element
this.setMatch_range(acceptor.lAccept_match_range(ctxt,null));
setSon(this.getMatch_range());
// Endif optional...
} // If
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Optional of PCdata
case 1470: {
ctxt.setPtr(fl1469);
// Doing nothing, optional disj
break;
} // End of dispatch label
} // Dispatch
// End Disjunct
// Element Ref : meaning
ctxt.skipWhiteSpace();
// If optional...
if (ctxt.lookAheadOpeningTag("<meaning")){
// Parsing sub element
this.setMeaning(acceptor.lAccept_meaning(ctxt,null));
setSon(this.getMeaning());
// Endif optional...
} // If
ctxt.skipWhiteSpace();
// Element Ref : value
ctxt.skipWhiteSpace();
// If optional...
if (ctxt.lookAheadOpeningTag("<value")){
// Parsing sub element
this.setValue(acceptor.lAccept_value(ctxt,null));
setSon(this.getValue());
// Endif optional...
} // If
ctxt.skipWhiteSpace();
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl1474;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
fl1474 = true ; 
while (fl1474) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1474 = false ; 
} // If
} // While
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString ("</special-or-reserved-value>");
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

pw.Write("<special-or-reserved-value");
if (typeId){
pw.Write(" xsi:type=\"special-or-reserved-value\"");
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write("</special-or-reserved-value>");
pw.Write('\n');
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

// Unparsing ElementRef
if (this.getMask() != null){
unParse(pw, this.getMask(), false, null, null);
} // If
// Unparsing Disjunct
if (this.getMatch() != null){
// Unparsing ElementRef
if (this.getMatch() != null){
unParse(pw, this.getMatch(), false, null, null);
} // If
} else {
if (this.getMatch_range() != null){
// Unparsing ElementRef
if (this.getMatch_range() != null){
unParse(pw, this.getMatch_range(), false, null, null);
} // If
} // If
} // If
// Unparsing ElementRef
if (this.getMeaning() != null){
unParse(pw, this.getMeaning(), false, null, null);
} // If
// Unparsing ElementRef
if (this.getValue() != null){
unParse(pw, this.getValue(), false, null, null);
} // If
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
l.Add(this.getMask());
l.Add(this.getMatch());
l.Add(this.getMatch_range());
l.Add(this.getMeaning());
l.Add(this.getValue());
}

}
public partial class mask
: XmlBBase
{
public  override  bool find(Object search){
if (search is String ) {
if(getValue().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.maskController.alertChange(aLock, this);
}
private   string  aValue;

public   string  getValue() { return aValue;}
public  void setValue( string  v) {
  aValue = v;
  __setDirty(true);
  NotifyControllers(null);
}

public mask()
{
mask obj = this;
aValue=(null);
}

public void copyTo(mask other)
{
other.aValue = aValue;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219

// Indicator
// Parse PC data
this.setValue(acceptor.lAcceptPcData(ctxt, -1, '<',XmlBContext.WS_PRESERVE));
// Regexp
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl1475;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
fl1475 = true ; 
while (fl1475) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1475 = false ; 
} // If
} // While
ctxt.skipWhiteSpace();
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString ("</mask>");
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

pw.Write("<mask");
if (typeId){
pw.Write(" xsi:type=\"mask\"");
} // If
pw.Write('>');
unParseBody(pw);
pw.Write("</mask>");
pw.Write('\n');
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

// Unparsing PcData
acceptor.unParsePcData(pw, this.getValue());
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
}

}
public partial class match
: XmlBBase
{
public  override  bool find(Object search){
if (search is String ) {
if(getValue().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.matchController.alertChange(aLock, this);
}
private   string  aValue;

public   string  getValue() { return aValue;}
public  void setValue( string  v) {
  aValue = v;
  __setDirty(true);
  NotifyControllers(null);
}

public match()
{
match obj = this;
aValue=(null);
}

public void copyTo(match other)
{
other.aValue = aValue;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219

// Indicator
// Parse PC data
this.setValue(acceptor.lAcceptPcData(ctxt, -1, '<',XmlBContext.WS_PRESERVE));
// Regexp
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl1476;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
fl1476 = true ; 
while (fl1476) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1476 = false ; 
} // If
} // While
ctxt.skipWhiteSpace();
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString ("</match>");
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

pw.Write("<match");
if (typeId){
pw.Write(" xsi:type=\"match\"");
} // If
pw.Write('>');
unParseBody(pw);
pw.Write("</match>");
pw.Write('\n');
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

// Unparsing PcData
acceptor.unParsePcData(pw, this.getValue());
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
}

}
public partial class meaning
: XmlBBase
{
public  override  bool find(Object search){
if (search is String ) {
if(getBl().CompareTo((String) search) == 0)return true;
if(getValue().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.meaningController.alertChange(aLock, this);
}
private  acceptor.meaning_type aType;

public  acceptor.meaning_type getType() { return aType;}
public  void setType(acceptor.meaning_type v) {
  aType = v;
  __setDirty(true);
  NotifyControllers(null);
}

public  string   getType_AsString()
{
  return acceptor.Enum_meaning_type_ToString (aType);
}

public  bool setType_AsString( string  v)
{
 acceptor.meaning_type  temp = acceptor.StringTo_Enum_meaning_type(v);
if (temp >= 0){
  aType = temp;
  __setDirty(true);
  NotifyControllers(null);
  return true;
} // If
return false;
}

private   string  aBl;

public   string  getBl() { return aBl;}
public  void setBl( string  v) {
  aBl = v;
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aValue;

public   string  getValue() { return aValue;}
public  void setValue( string  v) {
  aValue = v;
  __setDirty(true);
  NotifyControllers(null);
}

public meaning()
{
meaning obj = this;
aType=(0);
aBl=(null);
aValue=(null);
}

public void copyTo(meaning other)
{
other.aType = aType;
other.aBl = aBl;
other.aValue = aValue;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219

// Indicator
// Parse PC data
this.setValue(acceptor.lAcceptPcData(ctxt, -1, '<',XmlBContext.WS_PRESERVE));
// Regexp
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl1477;
bool fl1478;
bool fl1479;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl1477 = false ; 
fl1478 = false ; 
fl1479 = true ; 
while (fl1479) { // BeginLoop 
switch (ctxt.current()) {
case 't':
{
ctxt.advance();
if (ctxt.lookAheadString("ype=")){
indicator = 1477;
} else {
indicator = 1480;
} // If
break;
} // Case
case 'b':
{
ctxt.advance();
if (ctxt.lookAhead2('l','=')){
indicator = 1478;
} else {
indicator = 1480;
} // If
break;
} // Case
default:
indicator = 1480;
break;
} // Switch
switch (indicator) {
case 1477: {
// Handling attribute type
// Also handles alien attributes with prefix type
if (fl1477){
ctxt.fail ("Duplicate attribute: type");
} // If
fl1477 = true ; 
quoteChar = ctxt.acceptQuote();
this.setType(acceptor.lAcceptEnum_meaning_type(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
case 1478: {
// Handling attribute bl
// Also handles alien attributes with prefix bl
if (fl1478){
ctxt.fail ("Duplicate attribute: bl");
} // If
fl1478 = true ; 
quoteChar = ctxt.acceptQuote();
this.setBl((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 1480: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl1477){
ctxt.fail ("Mandatory attribute missing: type in meaning");
} // If
fl1479 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString ("</meaning>");
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

pw.Write("<meaning");
if (typeId){
pw.Write(" xsi:type=\"meaning\"");
} // If
pw.Write('\n');
pw.Write(" type=\"");
acceptor.unParsePcData(pw,
  acceptor.Enum_meaning_type_ToString(this.getType()));
pw.Write('"');
pw.Write('\n');
if (this.getBl() != null){
pw.Write(" bl=\"");
acceptor.unParsePcData(pw, this.getBl());
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
unParseBody(pw);
pw.Write("</meaning>");
pw.Write('\n');
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

// Unparsing PcData
if (this.getValue() != null){
acceptor.unParsePcData(pw, this.getValue());
} // If
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
}

}
public partial class match_range
: XmlBBase
{
public  override  bool find(Object search){
if (search is String ) {
if(getMinimum().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.match_rangeController.alertChange(aLock, this);
}
private   string  aMinimum;

public   string  getMinimum() { return aMinimum;}
public  void setMinimum( string  v) {
  aMinimum = v;
  __setDirty(true);
  NotifyControllers(null);
}

private  acceptor.maximum_Value aMaximum;

public  acceptor.maximum_Value getMaximum() { return aMaximum;}
public  void setMaximum(acceptor.maximum_Value v) {
  aMaximum = v;
  __setDirty(true);
  NotifyControllers(null);
}

public  string   getMaximum_AsString()
{
  return acceptor.Enum_maximum_Value_ToString (aMaximum);
}

public  bool setMaximum_AsString( string  v)
{
 acceptor.maximum_Value  temp = acceptor.StringTo_Enum_maximum_Value(v);
if (temp >= 0){
  aMaximum = temp;
  __setDirty(true);
  NotifyControllers(null);
  return true;
} // If
return false;
}

public match_range()
{
match_range obj = this;
aMinimum=(null);
aMaximum=(0);
}

public void copyTo(match_range other)
{
other.aMinimum = aMinimum;
other.aMaximum = aMaximum;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219
bool fl1484;
bool fl1485;

ctxt.skipWhiteSpace();
ctxt.skipWhiteSpace();
// Enclosed
ctxt.acceptString ("<minimum");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
ctxt.skipWhiteSpace();
fl1484 = true ; 
while (fl1484) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1484 = false ; 
} // If
} // While
ctxt.accept('>');
// Indicator
// Parse PC data
this.setMinimum(acceptor.lAcceptPcData(ctxt, -1, '<',XmlBContext.WS_PRESERVE));
// Regexp
ctxt.skipWhiteSpace();
ctxt.acceptString ("</minimum>");
// End enclosed
ctxt.skipWhiteSpace();
// Enclosed
ctxt.acceptString ("<maximum");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
ctxt.skipWhiteSpace();
fl1485 = true ; 
while (fl1485) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1485 = false ; 
} // If
} // While
ctxt.accept('>');
// Indicator
ctxt.skipWhiteSpace();
// Parse PC data
this.setMaximum(acceptor.lAcceptEnum_maximum_Value(ctxt));
// Regexp
ctxt.skipWhiteSpace();
ctxt.acceptString ("</maximum>");
// End enclosed
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl1486;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
fl1486 = true ; 
while (fl1486) { // BeginLoop 
ctxt.skipWhiteSpace();
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1486 = false ; 
} // If
} // While
ctxt.skipWhiteSpace();
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString ("</match-range>");
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

pw.Write("<match-range");
if (typeId){
pw.Write(" xsi:type=\"match-range\"");
} // If
pw.Write('>');
pw.Write('\n');
unParseBody(pw);
pw.Write("</match-range>");
pw.Write('\n');
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

// Unparsing Enclosed
pw.Write("<minimum>");
// Unparsing PcData
acceptor.unParsePcData(pw, this.getMinimum());
pw.Write("</minimum>");
// Father is not a mixed
pw.Write('\n');
// Unparsing Enclosed
pw.Write("<maximum>");
// Unparsing PcData
acceptor.unParsePcData(pw,
  acceptor.Enum_maximum_Value_ToString(this.getMaximum()));
pw.Write("</maximum>");
// Father is not a mixed
pw.Write('\n');
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
}

}
public partial class resolution_formula
: XmlBBase
{
public  override  bool find(Object search){
if (search is String ) {
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.resolution_formulaController.alertChange(aLock, this);
}
private  acceptor.resolution_formula_units aUnits;

public  acceptor.resolution_formula_units getUnits() { return aUnits;}
public  void setUnits(acceptor.resolution_formula_units v) {
  aUnits = v;
  __setDirty(true);
  NotifyControllers(null);
}

public  string   getUnits_AsString()
{
  return acceptor.Enum_resolution_formula_units_ToString (aUnits);
}

public  bool setUnits_AsString( string  v)
{
 acceptor.resolution_formula_units  temp = acceptor.StringTo_Enum_resolution_formula_units(v);
if (temp >= 0){
  aUnits = temp;
  __setDirty(true);
  NotifyControllers(null);
  return true;
} // If
return false;
}

private  acceptor.resolution_formula_Value aValue;

public  acceptor.resolution_formula_Value getValue() { return aValue;}
public  void setValue(acceptor.resolution_formula_Value v) {
  aValue = v;
  __setDirty(true);
  NotifyControllers(null);
}

public  string   getValue_AsString()
{
  return acceptor.Enum_resolution_formula_Value_ToString (aValue);
}

public  bool setValue_AsString( string  v)
{
 acceptor.resolution_formula_Value  temp = acceptor.StringTo_Enum_resolution_formula_Value(v);
if (temp >= 0){
  aValue = temp;
  __setDirty(true);
  NotifyControllers(null);
  return true;
} // If
return false;
}

public resolution_formula()
{
resolution_formula obj = this;
aUnits=(0);
aValue=(0);
}

public void copyTo(resolution_formula other)
{
other.aUnits = aUnits;
other.aValue = aValue;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219

// Indicator
ctxt.skipWhiteSpace();
// Parse PC data
this.setValue(acceptor.lAcceptEnum_resolution_formula_Value(ctxt));
// Regexp
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl1487;
bool fl1488;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl1487 = false ; 
fl1488 = true ; 
while (fl1488) { // BeginLoop 
if (ctxt.lookAheadString("units=")){
indicator = 1487;
} else {
indicator = 1489;
} // If
switch (indicator) {
case 1487: {
// Handling attribute units
// Also handles alien attributes with prefix units
if (fl1487){
ctxt.fail ("Duplicate attribute: units");
} // If
fl1487 = true ; 
quoteChar = ctxt.acceptQuote();
this.setUnits(acceptor.lAcceptEnum_resolution_formula_units(ctxt));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 1489: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
fl1488 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString ("</resolution-formula>");
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

pw.Write("<resolution-formula");
if (typeId){
pw.Write(" xsi:type=\"resolution-formula\"");
} // If
pw.Write('\n');
if (this.getUnits() != 0){
pw.Write(" units=\"");
acceptor.unParsePcData(pw,
  acceptor.Enum_resolution_formula_units_ToString(this.getUnits()));
pw.Write('"');
pw.Write('\n');
} // If
pw.Write('>');
unParseBody(pw);
pw.Write("</resolution-formula>");
pw.Write('\n');
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

// Unparsing PcData
acceptor.unParsePcData(pw,
  acceptor.Enum_resolution_formula_Value_ToString(this.getValue()));
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
}

}
public partial class value
: XmlBBase
{
public  override  bool find(Object search){
if (search is String ) {
if(getUnits().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.valueController.alertChange(aLock, this);
}
private   string  aUnits;

public   string  getUnits() { return aUnits;}
public  void setUnits( string  v) {
  aUnits = v;
  __setDirty(true);
  NotifyControllers(null);
}

private  int aValue;

public  int getValue() { return aValue;}
public  void setValue(int v) {
  aValue = v;
  __setDirty(true);
  NotifyControllers(null);
}

public value()
{
value obj = this;
aUnits=(null);
aValue=(0);
}

public void copyTo(value other)
{
other.aUnits = aUnits;
other.aValue = aValue;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219

// Indicator
ctxt.skipWhiteSpace();
// Parse PC data
this.setValue(ctxt.fetchInteger());
// Regexp
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl1491;
bool fl1492;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl1491 = false ; 
fl1492 = true ; 
while (fl1492) { // BeginLoop 
if (ctxt.lookAheadString("units=")){
indicator = 1491;
} else {
indicator = 1493;
} // If
switch (indicator) {
case 1491: {
// Handling attribute units
// Also handles alien attributes with prefix units
if (fl1491){
ctxt.fail ("Duplicate attribute: units");
} // If
fl1491 = true ; 
quoteChar = ctxt.acceptQuote();
this.setUnits((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 1493: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl1491){
ctxt.fail ("Mandatory attribute missing: units in value");
} // If
fl1492 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString ("</value>");
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

pw.Write("<value");
if (typeId){
pw.Write(" xsi:type=\"value\"");
} // If
pw.Write('\n');
pw.Write(" units=\"");
acceptor.unParsePcData(pw, this.getUnits());
pw.Write('"');
pw.Write('\n');
pw.Write('>');
unParseBody(pw);
pw.Write("</value>");
pw.Write('\n');
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

// Unparsing PcData
acceptor.unParsePcData(pw, this.getValue());
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
}

}
public partial class char_value
: XmlBBase
{
public  override  bool find(Object search){
if (search is String ) {
if(getEncoding().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.char_valueController.alertChange(aLock, this);
}
private   string  aEncoding;

public   string  getEncoding() { return aEncoding;}
public  void setEncoding( string  v) {
  aEncoding = v;
  __setDirty(true);
  NotifyControllers(null);
}

public char_value()
{
char_value obj = this;
aEncoding=(null);
}

public void copyTo(char_value other)
{
other.aEncoding = aEncoding;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl1495;
bool fl1496;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl1495 = false ; 
fl1496 = true ; 
while (fl1496) { // BeginLoop 
if (ctxt.lookAheadString("encoding=")){
indicator = 1495;
} else {
indicator = 1497;
} // If
switch (indicator) {
case 1495: {
// Handling attribute encoding
// Also handles alien attributes with prefix encoding
if (fl1495){
ctxt.fail ("Duplicate attribute: encoding");
} // If
fl1495 = true ; 
quoteChar = ctxt.acceptQuote();
this.setEncoding((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 1497: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl1495){
ctxt.fail ("Mandatory attribute missing: encoding in char-value");
} // If
fl1496 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
if (ctxt.current() == '/'){
ctxt.advance();
ctxt.accept('>');
} else {
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString ("</char-value>");
// If formula empty
} // If
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

pw.Write("<char-value");
if (typeId){
pw.Write(" xsi:type=\"char-value\"");
} // If
pw.Write('\n');
pw.Write(" encoding=\"");
acceptor.unParsePcData(pw, this.getEncoding());
pw.Write('"');
pw.Write('\n');
pw.Write("/>");
pw.Write('\n');
unParseBody(pw);
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
}

}
public partial class ParagraphRevision
: ModelElement
{
public  override  bool find(Object search){
if (search is String ) {
if(getText().CompareTo((String) search) == 0)return true;
if(getVersion().CompareTo((String) search) == 0)return true;
}
return false;
}

public  override  void NotifyControllers(Lock aLock){
	base.NotifyControllers(aLock);
	ControllersManager.ParagraphRevisionController.alertChange(aLock, this);
}
private   string  aText;

public   string  getText() { return aText;}
public  void setText( string  v) {
  aText = v;
  __setDirty(true);
  NotifyControllers(null);
}

private   string  aVersion;

public   string  getVersion() { return aVersion;}
public  void setVersion( string  v) {
  aVersion = v;
  __setDirty(true);
  NotifyControllers(null);
}

public ParagraphRevision()
{
ParagraphRevision obj = this;
aText=(null);
aVersion=(null);
}

public void copyTo(ParagraphRevision other)
{
other.aText = aText;
other.aVersion = aVersion;
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void parseBody(XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
int indicator=0;
char quoteChar;
 string  tempStr;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
// Indicator
// Parse PC data
this.setText(acceptor.lAcceptPcData(ctxt, -1, '<',XmlBContext.WS_PRESERVE));
// Regexp
ctxt.skipWhiteSpace();
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  void parse(XmlBContext ctxt,  string  endingTag)

{
#pragma warning disable 0168, 0219
int indicator = 0;
char quoteChar;
 string  tempStr = null;
bool fl1499;
bool fl1500;
#pragma warning restore 0168, 0219

ctxt.skipWhiteSpace();
{
// Accept Attributes
fl1499 = false ; 
fl1500 = true ; 
while (fl1500) { // BeginLoop 
if (ctxt.lookAheadString("version=")){
indicator = 1499;
} else {
indicator = 1501;
} // If
switch (indicator) {
case 1499: {
// Handling attribute version
// Also handles alien attributes with prefix version
if (fl1499){
ctxt.fail ("Duplicate attribute: version");
} // If
fl1499 = true ; 
quoteChar = ctxt.acceptQuote();
this.setVersion((acceptor.lAcceptPcData(ctxt,-1, quoteChar, XmlBContext.WS_PRESERVE)));
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
break;
} // End of dispatch label
// Final default label
case 1501: {
// Taking ignorable attributes into account
if (ctxt.isAlNum()){
ctxt.skipTill ('=');
ctxt.advance();
ctxt.skipWhiteSpace();
quoteChar = ctxt.acceptQuote();
ctxt.skipTill (quoteChar);
ctxt.accept(quoteChar);
ctxt.skipWhiteSpace();
} else {
if (!fl1499){
ctxt.fail ("Mandatory attribute missing: version in ParagraphRevision");
} // If
fl1500 = false ; 
} // If
break;
} // End of dispatch label
} // Dispatch
} // While
}
ctxt.skipWhiteSpace();
ctxt.accept('>');
parseBody(ctxt);
ctxt.acceptString ("</ParagraphRevision>");
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override  public  void unParse(TextWriter pw,
                    bool typeId,
                     string  headingTag,
                     string  endingTag)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

pw.Write("<ParagraphRevision");
if (typeId){
pw.Write(" xsi:type=\"ParagraphRevision\"");
} // If
pw.Write('\n');
pw.Write(" version=\"");
acceptor.unParsePcData(pw, this.getVersion());
pw.Write('"');
pw.Write('\n');
pw.Write('>');
unParseBody(pw);
pw.Write("</ParagraphRevision>");
pw.Write('\n');
}

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
 override public void unParseBody(TextWriter pw)
{
#pragma warning disable 0168, 0219
int i;
#pragma warning restore 0168, 0219

// Unparsing PcData
acceptor.unParsePcData(pw, this.getText());
}
public  override  void dispatch(XmlBBaseVisitor v)
{
  ((Visitor)v).visit(this);
}

public  override  void dispatch(XmlBBaseVisitor v, bool visitSubNodes)
{
  ((Visitor)v).visit(this, visitSubNodes);
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override void subElements(ArrayList l)
{
}

}
public partial class ControllersManager
{
//Namable  Namable
public static Controller<Namable, IListener<Namable>> NamableController = new Controller<Namable, IListener<Namable>>();
//ReferencesParagraph  ReferencesParagraph
public static Controller<ReferencesParagraph, IListener<ReferencesParagraph>> ReferencesParagraphController = new Controller<ReferencesParagraph, IListener<ReferencesParagraph>>();
//ReqRelated  ReqRelated
public static Controller<ReqRelated, IListener<ReqRelated>> ReqRelatedController = new Controller<ReqRelated, IListener<ReqRelated>>();
//Dictionary  Dictionary
public static Controller<Dictionary, IListener<Dictionary>> DictionaryController = new Controller<Dictionary, IListener<Dictionary>>();
//RuleDisabling  RuleDisabling
public static Controller<RuleDisabling, IListener<RuleDisabling>> RuleDisablingController = new Controller<RuleDisabling, IListener<RuleDisabling>>();
//NameSpace  NameSpace
public static Controller<NameSpace, IListener<NameSpace>> NameSpaceController = new Controller<NameSpace, IListener<NameSpace>>();
//ReqRef  ReqRef
public static Controller<ReqRef, IListener<ReqRef>> ReqRefController = new Controller<ReqRef, IListener<ReqRef>>();
//Type  Type
public static Controller<Type, IListener<Type>> TypeController = new Controller<Type, IListener<Type>>();
//Enum  Enum
public static Controller<Enum, IListener<Enum>> EnumController = new Controller<Enum, IListener<Enum>>();
//EnumValue  EnumValue
public static Controller<EnumValue, IListener<EnumValue>> EnumValueController = new Controller<EnumValue, IListener<EnumValue>>();
//Range  Range
public static Controller<Range, IListener<Range>> RangeController = new Controller<Range, IListener<Range>>();
//Structure  Structure
public static Controller<Structure, IListener<Structure>> StructureController = new Controller<Structure, IListener<Structure>>();
//StructureElement  StructureElement
public static Controller<StructureElement, IListener<StructureElement>> StructureElementController = new Controller<StructureElement, IListener<StructureElement>>();
//StructureProcedure  StructureProcedure
public static Controller<StructureProcedure, IListener<StructureProcedure>> StructureProcedureController = new Controller<StructureProcedure, IListener<StructureProcedure>>();
//Collection  Collection
public static Controller<Collection, IListener<Collection>> CollectionController = new Controller<Collection, IListener<Collection>>();
//Function  Function
public static Controller<Function, IListener<Function>> FunctionController = new Controller<Function, IListener<Function>>();
//Parameter  Parameter
public static Controller<Parameter, IListener<Parameter>> ParameterController = new Controller<Parameter, IListener<Parameter>>();
//Case  Case
public static Controller<Case, IListener<Case>> CaseController = new Controller<Case, IListener<Case>>();
//Procedure  Procedure
public static Controller<Procedure, IListener<Procedure>> ProcedureController = new Controller<Procedure, IListener<Procedure>>();
//StateMachine  StateMachine
public static Controller<StateMachine, IListener<StateMachine>> StateMachineController = new Controller<StateMachine, IListener<StateMachine>>();
//State  State
public static Controller<State, IListener<State>> StateController = new Controller<State, IListener<State>>();
//Variable  Variable
public static Controller<Variable, IListener<Variable>> VariableController = new Controller<Variable, IListener<Variable>>();
//Rule  Rule
public static Controller<Rule, IListener<Rule>> RuleController = new Controller<Rule, IListener<Rule>>();
//RuleCondition  RuleCondition
public static Controller<RuleCondition, IListener<RuleCondition>> RuleConditionController = new Controller<RuleCondition, IListener<RuleCondition>>();
//PreCondition  PreCondition
public static Controller<PreCondition, IListener<PreCondition>> PreConditionController = new Controller<PreCondition, IListener<PreCondition>>();
//Action  Action
public static Controller<Action, IListener<Action>> ActionController = new Controller<Action, IListener<Action>>();
//Frame  Frame
public static Controller<Frame, IListener<Frame>> FrameController = new Controller<Frame, IListener<Frame>>();
//SubSequence  SubSequence
public static Controller<SubSequence, IListener<SubSequence>> SubSequenceController = new Controller<SubSequence, IListener<SubSequence>>();
//TestCase  TestCase
public static Controller<TestCase, IListener<TestCase>> TestCaseController = new Controller<TestCase, IListener<TestCase>>();
//Step  Step
public static Controller<Step, IListener<Step>> StepController = new Controller<Step, IListener<Step>>();
//SubStep  SubStep
public static Controller<SubStep, IListener<SubStep>> SubStepController = new Controller<SubStep, IListener<SubStep>>();
//Expectation  Expectation
public static Controller<Expectation, IListener<Expectation>> ExpectationController = new Controller<Expectation, IListener<Expectation>>();
//DBMessage  DBMessage
public static Controller<DBMessage, IListener<DBMessage>> DBMessageController = new Controller<DBMessage, IListener<DBMessage>>();
//DBPacket  DBPacket
public static Controller<DBPacket, IListener<DBPacket>> DBPacketController = new Controller<DBPacket, IListener<DBPacket>>();
//DBField  DBField
public static Controller<DBField, IListener<DBField>> DBFieldController = new Controller<DBField, IListener<DBField>>();
//TranslationDictionary  TranslationDictionary
public static Controller<TranslationDictionary, IListener<TranslationDictionary>> TranslationDictionaryController = new Controller<TranslationDictionary, IListener<TranslationDictionary>>();
//Folder  Folder
public static Controller<Folder, IListener<Folder>> FolderController = new Controller<Folder, IListener<Folder>>();
//Translation  Translation
public static Controller<Translation, IListener<Translation>> TranslationController = new Controller<Translation, IListener<Translation>>();
//SourceText  SourceText
public static Controller<SourceText, IListener<SourceText>> SourceTextController = new Controller<SourceText, IListener<SourceText>>();
//ShortcutDictionary  ShortcutDictionary
public static Controller<ShortcutDictionary, IListener<ShortcutDictionary>> ShortcutDictionaryController = new Controller<ShortcutDictionary, IListener<ShortcutDictionary>>();
//ShortcutFolder  ShortcutFolder
public static Controller<ShortcutFolder, IListener<ShortcutFolder>> ShortcutFolderController = new Controller<ShortcutFolder, IListener<ShortcutFolder>>();
//Shortcut  Shortcut
public static Controller<Shortcut, IListener<Shortcut>> ShortcutController = new Controller<Shortcut, IListener<Shortcut>>();
//Specification  Specification
public static Controller<Specification, IListener<Specification>> SpecificationController = new Controller<Specification, IListener<Specification>>();
//Chapter  Chapter
public static Controller<Chapter, IListener<Chapter>> ChapterController = new Controller<Chapter, IListener<Chapter>>();
//Paragraph  Paragraph
public static Controller<Paragraph, IListener<Paragraph>> ParagraphController = new Controller<Paragraph, IListener<Paragraph>>();
//Message  Message
public static Controller<Message, IListener<Message>> MessageController = new Controller<Message, IListener<Message>>();
//MsgVariable  MsgVariable
public static Controller<MsgVariable, IListener<MsgVariable>> MsgVariableController = new Controller<MsgVariable, IListener<MsgVariable>>();
//TypeSpec  TypeSpec
public static Controller<TypeSpec, IListener<TypeSpec>> TypeSpecController = new Controller<TypeSpec, IListener<TypeSpec>>();
//Values  Values
public static Controller<Values, IListener<Values>> ValuesController = new Controller<Values, IListener<Values>>();
//special-or-reserved-values  special_or_reserved_values
public static Controller<special_or_reserved_values, IListener<special_or_reserved_values>> special_or_reserved_valuesController = new Controller<special_or_reserved_values, IListener<special_or_reserved_values>>();
//special-or-reserved-value  special_or_reserved_value
public static Controller<special_or_reserved_value, IListener<special_or_reserved_value>> special_or_reserved_valueController = new Controller<special_or_reserved_value, IListener<special_or_reserved_value>>();
//mask  mask
public static Controller<mask, IListener<mask>> maskController = new Controller<mask, IListener<mask>>();
//match  match
public static Controller<match, IListener<match>> matchController = new Controller<match, IListener<match>>();
//meaning  meaning
public static Controller<meaning, IListener<meaning>> meaningController = new Controller<meaning, IListener<meaning>>();
//match-range  match_range
public static Controller<match_range, IListener<match_range>> match_rangeController = new Controller<match_range, IListener<match_range>>();
//resolution-formula  resolution_formula
public static Controller<resolution_formula, IListener<resolution_formula>> resolution_formulaController = new Controller<resolution_formula, IListener<resolution_formula>>();
//value  value
public static Controller<value, IListener<value>> valueController = new Controller<value, IListener<value>>();
//char-value  char_value
public static Controller<char_value, IListener<char_value>> char_valueController = new Controller<char_value, IListener<char_value>>();
//ParagraphRevision  ParagraphRevision
public static Controller<ParagraphRevision, IListener<ParagraphRevision>> ParagraphRevisionController = new Controller<ParagraphRevision, IListener<ParagraphRevision>>();
public static void ActivateAllNotifications(){
NamableController.ActivateNotification();
ReferencesParagraphController.ActivateNotification();
ReqRelatedController.ActivateNotification();
DictionaryController.ActivateNotification();
RuleDisablingController.ActivateNotification();
NameSpaceController.ActivateNotification();
ReqRefController.ActivateNotification();
TypeController.ActivateNotification();
EnumController.ActivateNotification();
EnumValueController.ActivateNotification();
RangeController.ActivateNotification();
StructureController.ActivateNotification();
StructureElementController.ActivateNotification();
StructureProcedureController.ActivateNotification();
CollectionController.ActivateNotification();
FunctionController.ActivateNotification();
ParameterController.ActivateNotification();
CaseController.ActivateNotification();
ProcedureController.ActivateNotification();
StateMachineController.ActivateNotification();
StateController.ActivateNotification();
VariableController.ActivateNotification();
RuleController.ActivateNotification();
RuleConditionController.ActivateNotification();
PreConditionController.ActivateNotification();
ActionController.ActivateNotification();
FrameController.ActivateNotification();
SubSequenceController.ActivateNotification();
TestCaseController.ActivateNotification();
StepController.ActivateNotification();
SubStepController.ActivateNotification();
ExpectationController.ActivateNotification();
DBMessageController.ActivateNotification();
DBPacketController.ActivateNotification();
DBFieldController.ActivateNotification();
TranslationDictionaryController.ActivateNotification();
FolderController.ActivateNotification();
TranslationController.ActivateNotification();
SourceTextController.ActivateNotification();
ShortcutDictionaryController.ActivateNotification();
ShortcutFolderController.ActivateNotification();
ShortcutController.ActivateNotification();
SpecificationController.ActivateNotification();
ChapterController.ActivateNotification();
ParagraphController.ActivateNotification();
MessageController.ActivateNotification();
MsgVariableController.ActivateNotification();
TypeSpecController.ActivateNotification();
ValuesController.ActivateNotification();
special_or_reserved_valuesController.ActivateNotification();
special_or_reserved_valueController.ActivateNotification();
maskController.ActivateNotification();
matchController.ActivateNotification();
meaningController.ActivateNotification();
match_rangeController.ActivateNotification();
resolution_formulaController.ActivateNotification();
valueController.ActivateNotification();
char_valueController.ActivateNotification();
ParagraphRevisionController.ActivateNotification();
}
public static void DesactivateAllNotifications(){
NamableController.DesactivateNotification();
ReferencesParagraphController.DesactivateNotification();
ReqRelatedController.DesactivateNotification();
DictionaryController.DesactivateNotification();
RuleDisablingController.DesactivateNotification();
NameSpaceController.DesactivateNotification();
ReqRefController.DesactivateNotification();
TypeController.DesactivateNotification();
EnumController.DesactivateNotification();
EnumValueController.DesactivateNotification();
RangeController.DesactivateNotification();
StructureController.DesactivateNotification();
StructureElementController.DesactivateNotification();
StructureProcedureController.DesactivateNotification();
CollectionController.DesactivateNotification();
FunctionController.DesactivateNotification();
ParameterController.DesactivateNotification();
CaseController.DesactivateNotification();
ProcedureController.DesactivateNotification();
StateMachineController.DesactivateNotification();
StateController.DesactivateNotification();
VariableController.DesactivateNotification();
RuleController.DesactivateNotification();
RuleConditionController.DesactivateNotification();
PreConditionController.DesactivateNotification();
ActionController.DesactivateNotification();
FrameController.DesactivateNotification();
SubSequenceController.DesactivateNotification();
TestCaseController.DesactivateNotification();
StepController.DesactivateNotification();
SubStepController.DesactivateNotification();
ExpectationController.DesactivateNotification();
DBMessageController.DesactivateNotification();
DBPacketController.DesactivateNotification();
DBFieldController.DesactivateNotification();
TranslationDictionaryController.DesactivateNotification();
FolderController.DesactivateNotification();
TranslationController.DesactivateNotification();
SourceTextController.DesactivateNotification();
ShortcutDictionaryController.DesactivateNotification();
ShortcutFolderController.DesactivateNotification();
ShortcutController.DesactivateNotification();
SpecificationController.DesactivateNotification();
ChapterController.DesactivateNotification();
ParagraphController.DesactivateNotification();
MessageController.DesactivateNotification();
MsgVariableController.DesactivateNotification();
TypeSpecController.DesactivateNotification();
ValuesController.DesactivateNotification();
special_or_reserved_valuesController.DesactivateNotification();
special_or_reserved_valueController.DesactivateNotification();
maskController.DesactivateNotification();
matchController.DesactivateNotification();
meaningController.DesactivateNotification();
match_rangeController.DesactivateNotification();
resolution_formulaController.DesactivateNotification();
valueController.DesactivateNotification();
char_valueController.DesactivateNotification();
ParagraphRevisionController.DesactivateNotification();
}
}
public partial class acceptor
: XmlBBaseAcceptor
{

public enum Paragraph_type {
     defaultParagraph_type,
     aTITLE,
     aDEFINITION,
     aNOTE,
     aDELETED,
     aREQUIREMENT,
     aTABLE_HEADER,
     aPROBLEM
};

public enum Paragraph_scope {
     defaultParagraph_scope,
     aOBU_AND_TRACK,
     aTRACK,
     aOBU
};

public enum Message_media {
     defaultMessage_media,
     aBalise_RBC,
     aAny,
     aRBC,
     aBalise,
     aBalise_loop_RIU,
     aLoop,
     aBalise_RBC_RIU,
     aAny_,
     aRIU,
     aRBC_RIU,
     aBalise_loop
};

public enum TypeSpec_ertms_type {
     defaultTypeSpec_ertms_type,
     adistance,
     agradient,
     alength,
     amiscellaneous,
     aclass_number,
     aidentity_number,
     aqualifier,
     atime_or_date,
     aspeed,
     atext
};

public enum meaning_type {
     defaultmeaning_type,
     ainvalid,
     aenum,
     aunknown,
     ainfinite
};

public enum maximum_Value {
     defaultmaximum_Value,
     a11,
     a15,
     a127,
     a1022,
     a255,
     a7,
     a1_55,
     a126,
     aE,
     a254,
     a125
};

public enum resolution_formula_units {
     defaultresolution_formula_units,
     m_s2,
     q_scale,
     percent,
     abyte,
     abit,
     text_string_element,
     m,
     A,
     s,
     ms,
     km_h
};

public enum resolution_formula_Value {
     defaultresolution_formula_Value,
     a0_05,
     a1,
     a10,
     a0_02,
     aintegers,
     aNumbers,
     aBinary_Coded_Decimal,
     aNumber,
     aBitset,
     a5
};

public enum VariableModeEnumType {
     defaultVariableModeEnumType,
     aIncoming,
     aOutgoing,
     aInternal,
     aInOut,
     aConstant
};

public enum MessageEnumType {
     defaultMessageEnumType,
     aEurobalise,
     aEuroloop,
     aValidatedTrainData,
     aRequestForShunting,
     aMARequest,
     aTrainPositionReport,
     aRequestToShortenMAIsGranted,
     aRequestToShortenMAIsRejected,
     aAcknowledgement,
     aAcknowledgementOfEmergencyStop,
     aTrackAheadFreeGranted,
     aEndOfMission,
     aRadioInFillRequest,
     aTrain_NoCompatibleVersionSupported,
     aTrain_InitiationOfACommunicationSession,
     aTrain_TerminationOfACommunicationSession,
     aSoMPositionReport,
     aTrain_SessionEstablished,
     aSRAuthorization,
     aMovementAuthority,
     aRecognitionOfExitFromTripMode,
     aAcknowledgementOfTrainData,
     aRequestToShortenMA,
     aConditionalEmergencyStop,
     aUnconditionalEmergencyStop,
     aRevocationOfEmergencyStop,
     aGeneralMessage,
     aSHRefused,
     aSHAuthorized,
     aRBCRIUSystemVersion,
     aMAWithShiftedLocationReference,
     aTrackAheadFreeRequest,
     aInFillMA,
     aTrack_InitiationOfACommunicationSession,
     aAcknowledgementOfTerminationOfACommunicationSession,
     aTrainRejected,
     aTrainAccepted,
     aSomPositionReportConfirmedByRBC,
     aAssignmentOfCoordinateSystem
};

public enum MessageDirectionEnumType {
     defaultMessageDirectionEnumType,
     aTrainToTrack,
     aTrackToTrain
};

public enum SPEC_IMPLEMENTED_ENUM {
     defaultSPEC_IMPLEMENTED_ENUM,
     Impl_NA,
     Impl_Implemented,
     Impl_NotImplementable,
     Impl_NewRevisionAvailable
};

public enum ST_IO {
     defaultST_IO,
     StIO_NA,
     StIO_In,
     StIO_Out
};

public enum ST_INTERFACE {
     defaultST_INTERFACE,
     StInterface_NA,
     StInterface_DMI,
     StInterface_RTM,
     StInterface_JRU,
     StInterface_TIU
};

public enum ST_LEVEL {
     defaultST_LEVEL,
     StLevel_NA,
     StLevel_L0,
     StLevel_L1,
     StLevel_LSTM,
     StLevel_L2,
     StLevel_L3
};

public enum ST_MODE {
     defaultST_MODE,
     Mode_NA,
     Mode_IS,
     Mode_NP,
     Mode_SF,
     Mode_SL,
     Mode_SB,
     Mode_SH,
     Mode_FS,
     Mode_UF,
     Mode_SR,
     Mode_OS,
     Mode_TR,
     Mode_PT,
     Mode_NL,
     Mode_SN,
     Mode_RE,
     Mode_LS,
     Mode_PSH
};

public enum RulePriority {
     defaultRulePriority,
     aVerification,
     aUpdateINTERNAL,
     aProcessing,
     aUpdateOUT,
     aCleanUp
};

public enum PrecisionEnum {
     defaultPrecisionEnum,
     aIntegerPrecision,
     aDoublePrecision
};

public enum DBMessageType {
     defaultDBMessageType,
     aEUROBALISE,
     aEUROLOOP,
     aEURORADIO
};

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static Paragraph_type lAcceptEnum_Paragraph_type (XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
  int indicator=0;
#pragma warning restore 0168, 0219
  Paragraph_type res = Paragraph_type.defaultParagraph_type;
switch (ctxt.current()) {
case 'T':
{
ctxt.advance();
switch (ctxt.current()) {
case 'I':
{
ctxt.advance();
ctxt.accept3('T','L','E');
res = Paragraph_type.aTITLE;
break;
} // Case
case 'A':
{
ctxt.advance();
ctxt.acceptString ("BLE_HEADER");
res = Paragraph_type.aTABLE_HEADER;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1506)");
break;
} // Switch
break;
} // Case
case 'R':
{
ctxt.advance();
if (ctxt.lookAheadString("EQUIREMENT")){
res = Paragraph_type.aREQUIREMENT;
} else {
ctxt.moveBack(1);
res = Paragraph_type.aREQUIREMENT;
} // If
break;
} // Case
case 'P':
{
ctxt.advance();
if (ctxt.lookAheadString("ROBLEM")){
res = Paragraph_type.aPROBLEM;
} else {
ctxt.moveBack(1);
res = Paragraph_type.aREQUIREMENT;
} // If
break;
} // Case
case 'N':
{
ctxt.advance();
if (ctxt.lookAhead3('O','T','E')){
res = Paragraph_type.aNOTE;
} else {
ctxt.moveBack(1);
res = Paragraph_type.aREQUIREMENT;
} // If
break;
} // Case
case 'D':
{
ctxt.advance();
if (ctxt.lookAhead1('E')){
switch (ctxt.current()) {
case 'L':
{
ctxt.advance();
ctxt.acceptString ("ETED");
res = Paragraph_type.aDELETED;
break;
} // Case
case 'F':
{
ctxt.advance();
ctxt.acceptString ("INITION");
res = Paragraph_type.aDEFINITION;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1513)");
break;
} // Switch
} else {
ctxt.moveBack(1);
res = Paragraph_type.aREQUIREMENT;
} // If
break;
} // Case
default:
res = Paragraph_type.aREQUIREMENT;
break;
} // Switch
return res;
}

public static  string  Enum_Paragraph_type_ToString (Paragraph_type v)
{
switch (v) {
 case Paragraph_type.aTITLE: return "TITLE";
 case Paragraph_type.aDEFINITION: return "DEFINITION";
 case Paragraph_type.aNOTE: return "NOTE";
 case Paragraph_type.aDELETED: return "DELETED";
 case Paragraph_type.aREQUIREMENT: return "REQUIREMENT";
 case Paragraph_type.aTABLE_HEADER: return "TABLE_HEADER";
 case Paragraph_type.aPROBLEM: return "PROBLEM";
} return "";
}

public static Paragraph_type StringTo_Enum_Paragraph_type( string  str)
{
if (str.Equals("TITLE")){
  return Paragraph_type.aTITLE;
} // If
if (str.Equals("DEFINITION")){
  return Paragraph_type.aDEFINITION;
} // If
if (str.Equals("NOTE")){
  return Paragraph_type.aNOTE;
} // If
if (str.Equals("DELETED")){
  return Paragraph_type.aDELETED;
} // If
if (str.Equals("REQUIREMENT")){
  return Paragraph_type.aREQUIREMENT;
} // If
if (str.Equals("TABLE_HEADER")){
  return Paragraph_type.aTABLE_HEADER;
} // If
if (str.Equals("PROBLEM")){
  return Paragraph_type.aPROBLEM;
} // If
return Paragraph_type.defaultParagraph_type;
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static Paragraph_scope lAcceptEnum_Paragraph_scope (XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
  int indicator=0;
#pragma warning restore 0168, 0219
  Paragraph_scope res = Paragraph_scope.defaultParagraph_scope;
switch (ctxt.current()) {
case 'T':
{
ctxt.advance();
if (ctxt.lookAheadString("RACK")){
res = Paragraph_scope.aTRACK;
} else {
ctxt.moveBack(1);
res = Paragraph_scope.aOBU_AND_TRACK;
} // If
break;
} // Case
case 'O':
{
ctxt.advance();
if (ctxt.lookAhead2('B','U')){
switch (ctxt.current()) {
case '_':
{
ctxt.advance();
if (ctxt.lookAheadString("AND_TRACK")){
res = Paragraph_scope.aOBU_AND_TRACK;
} else {
ctxt.moveBack(1);
res = Paragraph_scope.aOBU;
} // If
break;
} // Case
default:
res = Paragraph_scope.aOBU;
break;
} // Switch
} else {
ctxt.moveBack(1);
res = Paragraph_scope.aOBU_AND_TRACK;
} // If
break;
} // Case
default:
res = Paragraph_scope.aOBU_AND_TRACK;
break;
} // Switch
return res;
}

public static  string  Enum_Paragraph_scope_ToString (Paragraph_scope v)
{
switch (v) {
 case Paragraph_scope.aOBU_AND_TRACK: return "OBU_AND_TRACK";
 case Paragraph_scope.aTRACK: return "TRACK";
 case Paragraph_scope.aOBU: return "OBU";
} return "";
}

public static Paragraph_scope StringTo_Enum_Paragraph_scope( string  str)
{
if (str.Equals("OBU_AND_TRACK")){
  return Paragraph_scope.aOBU_AND_TRACK;
} // If
if (str.Equals("TRACK")){
  return Paragraph_scope.aTRACK;
} // If
if (str.Equals("OBU")){
  return Paragraph_scope.aOBU;
} // If
return Paragraph_scope.defaultParagraph_scope;
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static Message_media lAcceptEnum_Message_media (XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
  int indicator=0;
#pragma warning restore 0168, 0219
  Message_media res = Message_media.defaultMessage_media;
switch (ctxt.current()) {
case 'R':
{
ctxt.advance();
switch (ctxt.current()) {
case 'I':
{
ctxt.advance();
ctxt.accept('U');
res = Message_media.aRIU;
break;
} // Case
case 'B':
{
ctxt.advance();
ctxt.accept('C');
switch (ctxt.current()) {
case ',':
{
ctxt.advance();
if (ctxt.lookAheadString(" RIU")){
res = Message_media.aRBC_RIU;
} else {
ctxt.moveBack(1);
res = Message_media.aRBC;
} // If
break;
} // Case
default:
res = Message_media.aRBC;
break;
} // Switch
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1521)");
break;
} // Switch
break;
} // Case
case 'L':
{
ctxt.advance();
if (ctxt.lookAhead3('o','o','p')){
res = Message_media.aLoop;
} else {
ctxt.moveBack(1);
res = Message_media.aAny_;
} // If
break;
} // Case
case 'B':
{
ctxt.advance();
if (ctxt.lookAheadString("alise")){
switch (ctxt.current()) {
case ',':
{
ctxt.advance();
if (ctxt.lookAhead1(' ')){
switch (ctxt.current()) {
case 'l':
{
ctxt.advance();
ctxt.acceptString ("oop, RIU");
res = Message_media.aBalise_loop_RIU;
break;
} // Case
case 'R':
{
ctxt.advance();
ctxt.accept2('B','C');
switch (ctxt.current()) {
case ',':
{
ctxt.advance();
if (ctxt.lookAheadString(" RIU")){
res = Message_media.aBalise_RBC_RIU;
} else {
ctxt.moveBack(1);
res = Message_media.aBalise_RBC;
} // If
break;
} // Case
default:
res = Message_media.aBalise_RBC;
break;
} // Switch
break;
} // Case
case 'L':
{
ctxt.advance();
ctxt.accept3('o','o','p');
res = Message_media.aBalise_loop;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1529)");
break;
} // Switch
} else {
ctxt.moveBack(1);
res = Message_media.aBalise;
} // If
break;
} // Case
default:
res = Message_media.aBalise;
break;
} // Switch
} else {
ctxt.moveBack(1);
res = Message_media.aAny_;
} // If
break;
} // Case
case 'A':
{
ctxt.advance();
if (ctxt.lookAhead2('n','y')){
switch (ctxt.current()) {
case ' ':
{
ctxt.advance();
res = Message_media.aAny_;
break;
} // Case
default:
res = Message_media.aAny;
break;
} // Switch
} else {
ctxt.moveBack(1);
res = Message_media.aAny_;
} // If
break;
} // Case
default:
res = Message_media.aAny_;
break;
} // Switch
return res;
}

public static  string  Enum_Message_media_ToString (Message_media v)
{
switch (v) {
 case Message_media.aBalise_RBC: return "Balise, RBC";
 case Message_media.aAny: return "Any";
 case Message_media.aRBC: return "RBC";
 case Message_media.aBalise: return "Balise";
 case Message_media.aBalise_loop_RIU: return "Balise, loop, RIU";
 case Message_media.aLoop: return "Loop";
 case Message_media.aBalise_RBC_RIU: return "Balise, RBC, RIU";
 case Message_media.aAny_: return "Any ";
 case Message_media.aRIU: return "RIU";
 case Message_media.aRBC_RIU: return "RBC, RIU";
 case Message_media.aBalise_loop: return "Balise, Loop";
} return "";
}

public static Message_media StringTo_Enum_Message_media( string  str)
{
if (str.Equals("Balise, RBC")){
  return Message_media.aBalise_RBC;
} // If
if (str.Equals("Any")){
  return Message_media.aAny;
} // If
if (str.Equals("RBC")){
  return Message_media.aRBC;
} // If
if (str.Equals("Balise")){
  return Message_media.aBalise;
} // If
if (str.Equals("Balise, loop, RIU")){
  return Message_media.aBalise_loop_RIU;
} // If
if (str.Equals("Loop")){
  return Message_media.aLoop;
} // If
if (str.Equals("Balise, RBC, RIU")){
  return Message_media.aBalise_RBC_RIU;
} // If
if (str.Equals("Any ")){
  return Message_media.aAny_;
} // If
if (str.Equals("RIU")){
  return Message_media.aRIU;
} // If
if (str.Equals("RBC, RIU")){
  return Message_media.aRBC_RIU;
} // If
if (str.Equals("Balise, Loop")){
  return Message_media.aBalise_loop;
} // If
return Message_media.defaultMessage_media;
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static TypeSpec_ertms_type lAcceptEnum_TypeSpec_ertms_type (XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
  int indicator=0;
#pragma warning restore 0168, 0219
  TypeSpec_ertms_type res = TypeSpec_ertms_type.defaultTypeSpec_ertms_type;
switch (ctxt.current()) {
case 't':
{
ctxt.advance();
switch (ctxt.current()) {
case 'i':
{
ctxt.advance();
ctxt.acceptString ("me-or-date");
res = TypeSpec_ertms_type.atime_or_date;
break;
} // Case
case 'e':
{
ctxt.advance();
ctxt.accept2('x','t');
res = TypeSpec_ertms_type.atext;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1535)");
break;
} // Switch
break;
} // Case
case 's':
{
ctxt.advance();
if (ctxt.lookAheadString("peed")){
res = TypeSpec_ertms_type.aspeed;
} else {
ctxt.moveBack(1);
res = 0;
} // If
break;
} // Case
case 'q':
{
ctxt.advance();
if (ctxt.lookAheadString("ualifier")){
res = TypeSpec_ertms_type.aqualifier;
} else {
ctxt.moveBack(1);
res = 0;
} // If
break;
} // Case
case 'm':
{
ctxt.advance();
if (ctxt.lookAheadString("iscellaneous")){
res = TypeSpec_ertms_type.amiscellaneous;
} else {
ctxt.moveBack(1);
res = 0;
} // If
break;
} // Case
case 'l':
{
ctxt.advance();
if (ctxt.lookAheadString("ength")){
res = TypeSpec_ertms_type.alength;
} else {
ctxt.moveBack(1);
res = 0;
} // If
break;
} // Case
case 'i':
{
ctxt.advance();
if (ctxt.lookAheadString("dentity-number")){
res = TypeSpec_ertms_type.aidentity_number;
} else {
ctxt.moveBack(1);
res = 0;
} // If
break;
} // Case
case 'g':
{
ctxt.advance();
if (ctxt.lookAheadString("radient")){
res = TypeSpec_ertms_type.agradient;
} else {
ctxt.moveBack(1);
res = 0;
} // If
break;
} // Case
case 'd':
{
ctxt.advance();
if (ctxt.lookAheadString("istance")){
res = TypeSpec_ertms_type.adistance;
} else {
ctxt.moveBack(1);
res = 0;
} // If
break;
} // Case
case 'c':
{
ctxt.advance();
if (ctxt.lookAheadString("lass-number")){
res = TypeSpec_ertms_type.aclass_number;
} else {
ctxt.moveBack(1);
res = 0;
} // If
break;
} // Case
default:
res = 0;
break;
} // Switch
return res;
}

public static  string  Enum_TypeSpec_ertms_type_ToString (TypeSpec_ertms_type v)
{
switch (v) {
 case TypeSpec_ertms_type.adistance: return "distance";
 case TypeSpec_ertms_type.agradient: return "gradient";
 case TypeSpec_ertms_type.alength: return "length";
 case TypeSpec_ertms_type.amiscellaneous: return "miscellaneous";
 case TypeSpec_ertms_type.aclass_number: return "class-number";
 case TypeSpec_ertms_type.aidentity_number: return "identity-number";
 case TypeSpec_ertms_type.aqualifier: return "qualifier";
 case TypeSpec_ertms_type.atime_or_date: return "time-or-date";
 case TypeSpec_ertms_type.aspeed: return "speed";
 case TypeSpec_ertms_type.atext: return "text";
} return "";
}

public static TypeSpec_ertms_type StringTo_Enum_TypeSpec_ertms_type( string  str)
{
if (str.Equals("distance")){
  return TypeSpec_ertms_type.adistance;
} // If
if (str.Equals("gradient")){
  return TypeSpec_ertms_type.agradient;
} // If
if (str.Equals("length")){
  return TypeSpec_ertms_type.alength;
} // If
if (str.Equals("miscellaneous")){
  return TypeSpec_ertms_type.amiscellaneous;
} // If
if (str.Equals("class-number")){
  return TypeSpec_ertms_type.aclass_number;
} // If
if (str.Equals("identity-number")){
  return TypeSpec_ertms_type.aidentity_number;
} // If
if (str.Equals("qualifier")){
  return TypeSpec_ertms_type.aqualifier;
} // If
if (str.Equals("time-or-date")){
  return TypeSpec_ertms_type.atime_or_date;
} // If
if (str.Equals("speed")){
  return TypeSpec_ertms_type.aspeed;
} // If
if (str.Equals("text")){
  return TypeSpec_ertms_type.atext;
} // If
return TypeSpec_ertms_type.defaultTypeSpec_ertms_type;
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static meaning_type lAcceptEnum_meaning_type (XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
  int indicator=0;
#pragma warning restore 0168, 0219
  meaning_type res = meaning_type.defaultmeaning_type;
switch (ctxt.current()) {
case 'u':
{
ctxt.advance();
if (ctxt.lookAheadString("nknown")){
res = meaning_type.aunknown;
} else {
ctxt.moveBack(1);
res = 0;
} // If
break;
} // Case
case 'i':
{
ctxt.advance();
if (ctxt.lookAhead1('n')){
switch (ctxt.current()) {
case 'v':
{
ctxt.advance();
ctxt.acceptString ("alid");
res = meaning_type.ainvalid;
break;
} // Case
case 'f':
{
ctxt.advance();
ctxt.acceptString ("inite");
res = meaning_type.ainfinite;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1548)");
break;
} // Switch
} else {
ctxt.moveBack(1);
res = 0;
} // If
break;
} // Case
case 'e':
{
ctxt.advance();
if (ctxt.lookAhead3('n','u','m')){
res = meaning_type.aenum;
} else {
ctxt.moveBack(1);
res = 0;
} // If
break;
} // Case
default:
res = 0;
break;
} // Switch
return res;
}

public static  string  Enum_meaning_type_ToString (meaning_type v)
{
switch (v) {
 case meaning_type.ainvalid: return "invalid";
 case meaning_type.aenum: return "enum";
 case meaning_type.aunknown: return "unknown";
 case meaning_type.ainfinite: return "infinite";
} return "";
}

public static meaning_type StringTo_Enum_meaning_type( string  str)
{
if (str.Equals("invalid")){
  return meaning_type.ainvalid;
} // If
if (str.Equals("enum")){
  return meaning_type.aenum;
} // If
if (str.Equals("unknown")){
  return meaning_type.aunknown;
} // If
if (str.Equals("infinite")){
  return meaning_type.ainfinite;
} // If
return meaning_type.defaultmeaning_type;
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static maximum_Value lAcceptEnum_maximum_Value (XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
  int indicator=0;
#pragma warning restore 0168, 0219
  maximum_Value res = maximum_Value.defaultmaximum_Value;
switch (ctxt.current()) {
case 'E':
{
ctxt.advance();
res = maximum_Value.aE;
break;
} // Case
case '7':
{
ctxt.advance();
res = maximum_Value.a7;
break;
} // Case
case '2':
{
ctxt.advance();
if (ctxt.lookAhead1('5')){
switch (ctxt.current()) {
case '5':
{
ctxt.advance();
res = maximum_Value.a255;
break;
} // Case
case '4':
{
ctxt.advance();
res = maximum_Value.a254;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1555)");
break;
} // Switch
} else {
ctxt.moveBack(1);
res = 0;
} // If
break;
} // Case
case '1':
{
ctxt.advance();
switch (ctxt.current()) {
case '5':
{
ctxt.advance();
res = maximum_Value.a15;
break;
} // Case
case '2':
{
ctxt.advance();
switch (ctxt.current()) {
case '7':
{
ctxt.advance();
res = maximum_Value.a127;
break;
} // Case
case '6':
{
ctxt.advance();
res = maximum_Value.a126;
break;
} // Case
case '5':
{
ctxt.advance();
res = maximum_Value.a125;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1562)");
break;
} // Switch
break;
} // Case
case '1':
{
ctxt.advance();
res = maximum_Value.a11;
break;
} // Case
case '0':
{
ctxt.advance();
ctxt.accept2('2','2');
res = maximum_Value.a1022;
break;
} // Case
case '.':
{
ctxt.advance();
ctxt.accept2('5','5');
res = maximum_Value.a1_55;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1566)");
break;
} // Switch
break;
} // Case
default:
res = 0;
break;
} // Switch
return res;
}

public static  string  Enum_maximum_Value_ToString (maximum_Value v)
{
switch (v) {
 case maximum_Value.a11: return "11";
 case maximum_Value.a15: return "15";
 case maximum_Value.a127: return "127";
 case maximum_Value.a1022: return "1022";
 case maximum_Value.a255: return "255";
 case maximum_Value.a7: return "7";
 case maximum_Value.a1_55: return "1.55";
 case maximum_Value.a126: return "126";
 case maximum_Value.aE: return "E";
 case maximum_Value.a254: return "254";
 case maximum_Value.a125: return "125";
} return "";
}

public static maximum_Value StringTo_Enum_maximum_Value( string  str)
{
if (str.Equals("11")){
  return maximum_Value.a11;
} // If
if (str.Equals("15")){
  return maximum_Value.a15;
} // If
if (str.Equals("127")){
  return maximum_Value.a127;
} // If
if (str.Equals("1022")){
  return maximum_Value.a1022;
} // If
if (str.Equals("255")){
  return maximum_Value.a255;
} // If
if (str.Equals("7")){
  return maximum_Value.a7;
} // If
if (str.Equals("1.55")){
  return maximum_Value.a1_55;
} // If
if (str.Equals("126")){
  return maximum_Value.a126;
} // If
if (str.Equals("E")){
  return maximum_Value.aE;
} // If
if (str.Equals("254")){
  return maximum_Value.a254;
} // If
if (str.Equals("125")){
  return maximum_Value.a125;
} // If
return maximum_Value.defaultmaximum_Value;
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static resolution_formula_units lAcceptEnum_resolution_formula_units (XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
  int indicator=0;
#pragma warning restore 0168, 0219
  resolution_formula_units res = resolution_formula_units.defaultresolution_formula_units;
switch (ctxt.current()) {
case 't':
{
ctxt.advance();
if (ctxt.lookAheadString("ext-string-element")){
res = resolution_formula_units.text_string_element;
} else {
ctxt.moveBack(1);
res = 0;
} // If
break;
} // Case
case 's':
{
ctxt.advance();
res = resolution_formula_units.s;
break;
} // Case
case 'q':
{
ctxt.advance();
if (ctxt.lookAheadString("_scale")){
res = resolution_formula_units.q_scale;
} else {
ctxt.moveBack(1);
res = 0;
} // If
break;
} // Case
case 'm':
{
ctxt.advance();
switch (ctxt.current()) {
case 's':
{
ctxt.advance();
res = resolution_formula_units.ms;
break;
} // Case
case '/':
{
ctxt.advance();
if (ctxt.lookAhead2('s','2')){
res = resolution_formula_units.m_s2;
} else {
ctxt.moveBack(1);
res = resolution_formula_units.m;
} // If
break;
} // Case
default:
res = resolution_formula_units.m;
break;
} // Switch
break;
} // Case
case 'k':
{
ctxt.advance();
if (ctxt.lookAhead3('m','/','h')){
res = resolution_formula_units.km_h;
} else {
ctxt.moveBack(1);
res = 0;
} // If
break;
} // Case
case 'b':
{
ctxt.advance();
switch (ctxt.current()) {
case 'y':
{
ctxt.advance();
ctxt.accept2('t','e');
res = resolution_formula_units.abyte;
break;
} // Case
case 'i':
{
ctxt.advance();
ctxt.accept('t');
res = resolution_formula_units.abit;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1577)");
break;
} // Switch
break;
} // Case
case 'A':
{
ctxt.advance();
res = resolution_formula_units.A;
break;
} // Case
case '%':
{
ctxt.advance();
res = resolution_formula_units.percent;
break;
} // Case
default:
res = 0;
break;
} // Switch
return res;
}

public static  string  Enum_resolution_formula_units_ToString (resolution_formula_units v)
{
switch (v) {
 case resolution_formula_units.m_s2: return "m/s2";
 case resolution_formula_units.q_scale: return "q_scale";
 case resolution_formula_units.percent: return "%";
 case resolution_formula_units.abyte: return "byte";
 case resolution_formula_units.abit: return "bit";
 case resolution_formula_units.text_string_element: return "text-string-element";
 case resolution_formula_units.m: return "m";
 case resolution_formula_units.A: return "A";
 case resolution_formula_units.s: return "s";
 case resolution_formula_units.ms: return "ms";
 case resolution_formula_units.km_h: return "km/h";
} return "";
}

public static resolution_formula_units StringTo_Enum_resolution_formula_units( string  str)
{
if (str.Equals("m/s2")){
  return resolution_formula_units.m_s2;
} // If
if (str.Equals("q_scale")){
  return resolution_formula_units.q_scale;
} // If
if (str.Equals("%")){
  return resolution_formula_units.percent;
} // If
if (str.Equals("byte")){
  return resolution_formula_units.abyte;
} // If
if (str.Equals("bit")){
  return resolution_formula_units.abit;
} // If
if (str.Equals("text-string-element")){
  return resolution_formula_units.text_string_element;
} // If
if (str.Equals("m")){
  return resolution_formula_units.m;
} // If
if (str.Equals("A")){
  return resolution_formula_units.A;
} // If
if (str.Equals("s")){
  return resolution_formula_units.s;
} // If
if (str.Equals("ms")){
  return resolution_formula_units.ms;
} // If
if (str.Equals("km/h")){
  return resolution_formula_units.km_h;
} // If
return resolution_formula_units.defaultresolution_formula_units;
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static resolution_formula_Value lAcceptEnum_resolution_formula_Value (XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
  int indicator=0;
#pragma warning restore 0168, 0219
  resolution_formula_Value res = resolution_formula_Value.defaultresolution_formula_Value;
switch (ctxt.current()) {
case 'i':
{
ctxt.advance();
if (ctxt.lookAheadString("ntegers")){
res = resolution_formula_Value.aintegers;
} else {
ctxt.moveBack(1);
res = 0;
} // If
break;
} // Case
case 'N':
{
ctxt.advance();
if (ctxt.lookAheadString("umber")){
switch (ctxt.current()) {
case 's':
{
ctxt.advance();
res = resolution_formula_Value.aNumbers;
break;
} // Case
default:
res = resolution_formula_Value.aNumber;
break;
} // Switch
} else {
ctxt.moveBack(1);
res = 0;
} // If
break;
} // Case
case 'B':
{
ctxt.advance();
if (ctxt.lookAhead1('i')){
switch (ctxt.current()) {
case 't':
{
ctxt.advance();
ctxt.accept3('s','e','t');
res = resolution_formula_Value.aBitset;
break;
} // Case
case 'n':
{
ctxt.advance();
ctxt.acceptString ("ary Coded Decimal");
res = resolution_formula_Value.aBinary_Coded_Decimal;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1586)");
break;
} // Switch
} else {
ctxt.moveBack(1);
res = 0;
} // If
break;
} // Case
case '5':
{
ctxt.advance();
res = resolution_formula_Value.a5;
break;
} // Case
case '1':
{
ctxt.advance();
switch (ctxt.current()) {
case '0':
{
ctxt.advance();
res = resolution_formula_Value.a10;
break;
} // Case
default:
res = resolution_formula_Value.a1;
break;
} // Switch
break;
} // Case
case '0':
{
ctxt.advance();
if (ctxt.lookAhead2('.','0')){
switch (ctxt.current()) {
case '5':
{
ctxt.advance();
res = resolution_formula_Value.a0_05;
break;
} // Case
case '2':
{
ctxt.advance();
res = resolution_formula_Value.a0_02;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1593)");
break;
} // Switch
} else {
ctxt.moveBack(1);
res = 0;
} // If
break;
} // Case
default:
res = 0;
break;
} // Switch
return res;
}

public static  string  Enum_resolution_formula_Value_ToString (resolution_formula_Value v)
{
switch (v) {
 case resolution_formula_Value.a0_05: return "0.05";
 case resolution_formula_Value.a1: return "1";
 case resolution_formula_Value.a10: return "10";
 case resolution_formula_Value.a0_02: return "0.02";
 case resolution_formula_Value.aintegers: return "integers";
 case resolution_formula_Value.aNumbers: return "Numbers";
 case resolution_formula_Value.aBinary_Coded_Decimal: return "Binary Coded Decimal";
 case resolution_formula_Value.aNumber: return "Number";
 case resolution_formula_Value.aBitset: return "Bitset";
 case resolution_formula_Value.a5: return "5";
} return "";
}

public static resolution_formula_Value StringTo_Enum_resolution_formula_Value( string  str)
{
if (str.Equals("0.05")){
  return resolution_formula_Value.a0_05;
} // If
if (str.Equals("1")){
  return resolution_formula_Value.a1;
} // If
if (str.Equals("10")){
  return resolution_formula_Value.a10;
} // If
if (str.Equals("0.02")){
  return resolution_formula_Value.a0_02;
} // If
if (str.Equals("integers")){
  return resolution_formula_Value.aintegers;
} // If
if (str.Equals("Numbers")){
  return resolution_formula_Value.aNumbers;
} // If
if (str.Equals("Binary Coded Decimal")){
  return resolution_formula_Value.aBinary_Coded_Decimal;
} // If
if (str.Equals("Number")){
  return resolution_formula_Value.aNumber;
} // If
if (str.Equals("Bitset")){
  return resolution_formula_Value.aBitset;
} // If
if (str.Equals("5")){
  return resolution_formula_Value.a5;
} // If
return resolution_formula_Value.defaultresolution_formula_Value;
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static VariableModeEnumType lAcceptEnum_VariableModeEnumType (XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
  int indicator=0;
#pragma warning restore 0168, 0219
  VariableModeEnumType res = VariableModeEnumType.defaultVariableModeEnumType;
switch (ctxt.current()) {
case 'O':
{
ctxt.advance();
if (ctxt.lookAheadString("utgoing")){
res = VariableModeEnumType.aOutgoing;
} else {
ctxt.moveBack(1);
res = VariableModeEnumType.aInternal;
} // If
break;
} // Case
case 'I':
{
ctxt.advance();
if (ctxt.lookAhead1('n')){
switch (ctxt.current()) {
case 't':
{
ctxt.advance();
ctxt.acceptString ("ernal");
res = VariableModeEnumType.aInternal;
break;
} // Case
case 'c':
{
ctxt.advance();
ctxt.acceptString ("oming");
res = VariableModeEnumType.aIncoming;
break;
} // Case
case 'O':
{
ctxt.advance();
ctxt.accept2('u','t');
res = VariableModeEnumType.aInOut;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1599)");
break;
} // Switch
} else {
ctxt.moveBack(1);
res = VariableModeEnumType.aInternal;
} // If
break;
} // Case
case 'C':
{
ctxt.advance();
if (ctxt.lookAheadString("onstant")){
res = VariableModeEnumType.aConstant;
} else {
ctxt.moveBack(1);
res = VariableModeEnumType.aInternal;
} // If
break;
} // Case
default:
res = VariableModeEnumType.aInternal;
break;
} // Switch
return res;
}

public static  string  Enum_VariableModeEnumType_ToString (VariableModeEnumType v)
{
switch (v) {
 case VariableModeEnumType.aIncoming: return "Incoming";
 case VariableModeEnumType.aOutgoing: return "Outgoing";
 case VariableModeEnumType.aInternal: return "Internal";
 case VariableModeEnumType.aInOut: return "InOut";
 case VariableModeEnumType.aConstant: return "Constant";
} return "";
}

public static VariableModeEnumType StringTo_Enum_VariableModeEnumType( string  str)
{
if (str.Equals("Incoming")){
  return VariableModeEnumType.aIncoming;
} // If
if (str.Equals("Outgoing")){
  return VariableModeEnumType.aOutgoing;
} // If
if (str.Equals("Internal")){
  return VariableModeEnumType.aInternal;
} // If
if (str.Equals("InOut")){
  return VariableModeEnumType.aInOut;
} // If
if (str.Equals("Constant")){
  return VariableModeEnumType.aConstant;
} // If
return VariableModeEnumType.defaultVariableModeEnumType;
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static MessageEnumType lAcceptEnum_MessageEnumType (XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
  int indicator=0;
#pragma warning restore 0168, 0219
  MessageEnumType res = MessageEnumType.defaultMessageEnumType;
switch (ctxt.current()) {
case 'V':
{
ctxt.advance();
if (ctxt.lookAheadString("alidatedTrainData")){
res = MessageEnumType.aValidatedTrainData;
} else {
ctxt.moveBack(1);
res = 0;
} // If
break;
} // Case
case 'U':
{
ctxt.advance();
if (ctxt.lookAheadString("nconditionalEmergencyStop")){
res = MessageEnumType.aUnconditionalEmergencyStop;
} else {
ctxt.moveBack(1);
res = 0;
} // If
break;
} // Case
case 'T':
{
ctxt.advance();
if (ctxt.lookAhead2('r','a')){
switch (ctxt.current()) {
case 'i':
{
ctxt.advance();
ctxt.accept('n');
switch (ctxt.current()) {
case '_':
{
ctxt.advance();
switch (ctxt.current()) {
case 'T':
{
ctxt.advance();
ctxt.acceptString ("erminationOfACommunicationSession");
res = MessageEnumType.aTrain_TerminationOfACommunicationSession;
break;
} // Case
case 'S':
{
ctxt.advance();
ctxt.acceptString ("essionEstablished");
res = MessageEnumType.aTrain_SessionEstablished;
break;
} // Case
case 'N':
{
ctxt.advance();
ctxt.acceptString ("oCompatibleVersionSupported");
res = MessageEnumType.aTrain_NoCompatibleVersionSupported;
break;
} // Case
case 'I':
{
ctxt.advance();
ctxt.acceptString ("nitiationOfACommunicationSession");
res = MessageEnumType.aTrain_InitiationOfACommunicationSession;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1610)");
break;
} // Switch
break;
} // Case
case 'R':
{
ctxt.advance();
ctxt.acceptString ("ejected");
res = MessageEnumType.aTrainRejected;
break;
} // Case
case 'P':
{
ctxt.advance();
ctxt.acceptString ("ositionReport");
res = MessageEnumType.aTrainPositionReport;
break;
} // Case
case 'A':
{
ctxt.advance();
ctxt.acceptString ("ccepted");
res = MessageEnumType.aTrainAccepted;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1614)");
break;
} // Switch
break;
} // Case
case 'c':
{
ctxt.advance();
ctxt.accept('k');
switch (ctxt.current()) {
case '_':
{
ctxt.advance();
ctxt.acceptString ("InitiationOfACommunicationSession");
res = MessageEnumType.aTrack_InitiationOfACommunicationSession;
break;
} // Case
case 'A':
{
ctxt.advance();
ctxt.acceptString ("headFree");
switch (ctxt.current()) {
case 'R':
{
ctxt.advance();
ctxt.acceptString ("equest");
res = MessageEnumType.aTrackAheadFreeRequest;
break;
} // Case
case 'G':
{
ctxt.advance();
ctxt.acceptString ("ranted");
res = MessageEnumType.aTrackAheadFreeGranted;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1620)");
break;
} // Switch
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1621)");
break;
} // Switch
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1622)");
break;
} // Switch
} else {
ctxt.moveBack(1);
res = 0;
} // If
break;
} // Case
case 'S':
{
ctxt.advance();
switch (ctxt.current()) {
case 'o':
{
ctxt.advance();
switch (ctxt.current()) {
case 'm':
{
ctxt.advance();
ctxt.acceptString ("PositionReportConfirmedByRBC");
res = MessageEnumType.aSomPositionReportConfirmedByRBC;
break;
} // Case
case 'M':
{
ctxt.advance();
ctxt.acceptString ("PositionReport");
res = MessageEnumType.aSoMPositionReport;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1627)");
break;
} // Switch
break;
} // Case
case 'R':
{
ctxt.advance();
ctxt.acceptString ("Authorization");
res = MessageEnumType.aSRAuthorization;
break;
} // Case
case 'H':
{
ctxt.advance();
switch (ctxt.current()) {
case 'R':
{
ctxt.advance();
ctxt.acceptString ("efused");
res = MessageEnumType.aSHRefused;
break;
} // Case
case 'A':
{
ctxt.advance();
ctxt.acceptString ("uthorized");
res = MessageEnumType.aSHAuthorized;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1632)");
break;
} // Switch
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1633)");
break;
} // Switch
break;
} // Case
case 'R':
{
ctxt.advance();
switch (ctxt.current()) {
case 'e':
{
ctxt.advance();
switch (ctxt.current()) {
case 'v':
{
ctxt.advance();
ctxt.acceptString ("ocationOfEmergencyStop");
res = MessageEnumType.aRevocationOfEmergencyStop;
break;
} // Case
case 'q':
{
ctxt.advance();
ctxt.acceptString ("uest");
switch (ctxt.current()) {
case 'T':
{
ctxt.advance();
ctxt.acceptString ("oShortenMA");
switch (ctxt.current()) {
case 'I':
{
ctxt.advance();
if (ctxt.lookAhead1('s')){
switch (ctxt.current()) {
case 'R':
{
ctxt.advance();
ctxt.acceptString ("ejected");
res = MessageEnumType.aRequestToShortenMAIsRejected;
break;
} // Case
case 'G':
{
ctxt.advance();
ctxt.acceptString ("ranted");
res = MessageEnumType.aRequestToShortenMAIsGranted;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1642)");
break;
} // Switch
} else {
ctxt.moveBack(1);
res = MessageEnumType.aRequestToShortenMA;
} // If
break;
} // Case
default:
res = MessageEnumType.aRequestToShortenMA;
break;
} // Switch
break;
} // Case
case 'F':
{
ctxt.advance();
ctxt.acceptString ("orShunting");
res = MessageEnumType.aRequestForShunting;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1644)");
break;
} // Switch
break;
} // Case
case 'c':
{
ctxt.advance();
ctxt.acceptString ("ognitionOfExitFromTripMode");
res = MessageEnumType.aRecognitionOfExitFromTripMode;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1646)");
break;
} // Switch
break;
} // Case
case 'a':
{
ctxt.advance();
ctxt.acceptString ("dioInFillRequest");
res = MessageEnumType.aRadioInFillRequest;
break;
} // Case
case 'B':
{
ctxt.advance();
ctxt.acceptString ("CRIUSystemVersion");
res = MessageEnumType.aRBCRIUSystemVersion;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1649)");
break;
} // Switch
break;
} // Case
case 'M':
{
ctxt.advance();
switch (ctxt.current()) {
case 'o':
{
ctxt.advance();
ctxt.acceptString ("vementAuthority");
res = MessageEnumType.aMovementAuthority;
break;
} // Case
case 'A':
{
ctxt.advance();
switch (ctxt.current()) {
case 'W':
{
ctxt.advance();
ctxt.acceptString ("ithShiftedLocationReference");
res = MessageEnumType.aMAWithShiftedLocationReference;
break;
} // Case
case 'R':
{
ctxt.advance();
ctxt.acceptString ("equest");
res = MessageEnumType.aMARequest;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1655)");
break;
} // Switch
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1656)");
break;
} // Switch
break;
} // Case
case 'I':
{
ctxt.advance();
if (ctxt.lookAheadString("nFillMA")){
res = MessageEnumType.aInFillMA;
} else {
ctxt.moveBack(1);
res = 0;
} // If
break;
} // Case
case 'G':
{
ctxt.advance();
if (ctxt.lookAheadString("eneralMessage")){
res = MessageEnumType.aGeneralMessage;
} else {
ctxt.moveBack(1);
res = 0;
} // If
break;
} // Case
case 'E':
{
ctxt.advance();
switch (ctxt.current()) {
case 'u':
{
ctxt.advance();
ctxt.accept2('r','o');
switch (ctxt.current()) {
case 'l':
{
ctxt.advance();
ctxt.accept3('o','o','p');
res = MessageEnumType.aEuroloop;
break;
} // Case
case 'b':
{
ctxt.advance();
ctxt.acceptString ("alise");
res = MessageEnumType.aEurobalise;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1663)");
break;
} // Switch
break;
} // Case
case 'n':
{
ctxt.advance();
ctxt.acceptString ("dOfMission");
res = MessageEnumType.aEndOfMission;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1665)");
break;
} // Switch
break;
} // Case
case 'C':
{
ctxt.advance();
if (ctxt.lookAheadString("onditionalEmergencyStop")){
res = MessageEnumType.aConditionalEmergencyStop;
} else {
ctxt.moveBack(1);
res = 0;
} // If
break;
} // Case
case 'A':
{
ctxt.advance();
switch (ctxt.current()) {
case 's':
{
ctxt.advance();
ctxt.acceptString ("signmentOfCoordinateSystem");
res = MessageEnumType.aAssignmentOfCoordinateSystem;
break;
} // Case
case 'c':
{
ctxt.advance();
ctxt.acceptString ("knowledgement");
switch (ctxt.current()) {
case 'O':
{
ctxt.advance();
if (ctxt.lookAhead1('f')){
switch (ctxt.current()) {
case 'T':
{
ctxt.advance();
switch (ctxt.current()) {
case 'r':
{
ctxt.advance();
ctxt.acceptString ("ainData");
res = MessageEnumType.aAcknowledgementOfTrainData;
break;
} // Case
case 'e':
{
ctxt.advance();
ctxt.acceptString ("rminationOfACommunicationSession");
res = MessageEnumType.aAcknowledgementOfTerminationOfACommunicationSession;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1674)");
break;
} // Switch
break;
} // Case
case 'E':
{
ctxt.advance();
ctxt.acceptString ("mergencyStop");
res = MessageEnumType.aAcknowledgementOfEmergencyStop;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1676)");
break;
} // Switch
} else {
ctxt.moveBack(1);
res = MessageEnumType.aAcknowledgement;
} // If
break;
} // Case
default:
res = MessageEnumType.aAcknowledgement;
break;
} // Switch
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1677)");
break;
} // Switch
break;
} // Case
default:
res = 0;
break;
} // Switch
return res;
}

public static  string  Enum_MessageEnumType_ToString (MessageEnumType v)
{
switch (v) {
 case MessageEnumType.aEurobalise: return "Eurobalise";
 case MessageEnumType.aEuroloop: return "Euroloop";
 case MessageEnumType.aValidatedTrainData: return "ValidatedTrainData";
 case MessageEnumType.aRequestForShunting: return "RequestForShunting";
 case MessageEnumType.aMARequest: return "MARequest";
 case MessageEnumType.aTrainPositionReport: return "TrainPositionReport";
 case MessageEnumType.aRequestToShortenMAIsGranted: return "RequestToShortenMAIsGranted";
 case MessageEnumType.aRequestToShortenMAIsRejected: return "RequestToShortenMAIsRejected";
 case MessageEnumType.aAcknowledgement: return "Acknowledgement";
 case MessageEnumType.aAcknowledgementOfEmergencyStop: return "AcknowledgementOfEmergencyStop";
 case MessageEnumType.aTrackAheadFreeGranted: return "TrackAheadFreeGranted";
 case MessageEnumType.aEndOfMission: return "EndOfMission";
 case MessageEnumType.aRadioInFillRequest: return "RadioInFillRequest";
 case MessageEnumType.aTrain_NoCompatibleVersionSupported: return "Train_NoCompatibleVersionSupported";
 case MessageEnumType.aTrain_InitiationOfACommunicationSession: return "Train_InitiationOfACommunicationSession";
 case MessageEnumType.aTrain_TerminationOfACommunicationSession: return "Train_TerminationOfACommunicationSession";
 case MessageEnumType.aSoMPositionReport: return "SoMPositionReport";
 case MessageEnumType.aTrain_SessionEstablished: return "Train_SessionEstablished";
 case MessageEnumType.aSRAuthorization: return "SRAuthorization";
 case MessageEnumType.aMovementAuthority: return "MovementAuthority";
 case MessageEnumType.aRecognitionOfExitFromTripMode: return "RecognitionOfExitFromTripMode";
 case MessageEnumType.aAcknowledgementOfTrainData: return "AcknowledgementOfTrainData";
 case MessageEnumType.aRequestToShortenMA: return "RequestToShortenMA";
 case MessageEnumType.aConditionalEmergencyStop: return "ConditionalEmergencyStop";
 case MessageEnumType.aUnconditionalEmergencyStop: return "UnconditionalEmergencyStop";
 case MessageEnumType.aRevocationOfEmergencyStop: return "RevocationOfEmergencyStop";
 case MessageEnumType.aGeneralMessage: return "GeneralMessage";
 case MessageEnumType.aSHRefused: return "SHRefused";
 case MessageEnumType.aSHAuthorized: return "SHAuthorized";
 case MessageEnumType.aRBCRIUSystemVersion: return "RBCRIUSystemVersion";
 case MessageEnumType.aMAWithShiftedLocationReference: return "MAWithShiftedLocationReference";
 case MessageEnumType.aTrackAheadFreeRequest: return "TrackAheadFreeRequest";
 case MessageEnumType.aInFillMA: return "InFillMA";
 case MessageEnumType.aTrack_InitiationOfACommunicationSession: return "Track_InitiationOfACommunicationSession";
 case MessageEnumType.aAcknowledgementOfTerminationOfACommunicationSession: return "AcknowledgementOfTerminationOfACommunicationSession";
 case MessageEnumType.aTrainRejected: return "TrainRejected";
 case MessageEnumType.aTrainAccepted: return "TrainAccepted";
 case MessageEnumType.aSomPositionReportConfirmedByRBC: return "SomPositionReportConfirmedByRBC";
 case MessageEnumType.aAssignmentOfCoordinateSystem: return "AssignmentOfCoordinateSystem";
} return "";
}

public static MessageEnumType StringTo_Enum_MessageEnumType( string  str)
{
if (str.Equals("Eurobalise")){
  return MessageEnumType.aEurobalise;
} // If
if (str.Equals("Euroloop")){
  return MessageEnumType.aEuroloop;
} // If
if (str.Equals("ValidatedTrainData")){
  return MessageEnumType.aValidatedTrainData;
} // If
if (str.Equals("RequestForShunting")){
  return MessageEnumType.aRequestForShunting;
} // If
if (str.Equals("MARequest")){
  return MessageEnumType.aMARequest;
} // If
if (str.Equals("TrainPositionReport")){
  return MessageEnumType.aTrainPositionReport;
} // If
if (str.Equals("RequestToShortenMAIsGranted")){
  return MessageEnumType.aRequestToShortenMAIsGranted;
} // If
if (str.Equals("RequestToShortenMAIsRejected")){
  return MessageEnumType.aRequestToShortenMAIsRejected;
} // If
if (str.Equals("Acknowledgement")){
  return MessageEnumType.aAcknowledgement;
} // If
if (str.Equals("AcknowledgementOfEmergencyStop")){
  return MessageEnumType.aAcknowledgementOfEmergencyStop;
} // If
if (str.Equals("TrackAheadFreeGranted")){
  return MessageEnumType.aTrackAheadFreeGranted;
} // If
if (str.Equals("EndOfMission")){
  return MessageEnumType.aEndOfMission;
} // If
if (str.Equals("RadioInFillRequest")){
  return MessageEnumType.aRadioInFillRequest;
} // If
if (str.Equals("Train_NoCompatibleVersionSupported")){
  return MessageEnumType.aTrain_NoCompatibleVersionSupported;
} // If
if (str.Equals("Train_InitiationOfACommunicationSession")){
  return MessageEnumType.aTrain_InitiationOfACommunicationSession;
} // If
if (str.Equals("Train_TerminationOfACommunicationSession")){
  return MessageEnumType.aTrain_TerminationOfACommunicationSession;
} // If
if (str.Equals("SoMPositionReport")){
  return MessageEnumType.aSoMPositionReport;
} // If
if (str.Equals("Train_SessionEstablished")){
  return MessageEnumType.aTrain_SessionEstablished;
} // If
if (str.Equals("SRAuthorization")){
  return MessageEnumType.aSRAuthorization;
} // If
if (str.Equals("MovementAuthority")){
  return MessageEnumType.aMovementAuthority;
} // If
if (str.Equals("RecognitionOfExitFromTripMode")){
  return MessageEnumType.aRecognitionOfExitFromTripMode;
} // If
if (str.Equals("AcknowledgementOfTrainData")){
  return MessageEnumType.aAcknowledgementOfTrainData;
} // If
if (str.Equals("RequestToShortenMA")){
  return MessageEnumType.aRequestToShortenMA;
} // If
if (str.Equals("ConditionalEmergencyStop")){
  return MessageEnumType.aConditionalEmergencyStop;
} // If
if (str.Equals("UnconditionalEmergencyStop")){
  return MessageEnumType.aUnconditionalEmergencyStop;
} // If
if (str.Equals("RevocationOfEmergencyStop")){
  return MessageEnumType.aRevocationOfEmergencyStop;
} // If
if (str.Equals("GeneralMessage")){
  return MessageEnumType.aGeneralMessage;
} // If
if (str.Equals("SHRefused")){
  return MessageEnumType.aSHRefused;
} // If
if (str.Equals("SHAuthorized")){
  return MessageEnumType.aSHAuthorized;
} // If
if (str.Equals("RBCRIUSystemVersion")){
  return MessageEnumType.aRBCRIUSystemVersion;
} // If
if (str.Equals("MAWithShiftedLocationReference")){
  return MessageEnumType.aMAWithShiftedLocationReference;
} // If
if (str.Equals("TrackAheadFreeRequest")){
  return MessageEnumType.aTrackAheadFreeRequest;
} // If
if (str.Equals("InFillMA")){
  return MessageEnumType.aInFillMA;
} // If
if (str.Equals("Track_InitiationOfACommunicationSession")){
  return MessageEnumType.aTrack_InitiationOfACommunicationSession;
} // If
if (str.Equals("AcknowledgementOfTerminationOfACommunicationSession")){
  return MessageEnumType.aAcknowledgementOfTerminationOfACommunicationSession;
} // If
if (str.Equals("TrainRejected")){
  return MessageEnumType.aTrainRejected;
} // If
if (str.Equals("TrainAccepted")){
  return MessageEnumType.aTrainAccepted;
} // If
if (str.Equals("SomPositionReportConfirmedByRBC")){
  return MessageEnumType.aSomPositionReportConfirmedByRBC;
} // If
if (str.Equals("AssignmentOfCoordinateSystem")){
  return MessageEnumType.aAssignmentOfCoordinateSystem;
} // If
return MessageEnumType.defaultMessageEnumType;
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static MessageDirectionEnumType lAcceptEnum_MessageDirectionEnumType (XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
  int indicator=0;
#pragma warning restore 0168, 0219
  MessageDirectionEnumType res = MessageDirectionEnumType.defaultMessageDirectionEnumType;
switch (ctxt.current()) {
case 'T':
{
ctxt.advance();
if (ctxt.lookAhead2('r','a')){
switch (ctxt.current()) {
case 'i':
{
ctxt.advance();
ctxt.acceptString ("nToTrack");
res = MessageDirectionEnumType.aTrainToTrack;
break;
} // Case
case 'c':
{
ctxt.advance();
ctxt.acceptString ("kToTrain");
res = MessageDirectionEnumType.aTrackToTrain;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1681)");
break;
} // Switch
} else {
ctxt.moveBack(1);
res = 0;
} // If
break;
} // Case
default:
res = 0;
break;
} // Switch
return res;
}

public static  string  Enum_MessageDirectionEnumType_ToString (MessageDirectionEnumType v)
{
switch (v) {
 case MessageDirectionEnumType.aTrainToTrack: return "TrainToTrack";
 case MessageDirectionEnumType.aTrackToTrain: return "TrackToTrain";
} return "";
}

public static MessageDirectionEnumType StringTo_Enum_MessageDirectionEnumType( string  str)
{
if (str.Equals("TrainToTrack")){
  return MessageDirectionEnumType.aTrainToTrack;
} // If
if (str.Equals("TrackToTrain")){
  return MessageDirectionEnumType.aTrackToTrain;
} // If
return MessageDirectionEnumType.defaultMessageDirectionEnumType;
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static SPEC_IMPLEMENTED_ENUM lAcceptEnum_SPEC_IMPLEMENTED_ENUM (XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
  int indicator=0;
#pragma warning restore 0168, 0219
  SPEC_IMPLEMENTED_ENUM res = SPEC_IMPLEMENTED_ENUM.defaultSPEC_IMPLEMENTED_ENUM;
switch (ctxt.current()) {
case 'N':
{
ctxt.advance();
switch (ctxt.current()) {
case 'o':
{
ctxt.advance();
ctxt.acceptString ("tImplementable");
res = SPEC_IMPLEMENTED_ENUM.Impl_NotImplementable;
break;
} // Case
case 'e':
{
ctxt.advance();
ctxt.acceptString ("wRevisionAvailable");
res = SPEC_IMPLEMENTED_ENUM.Impl_NewRevisionAvailable;
break;
} // Case
case 'A':
{
ctxt.advance();
res = SPEC_IMPLEMENTED_ENUM.Impl_NA;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1686)");
break;
} // Switch
break;
} // Case
case 'I':
{
ctxt.advance();
if (ctxt.lookAheadString("mplemented")){
res = SPEC_IMPLEMENTED_ENUM.Impl_Implemented;
} else {
ctxt.moveBack(1);
res = SPEC_IMPLEMENTED_ENUM.Impl_NA;
} // If
break;
} // Case
default:
res = SPEC_IMPLEMENTED_ENUM.Impl_NA;
break;
} // Switch
return res;
}

public static  string  Enum_SPEC_IMPLEMENTED_ENUM_ToString (SPEC_IMPLEMENTED_ENUM v)
{
switch (v) {
 case SPEC_IMPLEMENTED_ENUM.Impl_NA: return "NA";
 case SPEC_IMPLEMENTED_ENUM.Impl_Implemented: return "Implemented";
 case SPEC_IMPLEMENTED_ENUM.Impl_NotImplementable: return "NotImplementable";
 case SPEC_IMPLEMENTED_ENUM.Impl_NewRevisionAvailable: return "NewRevisionAvailable";
} return "";
}

public static SPEC_IMPLEMENTED_ENUM StringTo_Enum_SPEC_IMPLEMENTED_ENUM( string  str)
{
if (str.Equals("NA")){
  return SPEC_IMPLEMENTED_ENUM.Impl_NA;
} // If
if (str.Equals("Implemented")){
  return SPEC_IMPLEMENTED_ENUM.Impl_Implemented;
} // If
if (str.Equals("NotImplementable")){
  return SPEC_IMPLEMENTED_ENUM.Impl_NotImplementable;
} // If
if (str.Equals("NewRevisionAvailable")){
  return SPEC_IMPLEMENTED_ENUM.Impl_NewRevisionAvailable;
} // If
return SPEC_IMPLEMENTED_ENUM.defaultSPEC_IMPLEMENTED_ENUM;
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static ST_IO lAcceptEnum_ST_IO (XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
  int indicator=0;
#pragma warning restore 0168, 0219
  ST_IO res = ST_IO.defaultST_IO;
switch (ctxt.current()) {
case 'O':
{
ctxt.advance();
if (ctxt.lookAhead2('u','t')){
res = ST_IO.StIO_Out;
} else {
ctxt.moveBack(1);
res = ST_IO.StIO_NA;
} // If
break;
} // Case
case 'N':
{
ctxt.advance();
if (ctxt.lookAhead1('A')){
res = ST_IO.StIO_NA;
} else {
ctxt.moveBack(1);
res = ST_IO.StIO_NA;
} // If
break;
} // Case
case 'I':
{
ctxt.advance();
if (ctxt.lookAhead1('n')){
res = ST_IO.StIO_In;
} else {
ctxt.moveBack(1);
res = ST_IO.StIO_NA;
} // If
break;
} // Case
default:
res = ST_IO.StIO_NA;
break;
} // Switch
return res;
}

public static  string  Enum_ST_IO_ToString (ST_IO v)
{
switch (v) {
 case ST_IO.StIO_NA: return "NA";
 case ST_IO.StIO_In: return "In";
 case ST_IO.StIO_Out: return "Out";
} return "";
}

public static ST_IO StringTo_Enum_ST_IO( string  str)
{
if (str.Equals("NA")){
  return ST_IO.StIO_NA;
} // If
if (str.Equals("In")){
  return ST_IO.StIO_In;
} // If
if (str.Equals("Out")){
  return ST_IO.StIO_Out;
} // If
return ST_IO.defaultST_IO;
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static ST_INTERFACE lAcceptEnum_ST_INTERFACE (XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
  int indicator=0;
#pragma warning restore 0168, 0219
  ST_INTERFACE res = ST_INTERFACE.defaultST_INTERFACE;
switch (ctxt.current()) {
case 'T':
{
ctxt.advance();
if (ctxt.lookAhead2('I','U')){
res = ST_INTERFACE.StInterface_TIU;
} else {
ctxt.moveBack(1);
res = ST_INTERFACE.StInterface_NA;
} // If
break;
} // Case
case 'R':
{
ctxt.advance();
if (ctxt.lookAhead2('T','M')){
res = ST_INTERFACE.StInterface_RTM;
} else {
ctxt.moveBack(1);
res = ST_INTERFACE.StInterface_NA;
} // If
break;
} // Case
case 'N':
{
ctxt.advance();
if (ctxt.lookAhead1('A')){
res = ST_INTERFACE.StInterface_NA;
} else {
ctxt.moveBack(1);
res = ST_INTERFACE.StInterface_NA;
} // If
break;
} // Case
case 'J':
{
ctxt.advance();
if (ctxt.lookAhead2('R','U')){
res = ST_INTERFACE.StInterface_JRU;
} else {
ctxt.moveBack(1);
res = ST_INTERFACE.StInterface_NA;
} // If
break;
} // Case
case 'D':
{
ctxt.advance();
if (ctxt.lookAhead2('M','I')){
res = ST_INTERFACE.StInterface_DMI;
} else {
ctxt.moveBack(1);
res = ST_INTERFACE.StInterface_NA;
} // If
break;
} // Case
default:
res = ST_INTERFACE.StInterface_NA;
break;
} // Switch
return res;
}

public static  string  Enum_ST_INTERFACE_ToString (ST_INTERFACE v)
{
switch (v) {
 case ST_INTERFACE.StInterface_NA: return "NA";
 case ST_INTERFACE.StInterface_DMI: return "DMI";
 case ST_INTERFACE.StInterface_RTM: return "RTM";
 case ST_INTERFACE.StInterface_JRU: return "JRU";
 case ST_INTERFACE.StInterface_TIU: return "TIU";
} return "";
}

public static ST_INTERFACE StringTo_Enum_ST_INTERFACE( string  str)
{
if (str.Equals("NA")){
  return ST_INTERFACE.StInterface_NA;
} // If
if (str.Equals("DMI")){
  return ST_INTERFACE.StInterface_DMI;
} // If
if (str.Equals("RTM")){
  return ST_INTERFACE.StInterface_RTM;
} // If
if (str.Equals("JRU")){
  return ST_INTERFACE.StInterface_JRU;
} // If
if (str.Equals("TIU")){
  return ST_INTERFACE.StInterface_TIU;
} // If
return ST_INTERFACE.defaultST_INTERFACE;
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static ST_LEVEL lAcceptEnum_ST_LEVEL (XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
  int indicator=0;
#pragma warning restore 0168, 0219
  ST_LEVEL res = ST_LEVEL.defaultST_LEVEL;
switch (ctxt.current()) {
case 'N':
{
ctxt.advance();
if (ctxt.lookAhead1('A')){
res = ST_LEVEL.StLevel_NA;
} else {
ctxt.moveBack(1);
res = ST_LEVEL.StLevel_NA;
} // If
break;
} // Case
case 'L':
{
ctxt.advance();
switch (ctxt.current()) {
case 'S':
{
ctxt.advance();
ctxt.accept2('T','M');
res = ST_LEVEL.StLevel_LSTM;
break;
} // Case
case '3':
{
ctxt.advance();
res = ST_LEVEL.StLevel_L3;
break;
} // Case
case '2':
{
ctxt.advance();
res = ST_LEVEL.StLevel_L2;
break;
} // Case
case '1':
{
ctxt.advance();
res = ST_LEVEL.StLevel_L1;
break;
} // Case
case '0':
{
ctxt.advance();
res = ST_LEVEL.StLevel_L0;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1703)");
break;
} // Switch
break;
} // Case
default:
res = ST_LEVEL.StLevel_NA;
break;
} // Switch
return res;
}

public static  string  Enum_ST_LEVEL_ToString (ST_LEVEL v)
{
switch (v) {
 case ST_LEVEL.StLevel_NA: return "NA";
 case ST_LEVEL.StLevel_L0: return "L0";
 case ST_LEVEL.StLevel_L1: return "L1";
 case ST_LEVEL.StLevel_LSTM: return "LSTM";
 case ST_LEVEL.StLevel_L2: return "L2";
 case ST_LEVEL.StLevel_L3: return "L3";
} return "";
}

public static ST_LEVEL StringTo_Enum_ST_LEVEL( string  str)
{
if (str.Equals("NA")){
  return ST_LEVEL.StLevel_NA;
} // If
if (str.Equals("L0")){
  return ST_LEVEL.StLevel_L0;
} // If
if (str.Equals("L1")){
  return ST_LEVEL.StLevel_L1;
} // If
if (str.Equals("LSTM")){
  return ST_LEVEL.StLevel_LSTM;
} // If
if (str.Equals("L2")){
  return ST_LEVEL.StLevel_L2;
} // If
if (str.Equals("L3")){
  return ST_LEVEL.StLevel_L3;
} // If
return ST_LEVEL.defaultST_LEVEL;
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static ST_MODE lAcceptEnum_ST_MODE (XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
  int indicator=0;
#pragma warning restore 0168, 0219
  ST_MODE res = ST_MODE.defaultST_MODE;
switch (ctxt.current()) {
case 'U':
{
ctxt.advance();
if (ctxt.lookAhead1('F')){
res = ST_MODE.Mode_UF;
} else {
ctxt.moveBack(1);
res = ST_MODE.Mode_NA;
} // If
break;
} // Case
case 'T':
{
ctxt.advance();
if (ctxt.lookAhead1('R')){
res = ST_MODE.Mode_TR;
} else {
ctxt.moveBack(1);
res = ST_MODE.Mode_NA;
} // If
break;
} // Case
case 'S':
{
ctxt.advance();
switch (ctxt.current()) {
case 'R':
{
ctxt.advance();
res = ST_MODE.Mode_SR;
break;
} // Case
case 'N':
{
ctxt.advance();
res = ST_MODE.Mode_SN;
break;
} // Case
case 'L':
{
ctxt.advance();
res = ST_MODE.Mode_SL;
break;
} // Case
case 'H':
{
ctxt.advance();
res = ST_MODE.Mode_SH;
break;
} // Case
case 'F':
{
ctxt.advance();
res = ST_MODE.Mode_SF;
break;
} // Case
case 'B':
{
ctxt.advance();
res = ST_MODE.Mode_SB;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1713)");
break;
} // Switch
break;
} // Case
case 'R':
{
ctxt.advance();
if (ctxt.lookAhead1('E')){
res = ST_MODE.Mode_RE;
} else {
ctxt.moveBack(1);
res = ST_MODE.Mode_NA;
} // If
break;
} // Case
case 'P':
{
ctxt.advance();
switch (ctxt.current()) {
case 'T':
{
ctxt.advance();
res = ST_MODE.Mode_PT;
break;
} // Case
case 'S':
{
ctxt.advance();
ctxt.accept('H');
res = ST_MODE.Mode_PSH;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1718)");
break;
} // Switch
break;
} // Case
case 'O':
{
ctxt.advance();
if (ctxt.lookAhead1('S')){
res = ST_MODE.Mode_OS;
} else {
ctxt.moveBack(1);
res = ST_MODE.Mode_NA;
} // If
break;
} // Case
case 'N':
{
ctxt.advance();
switch (ctxt.current()) {
case 'P':
{
ctxt.advance();
res = ST_MODE.Mode_NP;
break;
} // Case
case 'L':
{
ctxt.advance();
res = ST_MODE.Mode_NL;
break;
} // Case
case 'A':
{
ctxt.advance();
res = ST_MODE.Mode_NA;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1724)");
break;
} // Switch
break;
} // Case
case 'L':
{
ctxt.advance();
if (ctxt.lookAhead1('S')){
res = ST_MODE.Mode_LS;
} else {
ctxt.moveBack(1);
res = ST_MODE.Mode_NA;
} // If
break;
} // Case
case 'I':
{
ctxt.advance();
if (ctxt.lookAhead1('S')){
res = ST_MODE.Mode_IS;
} else {
ctxt.moveBack(1);
res = ST_MODE.Mode_NA;
} // If
break;
} // Case
case 'F':
{
ctxt.advance();
if (ctxt.lookAhead1('S')){
res = ST_MODE.Mode_FS;
} else {
ctxt.moveBack(1);
res = ST_MODE.Mode_NA;
} // If
break;
} // Case
default:
res = ST_MODE.Mode_NA;
break;
} // Switch
return res;
}

public static  string  Enum_ST_MODE_ToString (ST_MODE v)
{
switch (v) {
 case ST_MODE.Mode_NA: return "NA";
 case ST_MODE.Mode_IS: return "IS";
 case ST_MODE.Mode_NP: return "NP";
 case ST_MODE.Mode_SF: return "SF";
 case ST_MODE.Mode_SL: return "SL";
 case ST_MODE.Mode_SB: return "SB";
 case ST_MODE.Mode_SH: return "SH";
 case ST_MODE.Mode_FS: return "FS";
 case ST_MODE.Mode_UF: return "UF";
 case ST_MODE.Mode_SR: return "SR";
 case ST_MODE.Mode_OS: return "OS";
 case ST_MODE.Mode_TR: return "TR";
 case ST_MODE.Mode_PT: return "PT";
 case ST_MODE.Mode_NL: return "NL";
 case ST_MODE.Mode_SN: return "SN";
 case ST_MODE.Mode_RE: return "RE";
 case ST_MODE.Mode_LS: return "LS";
 case ST_MODE.Mode_PSH: return "PSH";
} return "";
}

public static ST_MODE StringTo_Enum_ST_MODE( string  str)
{
if (str.Equals("NA")){
  return ST_MODE.Mode_NA;
} // If
if (str.Equals("IS")){
  return ST_MODE.Mode_IS;
} // If
if (str.Equals("NP")){
  return ST_MODE.Mode_NP;
} // If
if (str.Equals("SF")){
  return ST_MODE.Mode_SF;
} // If
if (str.Equals("SL")){
  return ST_MODE.Mode_SL;
} // If
if (str.Equals("SB")){
  return ST_MODE.Mode_SB;
} // If
if (str.Equals("SH")){
  return ST_MODE.Mode_SH;
} // If
if (str.Equals("FS")){
  return ST_MODE.Mode_FS;
} // If
if (str.Equals("UF")){
  return ST_MODE.Mode_UF;
} // If
if (str.Equals("SR")){
  return ST_MODE.Mode_SR;
} // If
if (str.Equals("OS")){
  return ST_MODE.Mode_OS;
} // If
if (str.Equals("TR")){
  return ST_MODE.Mode_TR;
} // If
if (str.Equals("PT")){
  return ST_MODE.Mode_PT;
} // If
if (str.Equals("NL")){
  return ST_MODE.Mode_NL;
} // If
if (str.Equals("SN")){
  return ST_MODE.Mode_SN;
} // If
if (str.Equals("RE")){
  return ST_MODE.Mode_RE;
} // If
if (str.Equals("LS")){
  return ST_MODE.Mode_LS;
} // If
if (str.Equals("PSH")){
  return ST_MODE.Mode_PSH;
} // If
return ST_MODE.defaultST_MODE;
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static RulePriority lAcceptEnum_RulePriority (XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
  int indicator=0;
#pragma warning restore 0168, 0219
  RulePriority res = RulePriority.defaultRulePriority;
switch (ctxt.current()) {
case 'V':
{
ctxt.advance();
if (ctxt.lookAheadString("erification")){
res = RulePriority.aVerification;
} else {
ctxt.moveBack(1);
res = RulePriority.aProcessing;
} // If
break;
} // Case
case 'U':
{
ctxt.advance();
if (ctxt.lookAheadString("pdate")){
switch (ctxt.current()) {
case 'O':
{
ctxt.advance();
ctxt.accept2('U','T');
res = RulePriority.aUpdateOUT;
break;
} // Case
case 'I':
{
ctxt.advance();
ctxt.acceptString ("NTERNAL");
res = RulePriority.aUpdateINTERNAL;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1732)");
break;
} // Switch
} else {
ctxt.moveBack(1);
res = RulePriority.aProcessing;
} // If
break;
} // Case
case 'P':
{
ctxt.advance();
if (ctxt.lookAheadString("rocessing")){
res = RulePriority.aProcessing;
} else {
ctxt.moveBack(1);
res = RulePriority.aProcessing;
} // If
break;
} // Case
case 'C':
{
ctxt.advance();
if (ctxt.lookAheadString("leanUp")){
res = RulePriority.aCleanUp;
} else {
ctxt.moveBack(1);
res = RulePriority.aProcessing;
} // If
break;
} // Case
default:
res = RulePriority.aProcessing;
break;
} // Switch
return res;
}

public static  string  Enum_RulePriority_ToString (RulePriority v)
{
switch (v) {
 case RulePriority.aVerification: return "Verification";
 case RulePriority.aUpdateINTERNAL: return "UpdateINTERNAL";
 case RulePriority.aProcessing: return "Processing";
 case RulePriority.aUpdateOUT: return "UpdateOUT";
 case RulePriority.aCleanUp: return "CleanUp";
} return "";
}

public static RulePriority StringTo_Enum_RulePriority( string  str)
{
if (str.Equals("Verification")){
  return RulePriority.aVerification;
} // If
if (str.Equals("UpdateINTERNAL")){
  return RulePriority.aUpdateINTERNAL;
} // If
if (str.Equals("Processing")){
  return RulePriority.aProcessing;
} // If
if (str.Equals("UpdateOUT")){
  return RulePriority.aUpdateOUT;
} // If
if (str.Equals("CleanUp")){
  return RulePriority.aCleanUp;
} // If
return RulePriority.defaultRulePriority;
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static PrecisionEnum lAcceptEnum_PrecisionEnum (XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
  int indicator=0;
#pragma warning restore 0168, 0219
  PrecisionEnum res = PrecisionEnum.defaultPrecisionEnum;
switch (ctxt.current()) {
case 'I':
{
ctxt.advance();
if (ctxt.lookAheadString("ntegerPrecision")){
res = PrecisionEnum.aIntegerPrecision;
} else {
ctxt.moveBack(1);
res = PrecisionEnum.aIntegerPrecision;
} // If
break;
} // Case
case 'D':
{
ctxt.advance();
if (ctxt.lookAheadString("oublePrecision")){
res = PrecisionEnum.aDoublePrecision;
} else {
ctxt.moveBack(1);
res = PrecisionEnum.aIntegerPrecision;
} // If
break;
} // Case
default:
res = PrecisionEnum.aIntegerPrecision;
break;
} // Switch
return res;
}

public static  string  Enum_PrecisionEnum_ToString (PrecisionEnum v)
{
switch (v) {
 case PrecisionEnum.aIntegerPrecision: return "IntegerPrecision";
 case PrecisionEnum.aDoublePrecision: return "DoublePrecision";
} return "";
}

public static PrecisionEnum StringTo_Enum_PrecisionEnum( string  str)
{
if (str.Equals("IntegerPrecision")){
  return PrecisionEnum.aIntegerPrecision;
} // If
if (str.Equals("DoublePrecision")){
  return PrecisionEnum.aDoublePrecision;
} // If
return PrecisionEnum.defaultPrecisionEnum;
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static DBMessageType lAcceptEnum_DBMessageType (XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
  int indicator=0;
#pragma warning restore 0168, 0219
  DBMessageType res = DBMessageType.defaultDBMessageType;
switch (ctxt.current()) {
case 'E':
{
ctxt.advance();
if (ctxt.lookAhead3('U','R','O')){
switch (ctxt.current()) {
case 'R':
{
ctxt.advance();
ctxt.acceptString ("ADIO");
res = DBMessageType.aEURORADIO;
break;
} // Case
case 'L':
{
ctxt.advance();
ctxt.accept3('O','O','P');
res = DBMessageType.aEUROLOOP;
break;
} // Case
case 'B':
{
ctxt.advance();
ctxt.acceptString ("ALISE");
res = DBMessageType.aEUROBALISE;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1741)");
break;
} // Switch
} else {
ctxt.moveBack(1);
res = 0;
} // If
break;
} // Case
default:
res = 0;
break;
} // Switch
return res;
}

public static  string  Enum_DBMessageType_ToString (DBMessageType v)
{
switch (v) {
 case DBMessageType.aEUROBALISE: return "EUROBALISE";
 case DBMessageType.aEUROLOOP: return "EUROLOOP";
 case DBMessageType.aEURORADIO: return "EURORADIO";
} return "";
}

public static DBMessageType StringTo_Enum_DBMessageType( string  str)
{
if (str.Equals("EUROBALISE")){
  return DBMessageType.aEUROBALISE;
} // If
if (str.Equals("EUROLOOP")){
  return DBMessageType.aEUROLOOP;
} // If
if (str.Equals("EURORADIO")){
  return DBMessageType.aEURORADIO;
} // If
return DBMessageType.defaultDBMessageType;
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static bool lAcceptBoolean (XmlBContext ctxt)

{
#pragma warning disable 0168, 0219
  int indicator = 0;
#pragma warning restore 0168, 0219
  bool res = false;
switch (ctxt.current()) {
case 'y':
{
ctxt.advance();
switch (ctxt.current()) {
case 'e':
{
ctxt.advance();
if (ctxt.lookAhead1('s')){
res = true;
} else {
res = true;
} // If
break;
} // Case
default:
res = true;
break;
} // Switch
break;
} // Case
case 't':
{
ctxt.advance();
ctxt.accept3('r','u','e');
res = true;
break;
} // Case
case 'o':
{
ctxt.advance();
switch (ctxt.current()) {
case 'n':
{
ctxt.advance();
res = true;
break;
} // Case
case 'f':
{
ctxt.advance();
ctxt.accept('f');
res = false;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1748)");
break;
} // Switch
break;
} // Case
case 'n':
{
ctxt.advance();
switch (ctxt.current()) {
case 'o':
{
ctxt.advance();
res = false;
break;
} // Case
default:
res = false;
break;
} // Switch
break;
} // Case
case 'f':
{
ctxt.advance();
ctxt.acceptString ("alse");
res = false;
break;
} // Case
case 'Y':
{
ctxt.advance();
switch (ctxt.current()) {
case 'E':
{
ctxt.advance();
if (ctxt.lookAhead1('S')){
res = true;
} else {
res = true;
} // If
break;
} // Case
default:
res = true;
break;
} // Switch
break;
} // Case
case 'T':
{
ctxt.advance();
switch (ctxt.current()) {
case 'r':
{
ctxt.advance();
ctxt.accept2('u','e');
res = true;
break;
} // Case
case 'R':
{
ctxt.advance();
ctxt.accept2('U','E');
res = true;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1757)");
break;
} // Switch
break;
} // Case
case 'O':
{
ctxt.advance();
switch (ctxt.current()) {
case 'n':
{
ctxt.advance();
res = true;
break;
} // Case
case 'f':
{
ctxt.advance();
ctxt.accept('f');
res = false;
break;
} // Case
case 'N':
{
ctxt.advance();
res = true;
break;
} // Case
case 'F':
{
ctxt.advance();
ctxt.accept('F');
res = false;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1763)");
break;
} // Switch
break;
} // Case
case 'N':
{
ctxt.advance();
switch (ctxt.current()) {
case 'O':
{
ctxt.advance();
res = false;
break;
} // Case
default:
res = false;
break;
} // Switch
break;
} // Case
case 'F':
{
ctxt.advance();
switch (ctxt.current()) {
case 'a':
{
ctxt.advance();
ctxt.accept3('l','s','e');
res = false;
break;
} // Case
case 'A':
{
ctxt.advance();
ctxt.accept3('L','S','E');
res = false;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1769)");
break;
} // Switch
break;
} // Case
case '1':
{
ctxt.advance();
res = true;
break;
} // Case
case '0':
{
ctxt.advance();
res = false;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1772)");
break;
} // Switch
return res;
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static Namable lAccept_Poly_Namable (XmlBContext ctxt, 
                          string  endingTag)

  {
    char quoteChar;
    Namable res = null;
ctxt.skipWhiteSpace();
ctxt.acceptString ("xsi:type=");
quoteChar = ctxt.acceptQuote();
switch (ctxt.current()) {
case 'V':
{
ctxt.advance();
if (ctxt.lookAheadString("ariable")){
ctxt.accept(quoteChar);
res = lAccept_Variable(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
case 'T':
{
ctxt.advance();
switch (ctxt.current()) {
case 'r':
{
ctxt.advance();
if (ctxt.lookAheadString("anslation")){
switch (ctxt.current()) {
case 'D':
{
ctxt.advance();
if (ctxt.lookAheadString("ictionary")){
ctxt.accept(quoteChar);
res = lAccept_TranslationDictionary(ctxt, endingTag);
} else {
ctxt.accept(quoteChar);
res = lAccept_Translation(ctxt, endingTag);
} // If
break;
} // Case
default:
ctxt.accept(quoteChar);
res = lAccept_Translation(ctxt, endingTag);
break;
} // Switch
} else {
res = null;
} // If
break;
} // Case
case 'e':
{
ctxt.advance();
if (ctxt.lookAheadString("stCase")){
ctxt.accept(quoteChar);
res = lAccept_TestCase(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
default:
res = null;
break;
} // Switch
break;
} // Case
case 'S':
{
ctxt.advance();
switch (ctxt.current()) {
case 'u':
{
ctxt.advance();
if (ctxt.lookAhead2('b','S')){
switch (ctxt.current()) {
case 't':
{
ctxt.advance();
if (ctxt.lookAhead2('e','p')){
ctxt.accept(quoteChar);
res = lAccept_SubStep(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
case 'e':
{
ctxt.advance();
if (ctxt.lookAheadString("quence")){
ctxt.accept(quoteChar);
res = lAccept_SubSequence(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
default:
res = null;
break;
} // Switch
} else {
res = null;
} // If
break;
} // Case
case 't':
{
ctxt.advance();
switch (ctxt.current()) {
case 'r':
{
ctxt.advance();
if (ctxt.lookAheadString("ucture")){
switch (ctxt.current()) {
case 'P':
{
ctxt.advance();
if (ctxt.lookAheadString("rocedure")){
ctxt.accept(quoteChar);
res = lAccept_StructureProcedure(ctxt, endingTag);
} else {
ctxt.accept(quoteChar);
res = lAccept_Structure(ctxt, endingTag);
} // If
break;
} // Case
case 'E':
{
ctxt.advance();
if (ctxt.lookAheadString("lement")){
ctxt.accept(quoteChar);
res = lAccept_StructureElement(ctxt, endingTag);
} else {
ctxt.accept(quoteChar);
res = lAccept_Structure(ctxt, endingTag);
} // If
break;
} // Case
default:
ctxt.accept(quoteChar);
res = lAccept_Structure(ctxt, endingTag);
break;
} // Switch
} else {
res = null;
} // If
break;
} // Case
case 'e':
{
ctxt.advance();
if (ctxt.lookAhead1('p')){
ctxt.accept(quoteChar);
res = lAccept_Step(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
case 'a':
{
ctxt.advance();
if (ctxt.lookAhead2('t','e')){
switch (ctxt.current()) {
case 'M':
{
ctxt.advance();
if (ctxt.lookAheadString("achine")){
ctxt.accept(quoteChar);
res = lAccept_StateMachine(ctxt, endingTag);
} else {
ctxt.accept(quoteChar);
res = lAccept_State(ctxt, endingTag);
} // If
break;
} // Case
default:
ctxt.accept(quoteChar);
res = lAccept_State(ctxt, endingTag);
break;
} // Switch
} else {
res = null;
} // If
break;
} // Case
default:
res = null;
break;
} // Switch
break;
} // Case
case 'p':
{
ctxt.advance();
if (ctxt.lookAheadString("ecification")){
ctxt.accept(quoteChar);
res = lAccept_Specification(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
case 'o':
{
ctxt.advance();
if (ctxt.lookAheadString("urceText")){
ctxt.accept(quoteChar);
res = lAccept_SourceText(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
case 'h':
{
ctxt.advance();
if (ctxt.lookAheadString("ortcut")){
switch (ctxt.current()) {
case 'F':
{
ctxt.advance();
if (ctxt.lookAheadString("older")){
ctxt.accept(quoteChar);
res = lAccept_ShortcutFolder(ctxt, endingTag);
} else {
ctxt.accept(quoteChar);
res = lAccept_Shortcut(ctxt, endingTag);
} // If
break;
} // Case
case 'D':
{
ctxt.advance();
if (ctxt.lookAheadString("ictionary")){
ctxt.accept(quoteChar);
res = lAccept_ShortcutDictionary(ctxt, endingTag);
} else {
ctxt.accept(quoteChar);
res = lAccept_Shortcut(ctxt, endingTag);
} // If
break;
} // Case
default:
ctxt.accept(quoteChar);
res = lAccept_Shortcut(ctxt, endingTag);
break;
} // Switch
} else {
res = null;
} // If
break;
} // Case
default:
res = null;
break;
} // Switch
break;
} // Case
case 'R':
{
ctxt.advance();
switch (ctxt.current()) {
case 'u':
{
ctxt.advance();
if (ctxt.lookAhead2('l','e')){
switch (ctxt.current()) {
case 'D':
{
ctxt.advance();
if (ctxt.lookAheadString("isabling")){
ctxt.accept(quoteChar);
res = lAccept_RuleDisabling(ctxt, endingTag);
} else {
ctxt.accept(quoteChar);
res = lAccept_Rule(ctxt, endingTag);
} // If
break;
} // Case
case 'C':
{
ctxt.advance();
if (ctxt.lookAheadString("ondition")){
ctxt.accept(quoteChar);
res = lAccept_RuleCondition(ctxt, endingTag);
} else {
ctxt.accept(quoteChar);
res = lAccept_Rule(ctxt, endingTag);
} // If
break;
} // Case
default:
ctxt.accept(quoteChar);
res = lAccept_Rule(ctxt, endingTag);
break;
} // Switch
} else {
res = null;
} // If
break;
} // Case
case 'a':
{
ctxt.advance();
if (ctxt.lookAhead3('n','g','e')){
ctxt.accept(quoteChar);
res = lAccept_Range(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
default:
res = null;
break;
} // Switch
break;
} // Case
case 'P':
{
ctxt.advance();
switch (ctxt.current()) {
case 'r':
{
ctxt.advance();
if (ctxt.lookAheadString("ocedure")){
ctxt.accept(quoteChar);
res = lAccept_Procedure(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
case 'a':
{
ctxt.advance();
if (ctxt.lookAhead2('r','a')){
switch (ctxt.current()) {
case 'm':
{
ctxt.advance();
if (ctxt.lookAheadString("eter")){
ctxt.accept(quoteChar);
res = lAccept_Parameter(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
case 'g':
{
ctxt.advance();
if (ctxt.lookAheadString("raph")){
ctxt.accept(quoteChar);
res = lAccept_Paragraph(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
default:
res = null;
break;
} // Switch
} else {
res = null;
} // If
break;
} // Case
default:
res = null;
break;
} // Switch
break;
} // Case
case 'N':
{
ctxt.advance();
if (ctxt.lookAheadString("ameSpace")){
ctxt.accept(quoteChar);
res = lAccept_NameSpace(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
case 'F':
{
ctxt.advance();
switch (ctxt.current()) {
case 'u':
{
ctxt.advance();
if (ctxt.lookAheadString("nction")){
ctxt.accept(quoteChar);
res = lAccept_Function(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
case 'r':
{
ctxt.advance();
if (ctxt.lookAhead3('a','m','e')){
ctxt.accept(quoteChar);
res = lAccept_Frame(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
case 'o':
{
ctxt.advance();
if (ctxt.lookAheadString("lder")){
ctxt.accept(quoteChar);
res = lAccept_Folder(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
default:
res = null;
break;
} // Switch
break;
} // Case
case 'E':
{
ctxt.advance();
switch (ctxt.current()) {
case 'x':
{
ctxt.advance();
if (ctxt.lookAheadString("pectation")){
ctxt.accept(quoteChar);
res = lAccept_Expectation(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
case 'n':
{
ctxt.advance();
if (ctxt.lookAhead2('u','m')){
switch (ctxt.current()) {
case 'V':
{
ctxt.advance();
if (ctxt.lookAheadString("alue")){
ctxt.accept(quoteChar);
res = lAccept_EnumValue(ctxt, endingTag);
} else {
ctxt.accept(quoteChar);
res = lAccept_Enum(ctxt, endingTag);
} // If
break;
} // Case
default:
ctxt.accept(quoteChar);
res = lAccept_Enum(ctxt, endingTag);
break;
} // Switch
} else {
res = null;
} // If
break;
} // Case
default:
res = null;
break;
} // Switch
break;
} // Case
case 'D':
{
ctxt.advance();
if (ctxt.lookAhead1('B')){
switch (ctxt.current()) {
case 'P':
{
ctxt.advance();
if (ctxt.lookAheadString("acket")){
ctxt.accept(quoteChar);
res = lAccept_DBPacket(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
case 'M':
{
ctxt.advance();
if (ctxt.lookAheadString("essage")){
ctxt.accept(quoteChar);
res = lAccept_DBMessage(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
case 'F':
{
ctxt.advance();
if (ctxt.lookAheadString("ield")){
ctxt.accept(quoteChar);
res = lAccept_DBField(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
default:
res = null;
break;
} // Switch
} else {
res = null;
} // If
break;
} // Case
case 'C':
{
ctxt.advance();
switch (ctxt.current()) {
case 'o':
{
ctxt.advance();
if (ctxt.lookAheadString("llection")){
ctxt.accept(quoteChar);
res = lAccept_Collection(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
case 'h':
{
ctxt.advance();
if (ctxt.lookAheadString("apter")){
ctxt.accept(quoteChar);
res = lAccept_Chapter(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
case 'a':
{
ctxt.advance();
if (ctxt.lookAhead2('s','e')){
ctxt.accept(quoteChar);
res = lAccept_Case(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
default:
res = null;
break;
} // Switch
break;
} // Case
default:
res = null;
break;
} // Switch
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static ReferencesParagraph lAccept_Poly_ReferencesParagraph (XmlBContext ctxt, 
                          string  endingTag)

  {
    char quoteChar;
    ReferencesParagraph res = null;
ctxt.skipWhiteSpace();
ctxt.acceptString ("xsi:type=");
quoteChar = ctxt.acceptQuote();
switch (ctxt.current()) {
case 'V':
{
ctxt.advance();
if (ctxt.lookAheadString("ariable")){
ctxt.accept(quoteChar);
res = lAccept_Variable(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
case 'T':
{
ctxt.advance();
if (ctxt.lookAheadString("estCase")){
ctxt.accept(quoteChar);
res = lAccept_TestCase(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
case 'S':
{
ctxt.advance();
if (ctxt.lookAhead1('t')){
switch (ctxt.current()) {
case 'r':
{
ctxt.advance();
if (ctxt.lookAheadString("ucture")){
switch (ctxt.current()) {
case 'P':
{
ctxt.advance();
if (ctxt.lookAheadString("rocedure")){
ctxt.accept(quoteChar);
res = lAccept_StructureProcedure(ctxt, endingTag);
} else {
ctxt.accept(quoteChar);
res = lAccept_Structure(ctxt, endingTag);
} // If
break;
} // Case
case 'E':
{
ctxt.advance();
if (ctxt.lookAheadString("lement")){
ctxt.accept(quoteChar);
res = lAccept_StructureElement(ctxt, endingTag);
} else {
ctxt.accept(quoteChar);
res = lAccept_Structure(ctxt, endingTag);
} // If
break;
} // Case
default:
ctxt.accept(quoteChar);
res = lAccept_Structure(ctxt, endingTag);
break;
} // Switch
} else {
res = null;
} // If
break;
} // Case
case 'a':
{
ctxt.advance();
if (ctxt.lookAhead2('t','e')){
switch (ctxt.current()) {
case 'M':
{
ctxt.advance();
if (ctxt.lookAheadString("achine")){
ctxt.accept(quoteChar);
res = lAccept_StateMachine(ctxt, endingTag);
} else {
ctxt.accept(quoteChar);
res = lAccept_State(ctxt, endingTag);
} // If
break;
} // Case
default:
ctxt.accept(quoteChar);
res = lAccept_State(ctxt, endingTag);
break;
} // Switch
} else {
res = null;
} // If
break;
} // Case
default:
res = null;
break;
} // Switch
} else {
res = null;
} // If
break;
} // Case
case 'R':
{
ctxt.advance();
switch (ctxt.current()) {
case 'u':
{
ctxt.advance();
if (ctxt.lookAhead2('l','e')){
switch (ctxt.current()) {
case 'D':
{
ctxt.advance();
if (ctxt.lookAheadString("isabling")){
ctxt.accept(quoteChar);
res = lAccept_RuleDisabling(ctxt, endingTag);
} else {
ctxt.accept(quoteChar);
res = lAccept_Rule(ctxt, endingTag);
} // If
break;
} // Case
case 'C':
{
ctxt.advance();
if (ctxt.lookAheadString("ondition")){
ctxt.accept(quoteChar);
res = lAccept_RuleCondition(ctxt, endingTag);
} else {
ctxt.accept(quoteChar);
res = lAccept_Rule(ctxt, endingTag);
} // If
break;
} // Case
default:
ctxt.accept(quoteChar);
res = lAccept_Rule(ctxt, endingTag);
break;
} // Switch
} else {
res = null;
} // If
break;
} // Case
case 'a':
{
ctxt.advance();
if (ctxt.lookAhead3('n','g','e')){
ctxt.accept(quoteChar);
res = lAccept_Range(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
default:
res = null;
break;
} // Switch
break;
} // Case
case 'P':
{
ctxt.advance();
switch (ctxt.current()) {
case 'r':
{
ctxt.advance();
if (ctxt.lookAheadString("ocedure")){
ctxt.accept(quoteChar);
res = lAccept_Procedure(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
case 'a':
{
ctxt.advance();
if (ctxt.lookAheadString("ragraph")){
ctxt.accept(quoteChar);
res = lAccept_Paragraph(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
default:
res = null;
break;
} // Switch
break;
} // Case
case 'F':
{
ctxt.advance();
if (ctxt.lookAheadString("unction")){
ctxt.accept(quoteChar);
res = lAccept_Function(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
case 'E':
{
ctxt.advance();
if (ctxt.lookAhead3('n','u','m')){
ctxt.accept(quoteChar);
res = lAccept_Enum(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
case 'C':
{
ctxt.advance();
if (ctxt.lookAheadString("ollection")){
ctxt.accept(quoteChar);
res = lAccept_Collection(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
default:
res = null;
break;
} // Switch
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static ReqRelated lAccept_Poly_ReqRelated (XmlBContext ctxt, 
                          string  endingTag)

  {
    char quoteChar;
    ReqRelated res = null;
ctxt.skipWhiteSpace();
ctxt.acceptString ("xsi:type=");
quoteChar = ctxt.acceptQuote();
switch (ctxt.current()) {
case 'V':
{
ctxt.advance();
if (ctxt.lookAheadString("ariable")){
ctxt.accept(quoteChar);
res = lAccept_Variable(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
case 'T':
{
ctxt.advance();
if (ctxt.lookAheadString("estCase")){
ctxt.accept(quoteChar);
res = lAccept_TestCase(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
case 'S':
{
ctxt.advance();
if (ctxt.lookAhead1('t')){
switch (ctxt.current()) {
case 'r':
{
ctxt.advance();
if (ctxt.lookAheadString("ucture")){
switch (ctxt.current()) {
case 'P':
{
ctxt.advance();
if (ctxt.lookAheadString("rocedure")){
ctxt.accept(quoteChar);
res = lAccept_StructureProcedure(ctxt, endingTag);
} else {
ctxt.accept(quoteChar);
res = lAccept_Structure(ctxt, endingTag);
} // If
break;
} // Case
case 'E':
{
ctxt.advance();
if (ctxt.lookAheadString("lement")){
ctxt.accept(quoteChar);
res = lAccept_StructureElement(ctxt, endingTag);
} else {
ctxt.accept(quoteChar);
res = lAccept_Structure(ctxt, endingTag);
} // If
break;
} // Case
default:
ctxt.accept(quoteChar);
res = lAccept_Structure(ctxt, endingTag);
break;
} // Switch
} else {
res = null;
} // If
break;
} // Case
case 'a':
{
ctxt.advance();
if (ctxt.lookAhead2('t','e')){
switch (ctxt.current()) {
case 'M':
{
ctxt.advance();
if (ctxt.lookAheadString("achine")){
ctxt.accept(quoteChar);
res = lAccept_StateMachine(ctxt, endingTag);
} else {
ctxt.accept(quoteChar);
res = lAccept_State(ctxt, endingTag);
} // If
break;
} // Case
default:
ctxt.accept(quoteChar);
res = lAccept_State(ctxt, endingTag);
break;
} // Switch
} else {
res = null;
} // If
break;
} // Case
default:
res = null;
break;
} // Switch
} else {
res = null;
} // If
break;
} // Case
case 'R':
{
ctxt.advance();
switch (ctxt.current()) {
case 'u':
{
ctxt.advance();
if (ctxt.lookAhead2('l','e')){
switch (ctxt.current()) {
case 'D':
{
ctxt.advance();
if (ctxt.lookAheadString("isabling")){
ctxt.accept(quoteChar);
res = lAccept_RuleDisabling(ctxt, endingTag);
} else {
ctxt.accept(quoteChar);
res = lAccept_Rule(ctxt, endingTag);
} // If
break;
} // Case
case 'C':
{
ctxt.advance();
if (ctxt.lookAheadString("ondition")){
ctxt.accept(quoteChar);
res = lAccept_RuleCondition(ctxt, endingTag);
} else {
ctxt.accept(quoteChar);
res = lAccept_Rule(ctxt, endingTag);
} // If
break;
} // Case
default:
ctxt.accept(quoteChar);
res = lAccept_Rule(ctxt, endingTag);
break;
} // Switch
} else {
res = null;
} // If
break;
} // Case
case 'a':
{
ctxt.advance();
if (ctxt.lookAhead3('n','g','e')){
ctxt.accept(quoteChar);
res = lAccept_Range(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
default:
res = null;
break;
} // Switch
break;
} // Case
case 'P':
{
ctxt.advance();
if (ctxt.lookAheadString("rocedure")){
ctxt.accept(quoteChar);
res = lAccept_Procedure(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
case 'F':
{
ctxt.advance();
if (ctxt.lookAheadString("unction")){
ctxt.accept(quoteChar);
res = lAccept_Function(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
case 'E':
{
ctxt.advance();
if (ctxt.lookAhead3('n','u','m')){
ctxt.accept(quoteChar);
res = lAccept_Enum(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
case 'C':
{
ctxt.advance();
if (ctxt.lookAheadString("ollection")){
ctxt.accept(quoteChar);
res = lAccept_Collection(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
default:
res = null;
break;
} // Switch
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static Dictionary lAccept_Dictionary (XmlBContext ctxt, 
                          string  endingTag)

  {
  Dictionary res = aFactory.createDictionary();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static RuleDisabling lAccept_RuleDisabling (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</RuleDisabling>";
  RuleDisabling res = aFactory.createRuleDisabling();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static NameSpace lAccept_NameSpace (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</NameSpace>";
  NameSpace res = aFactory.createNameSpace();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static ReqRef lAccept_ReqRef (XmlBContext ctxt, 
                          string  endingTag)

  {
  ReqRef res = aFactory.createReqRef();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static Type lAccept_Poly_Type (XmlBContext ctxt, 
                          string  endingTag)

  {
    char quoteChar;
    Type res = null;
ctxt.skipWhiteSpace();
ctxt.acceptString ("xsi:type=");
quoteChar = ctxt.acceptQuote();
switch (ctxt.current()) {
case 'S':
{
ctxt.advance();
if (ctxt.lookAhead1('t')){
switch (ctxt.current()) {
case 'r':
{
ctxt.advance();
if (ctxt.lookAheadString("ucture")){
ctxt.accept(quoteChar);
res = lAccept_Structure(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
case 'a':
{
ctxt.advance();
if (ctxt.lookAheadString("teMachine")){
ctxt.accept(quoteChar);
res = lAccept_StateMachine(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
default:
res = null;
break;
} // Switch
} else {
res = null;
} // If
break;
} // Case
case 'R':
{
ctxt.advance();
if (ctxt.lookAheadString("ange")){
ctxt.accept(quoteChar);
res = lAccept_Range(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
case 'F':
{
ctxt.advance();
if (ctxt.lookAheadString("unction")){
ctxt.accept(quoteChar);
res = lAccept_Function(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
case 'E':
{
ctxt.advance();
if (ctxt.lookAhead3('n','u','m')){
ctxt.accept(quoteChar);
res = lAccept_Enum(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
case 'C':
{
ctxt.advance();
if (ctxt.lookAheadString("ollection")){
ctxt.accept(quoteChar);
res = lAccept_Collection(ctxt, endingTag);
} else {
res = null;
} // If
break;
} // Case
default:
res = null;
break;
} // Switch
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static Enum lAccept_Enum (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</Enum>";
  Enum res = aFactory.createEnum();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static EnumValue lAccept_EnumValue (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</EnumValue>";
  EnumValue res = aFactory.createEnumValue();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static Range lAccept_Range (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</Range>";
  Range res = aFactory.createRange();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static Structure lAccept_Structure (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</Structure>";
  Structure res = aFactory.createStructure();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static StructureElement lAccept_StructureElement (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</StructureElement>";
  StructureElement res = aFactory.createStructureElement();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static StructureProcedure lAccept_StructureProcedure (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</StructureProcedure>";
  StructureProcedure res = aFactory.createStructureProcedure();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static Collection lAccept_Collection (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</Collection>";
  Collection res = aFactory.createCollection();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static Function lAccept_Function (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</Function>";
  Function res = aFactory.createFunction();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static Parameter lAccept_Parameter (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</Parameter>";
  Parameter res = aFactory.createParameter();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static Case lAccept_Case (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</Case>";
  Case res = aFactory.createCase();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static Procedure lAccept_Procedure (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</Procedure>";
  Procedure res = aFactory.createProcedure();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static StateMachine lAccept_StateMachine (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</StateMachine>";
  StateMachine res = aFactory.createStateMachine();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static State lAccept_State (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</State>";
  State res = aFactory.createState();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static Variable lAccept_Variable (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</Variable>";
  Variable res = aFactory.createVariable();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static Rule lAccept_Rule (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</Rule>";
  Rule res = aFactory.createRule();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static RuleCondition lAccept_RuleCondition (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</RuleCondition>";
  RuleCondition res = aFactory.createRuleCondition();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static PreCondition lAccept_PreCondition (XmlBContext ctxt, 
                          string  endingTag)

  {
  PreCondition res = aFactory.createPreCondition();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static Action lAccept_Action (XmlBContext ctxt, 
                          string  endingTag)

  {
  Action res = aFactory.createAction();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static Frame lAccept_Frame (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</Frame>";
  Frame res = aFactory.createFrame();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static SubSequence lAccept_SubSequence (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</SubSequence>";
  SubSequence res = aFactory.createSubSequence();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static TestCase lAccept_TestCase (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</TestCase>";
  TestCase res = aFactory.createTestCase();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static Step lAccept_Step (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</Step>";
  Step res = aFactory.createStep();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static SubStep lAccept_SubStep (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</SubStep>";
  SubStep res = aFactory.createSubStep();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static Expectation lAccept_Expectation (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</Expectation>";
  Expectation res = aFactory.createExpectation();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static DBMessage lAccept_DBMessage (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</DBMessage>";
  DBMessage res = aFactory.createDBMessage();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static DBPacket lAccept_DBPacket (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</DBPacket>";
  DBPacket res = aFactory.createDBPacket();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static DBField lAccept_DBField (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</DBField>";
  DBField res = aFactory.createDBField();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static TranslationDictionary lAccept_TranslationDictionary (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</TranslationDictionary>";
  TranslationDictionary res = aFactory.createTranslationDictionary();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static Folder lAccept_Folder (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</Folder>";
  Folder res = aFactory.createFolder();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static Translation lAccept_Translation (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</Translation>";
  Translation res = aFactory.createTranslation();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static SourceText lAccept_SourceText (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</SourceText>";
  SourceText res = aFactory.createSourceText();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static ShortcutDictionary lAccept_ShortcutDictionary (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</ShortcutDictionary>";
  ShortcutDictionary res = aFactory.createShortcutDictionary();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static ShortcutFolder lAccept_ShortcutFolder (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</ShortcutFolder>";
  ShortcutFolder res = aFactory.createShortcutFolder();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static Shortcut lAccept_Shortcut (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</Shortcut>";
  Shortcut res = aFactory.createShortcut();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static Specification lAccept_Specification (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</Specification>";
  Specification res = aFactory.createSpecification();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static Chapter lAccept_Chapter (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</Chapter>";
  Chapter res = aFactory.createChapter();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static Paragraph lAccept_Paragraph (XmlBContext ctxt, 
                          string  endingTag)

  {
if (endingTag == null) endingTag = "</Paragraph>";
  Paragraph res = aFactory.createParagraph();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static Message lAccept_Message (XmlBContext ctxt, 
                          string  endingTag)

  {
  Message res = aFactory.createMessage();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static MsgVariable lAccept_MsgVariable (XmlBContext ctxt, 
                          string  endingTag)

  {
  MsgVariable res = aFactory.createMsgVariable();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static TypeSpec lAccept_TypeSpec (XmlBContext ctxt, 
                          string  endingTag)

  {
  TypeSpec res = aFactory.createTypeSpec();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static Values lAccept_Values (XmlBContext ctxt, 
                          string  endingTag)

  {
  Values res = aFactory.createValues();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static special_or_reserved_values lAccept_special_or_reserved_values (XmlBContext ctxt, 
                          string  endingTag)

  {
  special_or_reserved_values res = aFactory.createspecial_or_reserved_values();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static special_or_reserved_value lAccept_special_or_reserved_value (XmlBContext ctxt, 
                          string  endingTag)

  {
  special_or_reserved_value res = aFactory.createspecial_or_reserved_value();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static mask lAccept_mask (XmlBContext ctxt, 
                          string  endingTag)

  {
  mask res = aFactory.createmask();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static match lAccept_match (XmlBContext ctxt, 
                          string  endingTag)

  {
  match res = aFactory.creatematch();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static meaning lAccept_meaning (XmlBContext ctxt, 
                          string  endingTag)

  {
  meaning res = aFactory.createmeaning();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static match_range lAccept_match_range (XmlBContext ctxt, 
                          string  endingTag)

  {
  match_range res = aFactory.creatematch_range();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static resolution_formula lAccept_resolution_formula (XmlBContext ctxt, 
                          string  endingTag)

  {
  resolution_formula res = aFactory.createresolution_formula();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static value lAccept_value (XmlBContext ctxt, 
                          string  endingTag)

  {
  value res = aFactory.createvalue();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static char_value lAccept_char_value (XmlBContext ctxt, 
                          string  endingTag)

  {
  char_value res = aFactory.createchar_value();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static ParagraphRevision lAccept_ParagraphRevision (XmlBContext ctxt, 
                          string  endingTag)

  {
  ParagraphRevision res = aFactory.createParagraphRevision();
  res.parse(ctxt, endingTag);
  return res;
  }

/// <summary>Utility function which parse an entity character 
/// as defined in the XMLBooster configuration.</summary>
/// <param name="ctxt">the context from which the data must be parsed</param>
static char lAcceptPcDataChr(XmlBContext ctxt)

{
    char c = (char)0;
    int indicator=0;
switch (ctxt.current()) {
case 'q':
{
ctxt.advance();
ctxt.acceptString ("uot;");
indicator = 1868;
break;
} // Case
case 'n':
{
ctxt.advance();
ctxt.acceptString ("bsp;");
indicator = 1867;
break;
} // Case
case 'l':
{
ctxt.advance();
ctxt.accept2('t',';');
indicator = 1865;
break;
} // Case
case 'g':
{
ctxt.advance();
ctxt.accept2('t',';');
indicator = 1866;
break;
} // Case
case 'a':
{
ctxt.advance();
switch (ctxt.current()) {
case 'p':
{
ctxt.advance();
ctxt.accept3('o','s',';');
indicator = 1869;
break;
} // Case
case 'm':
{
ctxt.advance();
ctxt.accept2('p',';');
indicator = 1864;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1877)");
break;
} // Switch
break;
} // Case
case '#':
{
ctxt.advance();
ctxt.accept('x');
indicator = 1870;
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1879)");
break;
} // Switch
switch (indicator) {
case 1864: {
c = XMLB_AMPERSAND;
break;
} // End of dispatch label
case 1865: {
c = XMLB_LESS;
break;
} // End of dispatch label
case 1866: {
c = XMLB_GREATER;
break;
} // End of dispatch label
case 1867: {
c = XMLB_NBSP;
break;
} // End of dispatch label
case 1868: {
c = XMLB_QUOT;
break;
} // End of dispatch label
case 1869: {
c = XMLB_APOS;
break;
} // End of dispatch label
case 1870: {
c = (char) ctxt.acceptHexa();
ctxt.accept(';');
break;
} // End of dispatch label
} // Dispatch
return c;
}
/// <summary>Utility function which parse a PCDATA component 
/// from a context. It takes the entities defined in the
/// in the configuration into account.</summary>
/// <param name="ctxt">the context from which the data must be 
///        parsed</param>
/// <param name="maxLen">the maximal number of characters that 
///        can be read.</param>
/// <param name="closingCh">a character on which parsing must stop
///        in addition to the standard &lt; character.</param>
/// <param name="wsMode">indicates PRESERVE (default), REPLACE or COLLAPSE.</param>
public static  string  lAcceptPcData(XmlBContext ctxt, 
                                   int maxLen,
                                   char closingCh,
                                   int wsMode)

 {
    char ch;
    char lastch = '.';
    System.Text.StringBuilder buff;
     string  res;

  buff = new System.Text.StringBuilder();
  bool go_on = true;
  while (go_on) 
{
  go_on = false;
  while ((ctxt.current() != '<') && (ctxt.current() != closingCh)) // while 1 
{
    ch = ctxt.current();
ctxt.advance();
if (ch == '&'){
ch = lAcceptPcDataChr(ctxt);
} else {
if (wsMode >= WS_REPLACE){
if (ch == '\t' || ch == '\n' || ch == '\r'){
ch = ' ';
} // If
if (wsMode == WS_COLLAPSE){
if ((ch == ' ') && ((lastch == ' ') || (buff.Length == 0))){
ch = (char)0;
} else {
lastch = ch;
} // If
} else {
lastch = ch;
} // If
} // If
} // If
if (ch != '\0'){
buff.Append (ch);
} // If
}
// end while
if (ctxt.current() == '<'){
if (ctxt.lookAheadString("<![CDATA[")){
     string  cdata = ctxt.acceptUntil("]]>", true);
    buff.Append (cdata);
    go_on = true;
} else {
if (ctxt.lookAhead2('<','?')){
ctxt.skipTill ('?');
ctxt.accept2('?','>');
go_on = true;
} else {
} // If
} // If
} // If
}
if (wsMode == WS_COLLAPSE && lastch == ' ' && buff. Length > 0){
res = buff.ToString (0, buff.Length -1);
} else {
res = buff.ToString();
} // If
if ((maxLen > 0) && (res.Length > maxLen)){
ctxt.recoverableFail ("Maximum length exceeded");
} // If
return res;
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
  private static bool requiresEscape (char a)
  {
    switch (a)
    {
      case XMLB_AMPERSAND:
      case XMLB_LESS:
      case XMLB_GREATER:
      case XMLB_QUOT:
      case XMLB_APOS:
        return true;
      default: break;
    }
    return false;
  }
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
  private static bool requiresEscape ( string  a)
  {
    for (int i=0; i < a.Length; i++)
    {
      if (requiresEscape(a[i]))
        return true;
    }
    return false	;
  }
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
  public static void unParsePcData (TextWriter pw,  string  a)
    {
      bool escaped = false;
      
      if (a == null)
      {
          return;
      }
      escaped = requiresEscape (a);
      if (! escaped)
        pw.Write (a);
      else
      {
        char c;
        for (int i = 0; i < a.Length; i++)
        {
          c = a[i];
          switch (c)
            {
              case XMLB_AMPERSAND:
                  pw.Write("&amp;"); 
                  break;
              case XMLB_LESS:
                  pw.Write("&lt;"); 
                  break;
              case XMLB_GREATER:
                  pw.Write("&gt;"); 
                  break;
              case XMLB_QUOT:
                  pw.Write("&quot;"); 
                  break;
              case XMLB_APOS:
                  pw.Write("&apos;"); 
                  break;
               default: 
                   pw.Write(c);
                   break;
            }
        }
      }
    }
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
  public static void unParsePcData (TextWriter pw, bool flag)
    {
      if (flag)
        pw.Write ("TRUE");
       else
        pw.Write("FALSE");
    }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
  public static void unParsePcData (TextWriter pw, object obj)
    {
      if (obj != null)
        unParsePcData (pw, obj.ToString());
    }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
  public static void unParsePcData (TextWriter pw, int val)
    {
      pw.Write (val);
    }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
  public static void unParsePcData (TextWriter pw, long val)
    {
      pw.Write (val);
    }

/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
  public static void unParsePcData (TextWriter pw, double val)
    {
      XmlBConverter conv;
      conv = getConverter();
      if(conv != null)
        pw.Write(conv.doubleToString(val));
       else
        pw.Write (val);
    }



private static Factory aFactory;
/// <summary>Sets the factory to introduce an indirection level
/// so that the user can externally define derived classes
/// to be used in place of the XMLBooster-generated 
/// classes.</summary>
public static void setFactory (Factory f) { aFactory = f; }

/// <returns>the currently active factory.</returns>
public static Factory getFactory () { return aFactory; }
static private acceptor theOne = null;
static public acceptor getUnique()
{
  if (theOne == null) { theOne = new acceptor(); }
  return theOne;
}

static public void setUnique(acceptor acc)
{
  theOne = acc;
}


/// <summary>Top level function to parse an Dictionary from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static Dictionary acceptDictionary(XmlBContext ctxt)

  {
Dictionary res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<Dictionary");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_Dictionary(ctxt, "</Dictionary>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an RuleDisabling from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static RuleDisabling acceptRuleDisabling(XmlBContext ctxt)

  {
RuleDisabling res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<RuleDisabling");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_RuleDisabling(ctxt, "</RuleDisabling>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an NameSpace from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static NameSpace acceptNameSpace(XmlBContext ctxt)

  {
NameSpace res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<NameSpace");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_NameSpace(ctxt, "</NameSpace>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an ReqRef from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static ReqRef acceptReqRef(XmlBContext ctxt)

  {
ReqRef res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<ReqRef");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_ReqRef(ctxt, "</ReqRef>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an Enum from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static Enum acceptEnum(XmlBContext ctxt)

  {
Enum res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<Enum");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_Enum(ctxt, "</Enum>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an EnumValue from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static EnumValue acceptEnumValue(XmlBContext ctxt)

  {
EnumValue res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<EnumValue");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_EnumValue(ctxt, "</EnumValue>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an Range from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static Range acceptRange(XmlBContext ctxt)

  {
Range res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<Range");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_Range(ctxt, "</Range>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an Structure from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static Structure acceptStructure(XmlBContext ctxt)

  {
Structure res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<Structure");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_Structure(ctxt, "</Structure>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an StructureElement from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static StructureElement acceptStructureElement(XmlBContext ctxt)

  {
StructureElement res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<StructureElement");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_StructureElement(ctxt, "</StructureElement>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an StructureProcedure from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static StructureProcedure acceptStructureProcedure(XmlBContext ctxt)

  {
StructureProcedure res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<StructureProcedure");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_StructureProcedure(ctxt, "</StructureProcedure>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an Collection from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static Collection acceptCollection(XmlBContext ctxt)

  {
Collection res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<Collection");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_Collection(ctxt, "</Collection>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an Function from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static Function acceptFunction(XmlBContext ctxt)

  {
Function res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<Function");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_Function(ctxt, "</Function>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an Parameter from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static Parameter acceptParameter(XmlBContext ctxt)

  {
Parameter res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<Parameter");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_Parameter(ctxt, "</Parameter>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an Case from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static Case acceptCase(XmlBContext ctxt)

  {
Case res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<Case");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_Case(ctxt, "</Case>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an Procedure from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static Procedure acceptProcedure(XmlBContext ctxt)

  {
Procedure res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<Procedure");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_Procedure(ctxt, "</Procedure>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an StateMachine from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static StateMachine acceptStateMachine(XmlBContext ctxt)

  {
StateMachine res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<StateMachine");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_StateMachine(ctxt, "</StateMachine>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an State from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static State acceptState(XmlBContext ctxt)

  {
State res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<State");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_State(ctxt, "</State>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an Variable from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static Variable acceptVariable(XmlBContext ctxt)

  {
Variable res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<Variable");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_Variable(ctxt, "</Variable>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an Rule from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static Rule acceptRule(XmlBContext ctxt)

  {
Rule res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<Rule");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_Rule(ctxt, "</Rule>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an RuleCondition from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static RuleCondition acceptRuleCondition(XmlBContext ctxt)

  {
RuleCondition res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<RuleCondition");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_RuleCondition(ctxt, "</RuleCondition>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an PreCondition from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static PreCondition acceptPreCondition(XmlBContext ctxt)

  {
PreCondition res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<PreCondition");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_PreCondition(ctxt, "</PreCondition>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an Action from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static Action acceptAction(XmlBContext ctxt)

  {
Action res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<Action");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_Action(ctxt, "</Action>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an Frame from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static Frame acceptFrame(XmlBContext ctxt)

  {
Frame res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<Frame");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_Frame(ctxt, "</Frame>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an SubSequence from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static SubSequence acceptSubSequence(XmlBContext ctxt)

  {
SubSequence res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<SubSequence");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_SubSequence(ctxt, "</SubSequence>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an TestCase from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static TestCase acceptTestCase(XmlBContext ctxt)

  {
TestCase res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<TestCase");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_TestCase(ctxt, "</TestCase>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an Step from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static Step acceptStep(XmlBContext ctxt)

  {
Step res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<Step");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_Step(ctxt, "</Step>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an SubStep from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static SubStep acceptSubStep(XmlBContext ctxt)

  {
SubStep res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<SubStep");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_SubStep(ctxt, "</SubStep>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an Expectation from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static Expectation acceptExpectation(XmlBContext ctxt)

  {
Expectation res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<Expectation");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_Expectation(ctxt, "</Expectation>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an DBMessage from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static DBMessage acceptDBMessage(XmlBContext ctxt)

  {
DBMessage res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<DBMessage");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_DBMessage(ctxt, "</DBMessage>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an DBPacket from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static DBPacket acceptDBPacket(XmlBContext ctxt)

  {
DBPacket res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<DBPacket");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_DBPacket(ctxt, "</DBPacket>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an DBField from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static DBField acceptDBField(XmlBContext ctxt)

  {
DBField res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<DBField");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_DBField(ctxt, "</DBField>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an TranslationDictionary from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static TranslationDictionary acceptTranslationDictionary(XmlBContext ctxt)

  {
TranslationDictionary res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<TranslationDictionary");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_TranslationDictionary(ctxt, "</TranslationDictionary>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an Folder from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static Folder acceptFolder(XmlBContext ctxt)

  {
Folder res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<Folder");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_Folder(ctxt, "</Folder>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an Translation from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static Translation acceptTranslation(XmlBContext ctxt)

  {
Translation res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<Translation");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_Translation(ctxt, "</Translation>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an SourceText from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static SourceText acceptSourceText(XmlBContext ctxt)

  {
SourceText res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<SourceText");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_SourceText(ctxt, "</SourceText>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an ShortcutDictionary from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static ShortcutDictionary acceptShortcutDictionary(XmlBContext ctxt)

  {
ShortcutDictionary res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<ShortcutDictionary");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_ShortcutDictionary(ctxt, "</ShortcutDictionary>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an ShortcutFolder from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static ShortcutFolder acceptShortcutFolder(XmlBContext ctxt)

  {
ShortcutFolder res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<ShortcutFolder");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_ShortcutFolder(ctxt, "</ShortcutFolder>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an Shortcut from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static Shortcut acceptShortcut(XmlBContext ctxt)

  {
Shortcut res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<Shortcut");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_Shortcut(ctxt, "</Shortcut>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an Specification from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static Specification acceptSpecification(XmlBContext ctxt)

  {
Specification res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<Specification");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_Specification(ctxt, "</Specification>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an Chapter from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static Chapter acceptChapter(XmlBContext ctxt)

  {
Chapter res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<Chapter");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_Chapter(ctxt, "</Chapter>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an Paragraph from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static Paragraph acceptParagraph(XmlBContext ctxt)

  {
Paragraph res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<Paragraph");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_Paragraph(ctxt, "</Paragraph>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

/// <summary>Top level function to parse an ParagraphRevision from 
/// a context. This kind of function is only made
/// available for elements marked as MAIN in the 
/// metadefinition</summary>
/// <seealso cref="accept"/>
public static ParagraphRevision acceptParagraphRevision(XmlBContext ctxt)

  {
ParagraphRevision res;
ctxt.skipWhiteSpace();
try {
ctxt.acceptString ("<ParagraphRevision");
if (ctxt.isAlNum()){
ctxt.fail ("White space expected after TAG");
} // If
  res = lAccept_ParagraphRevision(ctxt, "</ParagraphRevision>");
 } catch (XmlBRecoveryException e) {
  throw new XmlBException("Unexpected recovery exception: " +
     e.ToString());
}
  ctxt.close();
if (ctxt.errCount() > 0){
res = null;
throw new XmlBException (ctxt.errorMessage());
} // If
  return res;
  }

public static IXmlBBase accept(XmlBContext ctxt)

{
  IXmlBBase res = null;
ctxt.skipWhiteSpace();
switch (ctxt.current()) {
case '<':
{
ctxt.advance();
switch (ctxt.current()) {
case 'V':
{
ctxt.advance();
ctxt.acceptString ("ariable");
  res =  lAccept_Variable(ctxt, "</Variable>");
break;
} // Case
case 'T':
{
ctxt.advance();
switch (ctxt.current()) {
case 'r':
{
ctxt.advance();
ctxt.acceptString ("anslation");
switch (ctxt.current()) {
case 'D':
{
ctxt.advance();
if (ctxt.lookAheadString("ictionary")){
  res =  lAccept_TranslationDictionary(ctxt, "</TranslationDictionary>");
} else {
  res =  lAccept_Translation(ctxt, "</Translation>");
} // If
break;
} // Case
default:
  res =  lAccept_Translation(ctxt, "</Translation>");
break;
} // Switch
break;
} // Case
case 'e':
{
ctxt.advance();
ctxt.acceptString ("stCase");
  res =  lAccept_TestCase(ctxt, "</TestCase>");
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1887)");
break;
} // Switch
break;
} // Case
case 'S':
{
ctxt.advance();
switch (ctxt.current()) {
case 'u':
{
ctxt.advance();
ctxt.accept2('b','S');
switch (ctxt.current()) {
case 't':
{
ctxt.advance();
ctxt.accept2('e','p');
  res =  lAccept_SubStep(ctxt, "</SubStep>");
break;
} // Case
case 'e':
{
ctxt.advance();
ctxt.acceptString ("quence");
  res =  lAccept_SubSequence(ctxt, "</SubSequence>");
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1892)");
break;
} // Switch
break;
} // Case
case 't':
{
ctxt.advance();
switch (ctxt.current()) {
case 'r':
{
ctxt.advance();
ctxt.acceptString ("ucture");
switch (ctxt.current()) {
case 'P':
{
ctxt.advance();
if (ctxt.lookAheadString("rocedure")){
  res =  lAccept_StructureProcedure(ctxt, "</StructureProcedure>");
} else {
  res =  lAccept_Structure(ctxt, "</Structure>");
} // If
break;
} // Case
case 'E':
{
ctxt.advance();
if (ctxt.lookAheadString("lement")){
  res =  lAccept_StructureElement(ctxt, "</StructureElement>");
} else {
  res =  lAccept_Structure(ctxt, "</Structure>");
} // If
break;
} // Case
default:
  res =  lAccept_Structure(ctxt, "</Structure>");
break;
} // Switch
break;
} // Case
case 'e':
{
ctxt.advance();
ctxt.accept('p');
  res =  lAccept_Step(ctxt, "</Step>");
break;
} // Case
case 'a':
{
ctxt.advance();
ctxt.accept2('t','e');
switch (ctxt.current()) {
case 'M':
{
ctxt.advance();
if (ctxt.lookAheadString("achine")){
  res =  lAccept_StateMachine(ctxt, "</StateMachine>");
} else {
  res =  lAccept_State(ctxt, "</State>");
} // If
break;
} // Case
default:
  res =  lAccept_State(ctxt, "</State>");
break;
} // Switch
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1900)");
break;
} // Switch
break;
} // Case
case 'p':
{
ctxt.advance();
ctxt.acceptString ("ecification");
  res =  lAccept_Specification(ctxt, "</Specification>");
break;
} // Case
case 'o':
{
ctxt.advance();
ctxt.acceptString ("urceText");
  res =  lAccept_SourceText(ctxt, "</SourceText>");
break;
} // Case
case 'h':
{
ctxt.advance();
ctxt.acceptString ("ortcut");
switch (ctxt.current()) {
case 'F':
{
ctxt.advance();
if (ctxt.lookAheadString("older")){
  res =  lAccept_ShortcutFolder(ctxt, "</ShortcutFolder>");
} else {
  res =  lAccept_Shortcut(ctxt, "</Shortcut>");
} // If
break;
} // Case
case 'D':
{
ctxt.advance();
if (ctxt.lookAheadString("ictionary")){
  res =  lAccept_ShortcutDictionary(ctxt, "</ShortcutDictionary>");
} else {
  res =  lAccept_Shortcut(ctxt, "</Shortcut>");
} // If
break;
} // Case
default:
  res =  lAccept_Shortcut(ctxt, "</Shortcut>");
break;
} // Switch
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1906)");
break;
} // Switch
break;
} // Case
case 'R':
{
ctxt.advance();
switch (ctxt.current()) {
case 'u':
{
ctxt.advance();
ctxt.accept2('l','e');
switch (ctxt.current()) {
case 'D':
{
ctxt.advance();
if (ctxt.lookAheadString("isabling")){
  res =  lAccept_RuleDisabling(ctxt, "</RuleDisabling>");
} else {
  res =  lAccept_Rule(ctxt, "</Rule>");
} // If
break;
} // Case
case 'C':
{
ctxt.advance();
if (ctxt.lookAheadString("ondition")){
  res =  lAccept_RuleCondition(ctxt, "</RuleCondition>");
} else {
  res =  lAccept_Rule(ctxt, "</Rule>");
} // If
break;
} // Case
default:
  res =  lAccept_Rule(ctxt, "</Rule>");
break;
} // Switch
break;
} // Case
case 'e':
{
ctxt.advance();
ctxt.acceptString ("qRef");
  res =  lAccept_ReqRef(ctxt, null);
break;
} // Case
case 'a':
{
ctxt.advance();
ctxt.accept3('n','g','e');
  res =  lAccept_Range(ctxt, "</Range>");
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1913)");
break;
} // Switch
break;
} // Case
case 'P':
{
ctxt.advance();
switch (ctxt.current()) {
case 'r':
{
ctxt.advance();
switch (ctxt.current()) {
case 'o':
{
ctxt.advance();
ctxt.acceptString ("cedure");
  res =  lAccept_Procedure(ctxt, "</Procedure>");
break;
} // Case
case 'e':
{
ctxt.advance();
ctxt.acceptString ("Condition");
  res =  lAccept_PreCondition(ctxt, null);
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1918)");
break;
} // Switch
break;
} // Case
case 'a':
{
ctxt.advance();
ctxt.accept2('r','a');
switch (ctxt.current()) {
case 'm':
{
ctxt.advance();
ctxt.acceptString ("eter");
  res =  lAccept_Parameter(ctxt, "</Parameter>");
break;
} // Case
case 'g':
{
ctxt.advance();
ctxt.acceptString ("raph");
switch (ctxt.current()) {
case 'R':
{
ctxt.advance();
if (ctxt.lookAheadString("evision")){
  res =  lAccept_ParagraphRevision(ctxt, null);
} else {
  res =  lAccept_Paragraph(ctxt, "</Paragraph>");
} // If
break;
} // Case
default:
  res =  lAccept_Paragraph(ctxt, "</Paragraph>");
break;
} // Switch
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1923)");
break;
} // Switch
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1924)");
break;
} // Switch
break;
} // Case
case 'N':
{
ctxt.advance();
ctxt.acceptString ("ameSpace");
  res =  lAccept_NameSpace(ctxt, "</NameSpace>");
break;
} // Case
case 'F':
{
ctxt.advance();
switch (ctxt.current()) {
case 'u':
{
ctxt.advance();
ctxt.acceptString ("nction");
  res =  lAccept_Function(ctxt, "</Function>");
break;
} // Case
case 'r':
{
ctxt.advance();
ctxt.accept3('a','m','e');
  res =  lAccept_Frame(ctxt, "</Frame>");
break;
} // Case
case 'o':
{
ctxt.advance();
ctxt.acceptString ("lder");
  res =  lAccept_Folder(ctxt, "</Folder>");
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1930)");
break;
} // Switch
break;
} // Case
case 'E':
{
ctxt.advance();
switch (ctxt.current()) {
case 'x':
{
ctxt.advance();
ctxt.acceptString ("pectation");
  res =  lAccept_Expectation(ctxt, "</Expectation>");
break;
} // Case
case 'n':
{
ctxt.advance();
ctxt.accept2('u','m');
switch (ctxt.current()) {
case 'V':
{
ctxt.advance();
if (ctxt.lookAheadString("alue")){
  res =  lAccept_EnumValue(ctxt, "</EnumValue>");
} else {
  res =  lAccept_Enum(ctxt, "</Enum>");
} // If
break;
} // Case
default:
  res =  lAccept_Enum(ctxt, "</Enum>");
break;
} // Switch
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1935)");
break;
} // Switch
break;
} // Case
case 'D':
{
ctxt.advance();
switch (ctxt.current()) {
case 'i':
{
ctxt.advance();
ctxt.acceptString ("ctionary");
  res =  lAccept_Dictionary(ctxt, null);
break;
} // Case
case 'B':
{
ctxt.advance();
switch (ctxt.current()) {
case 'P':
{
ctxt.advance();
ctxt.acceptString ("acket");
  res =  lAccept_DBPacket(ctxt, "</DBPacket>");
break;
} // Case
case 'M':
{
ctxt.advance();
ctxt.acceptString ("essage");
  res =  lAccept_DBMessage(ctxt, "</DBMessage>");
break;
} // Case
case 'F':
{
ctxt.advance();
ctxt.acceptString ("ield");
  res =  lAccept_DBField(ctxt, "</DBField>");
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1942)");
break;
} // Switch
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1943)");
break;
} // Switch
break;
} // Case
case 'C':
{
ctxt.advance();
switch (ctxt.current()) {
case 'o':
{
ctxt.advance();
ctxt.acceptString ("llection");
  res =  lAccept_Collection(ctxt, "</Collection>");
break;
} // Case
case 'h':
{
ctxt.advance();
ctxt.acceptString ("apter");
  res =  lAccept_Chapter(ctxt, "</Chapter>");
break;
} // Case
case 'a':
{
ctxt.advance();
ctxt.accept2('s','e');
  res =  lAccept_Case(ctxt, "</Case>");
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1948)");
break;
} // Switch
break;
} // Case
case 'A':
{
ctxt.advance();
ctxt.acceptString ("ction");
  res =  lAccept_Action(ctxt, null);
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1950)");
break;
} // Switch
break;
} // Case
default:
ctxt.recoverableFail ("Other character expected (1951)");
break;
} // Switch
return res;
}


/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override bool genericUnParse(TextWriter pw, IXmlBBase obj)
{
  ((XmlBBase ) obj).unParse(pw, false);
  return true;
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public static IXmlBBase[] subElements(IXmlBBase obj)
{
  return ((XmlBBase ) obj).subElements();
}
/// <remarks>This method is used by XMLBooster-generated code
/// internally. Please refrain from using it, as it
/// might produce unexpected results, and might change
/// or even disappear in the future.</remarks>
public  override  IXmlBBase[] genericSubElements(IXmlBBase obj)
{
  return ((XmlBBase ) obj).subElements();
}
public  override IXmlBBase genericAccept (XmlBContext ctxt)

  {
    return accept(ctxt);
  }
}
public abstract partial class Factory
{
public abstract Dictionary createDictionary();
public abstract RuleDisabling createRuleDisabling();
public abstract NameSpace createNameSpace();
public abstract ReqRef createReqRef();
public abstract Enum createEnum();
public abstract EnumValue createEnumValue();
public abstract Range createRange();
public abstract Structure createStructure();
public abstract StructureElement createStructureElement();
public abstract StructureProcedure createStructureProcedure();
public abstract Collection createCollection();
public abstract Function createFunction();
public abstract Parameter createParameter();
public abstract Case createCase();
public abstract Procedure createProcedure();
public abstract StateMachine createStateMachine();
public abstract State createState();
public abstract Variable createVariable();
public abstract Rule createRule();
public abstract RuleCondition createRuleCondition();
public abstract PreCondition createPreCondition();
public abstract Action createAction();
public abstract Frame createFrame();
public abstract SubSequence createSubSequence();
public abstract TestCase createTestCase();
public abstract Step createStep();
public abstract SubStep createSubStep();
public abstract Expectation createExpectation();
public abstract DBMessage createDBMessage();
public abstract DBPacket createDBPacket();
public abstract DBField createDBField();
public abstract TranslationDictionary createTranslationDictionary();
public abstract Folder createFolder();
public abstract Translation createTranslation();
public abstract SourceText createSourceText();
public abstract ShortcutDictionary createShortcutDictionary();
public abstract ShortcutFolder createShortcutFolder();
public abstract Shortcut createShortcut();
public abstract Specification createSpecification();
public abstract Chapter createChapter();
public abstract Paragraph createParagraph();
public abstract Message createMessage();
public abstract MsgVariable createMsgVariable();
public abstract TypeSpec createTypeSpec();
public abstract Values createValues();
public abstract special_or_reserved_values createspecial_or_reserved_values();
public abstract special_or_reserved_value createspecial_or_reserved_value();
public abstract mask createmask();
public abstract match creatematch();
public abstract meaning createmeaning();
public abstract match_range creatematch_range();
public abstract resolution_formula createresolution_formula();
public abstract value createvalue();
public abstract char_value createchar_value();
public abstract ParagraphRevision createParagraphRevision();
}

public partial class TestParser
{
public static void main( string [] args)
  {
   XmlBTester tester = new  XmlBTester();
   tester.performTest (acceptor.getUnique(), args);
  }
}

public partial class Visitor
: XmlBBaseVisitor
{
public virtual void visit(Namable obj)
{
  visit(obj, true);
}

public virtual void visit(Namable obj, bool visitSubNodes)
{
visit ((IXmlBBase)obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(ReferencesParagraph obj)
{
  visit(obj, true);
}

public virtual void visit(ReferencesParagraph obj, bool visitSubNodes)
{
visit ((Namable) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(ReqRelated obj)
{
  visit(obj, true);
}

public virtual void visit(ReqRelated obj, bool visitSubNodes)
{
visit ((ReferencesParagraph) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(Dictionary obj)
{
  visit(obj, true);
}

public virtual void visit(Dictionary obj, bool visitSubNodes)
{
visit ((IXmlBBase)obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(RuleDisabling obj)
{
  visit(obj, true);
}

public virtual void visit(RuleDisabling obj, bool visitSubNodes)
{
visit ((ReqRelated) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(NameSpace obj)
{
  visit(obj, true);
}

public virtual void visit(NameSpace obj, bool visitSubNodes)
{
visit ((Namable) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(ReqRef obj)
{
  visit(obj, true);
}

public virtual void visit(ReqRef obj, bool visitSubNodes)
{
visit ((IXmlBBase)obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(Type obj)
{
  visit(obj, true);
}

public virtual void visit(Type obj, bool visitSubNodes)
{
visit ((ReqRelated) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(Enum obj)
{
  visit(obj, true);
}

public virtual void visit(Enum obj, bool visitSubNodes)
{
visit ((Type) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(EnumValue obj)
{
  visit(obj, true);
}

public virtual void visit(EnumValue obj, bool visitSubNodes)
{
visit ((Namable) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(Range obj)
{
  visit(obj, true);
}

public virtual void visit(Range obj, bool visitSubNodes)
{
visit ((Type) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(Structure obj)
{
  visit(obj, true);
}

public virtual void visit(Structure obj, bool visitSubNodes)
{
visit ((Type) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(StructureElement obj)
{
  visit(obj, true);
}

public virtual void visit(StructureElement obj, bool visitSubNodes)
{
visit ((ReqRelated) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(StructureProcedure obj)
{
  visit(obj, true);
}

public virtual void visit(StructureProcedure obj, bool visitSubNodes)
{
visit ((ReqRelated) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(Collection obj)
{
  visit(obj, true);
}

public virtual void visit(Collection obj, bool visitSubNodes)
{
visit ((Type) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(Function obj)
{
  visit(obj, true);
}

public virtual void visit(Function obj, bool visitSubNodes)
{
visit ((Type) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(Parameter obj)
{
  visit(obj, true);
}

public virtual void visit(Parameter obj, bool visitSubNodes)
{
visit ((Namable) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(Case obj)
{
  visit(obj, true);
}

public virtual void visit(Case obj, bool visitSubNodes)
{
visit ((Namable) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(Procedure obj)
{
  visit(obj, true);
}

public virtual void visit(Procedure obj, bool visitSubNodes)
{
visit ((ReqRelated) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(StateMachine obj)
{
  visit(obj, true);
}

public virtual void visit(StateMachine obj, bool visitSubNodes)
{
visit ((Type) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(State obj)
{
  visit(obj, true);
}

public virtual void visit(State obj, bool visitSubNodes)
{
visit ((ReqRelated) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(Variable obj)
{
  visit(obj, true);
}

public virtual void visit(Variable obj, bool visitSubNodes)
{
visit ((ReqRelated) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(Rule obj)
{
  visit(obj, true);
}

public virtual void visit(Rule obj, bool visitSubNodes)
{
visit ((ReqRelated) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(RuleCondition obj)
{
  visit(obj, true);
}

public virtual void visit(RuleCondition obj, bool visitSubNodes)
{
visit ((ReqRelated) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(PreCondition obj)
{
  visit(obj, true);
}

public virtual void visit(PreCondition obj, bool visitSubNodes)
{
visit ((IXmlBBase)obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(Action obj)
{
  visit(obj, true);
}

public virtual void visit(Action obj, bool visitSubNodes)
{
visit ((IXmlBBase)obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(Frame obj)
{
  visit(obj, true);
}

public virtual void visit(Frame obj, bool visitSubNodes)
{
visit ((Namable) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(SubSequence obj)
{
  visit(obj, true);
}

public virtual void visit(SubSequence obj, bool visitSubNodes)
{
visit ((Namable) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(TestCase obj)
{
  visit(obj, true);
}

public virtual void visit(TestCase obj, bool visitSubNodes)
{
visit ((ReqRelated) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(Step obj)
{
  visit(obj, true);
}

public virtual void visit(Step obj, bool visitSubNodes)
{
visit ((Namable) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(SubStep obj)
{
  visit(obj, true);
}

public virtual void visit(SubStep obj, bool visitSubNodes)
{
visit ((Namable) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(Expectation obj)
{
  visit(obj, true);
}

public virtual void visit(Expectation obj, bool visitSubNodes)
{
visit ((Namable) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(DBMessage obj)
{
  visit(obj, true);
}

public virtual void visit(DBMessage obj, bool visitSubNodes)
{
visit ((Namable) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(DBPacket obj)
{
  visit(obj, true);
}

public virtual void visit(DBPacket obj, bool visitSubNodes)
{
visit ((Namable) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(DBField obj)
{
  visit(obj, true);
}

public virtual void visit(DBField obj, bool visitSubNodes)
{
visit ((Namable) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(TranslationDictionary obj)
{
  visit(obj, true);
}

public virtual void visit(TranslationDictionary obj, bool visitSubNodes)
{
visit ((Namable) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(Folder obj)
{
  visit(obj, true);
}

public virtual void visit(Folder obj, bool visitSubNodes)
{
visit ((Namable) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(Translation obj)
{
  visit(obj, true);
}

public virtual void visit(Translation obj, bool visitSubNodes)
{
visit ((Namable) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(SourceText obj)
{
  visit(obj, true);
}

public virtual void visit(SourceText obj, bool visitSubNodes)
{
visit ((Namable) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(ShortcutDictionary obj)
{
  visit(obj, true);
}

public virtual void visit(ShortcutDictionary obj, bool visitSubNodes)
{
visit ((Namable) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(ShortcutFolder obj)
{
  visit(obj, true);
}

public virtual void visit(ShortcutFolder obj, bool visitSubNodes)
{
visit ((Namable) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(Shortcut obj)
{
  visit(obj, true);
}

public virtual void visit(Shortcut obj, bool visitSubNodes)
{
visit ((Namable) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(Specification obj)
{
  visit(obj, true);
}

public virtual void visit(Specification obj, bool visitSubNodes)
{
visit ((Namable) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(Chapter obj)
{
  visit(obj, true);
}

public virtual void visit(Chapter obj, bool visitSubNodes)
{
visit ((Namable) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(Paragraph obj)
{
  visit(obj, true);
}

public virtual void visit(Paragraph obj, bool visitSubNodes)
{
visit ((ReferencesParagraph) obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(Message obj)
{
  visit(obj, true);
}

public virtual void visit(Message obj, bool visitSubNodes)
{
visit ((IXmlBBase)obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(MsgVariable obj)
{
  visit(obj, true);
}

public virtual void visit(MsgVariable obj, bool visitSubNodes)
{
visit ((IXmlBBase)obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(TypeSpec obj)
{
  visit(obj, true);
}

public virtual void visit(TypeSpec obj, bool visitSubNodes)
{
visit ((IXmlBBase)obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(Values obj)
{
  visit(obj, true);
}

public virtual void visit(Values obj, bool visitSubNodes)
{
visit ((IXmlBBase)obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(special_or_reserved_values obj)
{
  visit(obj, true);
}

public virtual void visit(special_or_reserved_values obj, bool visitSubNodes)
{
visit ((IXmlBBase)obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(special_or_reserved_value obj)
{
  visit(obj, true);
}

public virtual void visit(special_or_reserved_value obj, bool visitSubNodes)
{
visit ((IXmlBBase)obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(mask obj)
{
  visit(obj, true);
}

public virtual void visit(mask obj, bool visitSubNodes)
{
visit ((IXmlBBase)obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(match obj)
{
  visit(obj, true);
}

public virtual void visit(match obj, bool visitSubNodes)
{
visit ((IXmlBBase)obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(meaning obj)
{
  visit(obj, true);
}

public virtual void visit(meaning obj, bool visitSubNodes)
{
visit ((IXmlBBase)obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(match_range obj)
{
  visit(obj, true);
}

public virtual void visit(match_range obj, bool visitSubNodes)
{
visit ((IXmlBBase)obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(resolution_formula obj)
{
  visit(obj, true);
}

public virtual void visit(resolution_formula obj, bool visitSubNodes)
{
visit ((IXmlBBase)obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(value obj)
{
  visit(obj, true);
}

public virtual void visit(value obj, bool visitSubNodes)
{
visit ((IXmlBBase)obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(char_value obj)
{
  visit(obj, true);
}

public virtual void visit(char_value obj, bool visitSubNodes)
{
visit ((IXmlBBase)obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public virtual void visit(ParagraphRevision obj)
{
  visit(obj, true);
}

public virtual void visit(ParagraphRevision obj, bool visitSubNodes)
{
visit ((IXmlBBase)obj, false);
if (visitSubNodes){
IXmlBBase[] Subs  = acceptor.subElements((IXmlBBase)obj);
if (Subs != null){
for (int i=0; i<Subs.Length; i++) {
  dispatch(Subs[i], true);
} // If
} // If
}
}

public  override  void dispatch(IXmlBBase obj)
{
  dispatch (obj, true);
}

public  override  void dispatch(IXmlBBase obj, bool visitSubNodes)
{
if (obj == null){
return;
} // If
((XmlBBase)obj).dispatch(this, visitSubNodes);
} // End of dispatch methods

}
}
