// <auto-generated/>
// Contents of: hl7.fhir.r5.core version: 5.0.0-snapshot1

using Hl7.Fhir.Utility;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  
*/

namespace Hl7.Fhir.Model
{
  /// <summary>
  /// All published FHIR Versions.
  /// (url: http://hl7.org/fhir/ValueSet/FHIR-version)
  /// (system: http://hl7.org/fhir/FHIR-version)
  /// </summary>
  [FhirEnumeration("FHIRVersion")]
  public enum FHIRVersion
  {
    /// <summary>
    /// Oldest archived version of FHIR.
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("0.01", "http://hl7.org/fhir/FHIR-version"), Description("0.01")]
    N0_01,
    /// <summary>
    /// 1st Draft for Comment (Sept 2012 Ballot).
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("0.05", "http://hl7.org/fhir/FHIR-version"), Description("0.05")]
    N0_05,
    /// <summary>
    /// 2nd Draft for Comment (January 2013 Ballot).
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("0.06", "http://hl7.org/fhir/FHIR-version"), Description("0.06")]
    N0_06,
    /// <summary>
    /// DSTU 1 Ballot version.
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("0.11", "http://hl7.org/fhir/FHIR-version"), Description("0.11")]
    N0_11,
    /// <summary>
    /// DSTU 1 Official version.
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("0.0.80", "http://hl7.org/fhir/FHIR-version"), Description("0.0.80")]
    N0_0_80,
    /// <summary>
    /// DSTU 1 Official version Technical Errata #1.
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("0.0.81", "http://hl7.org/fhir/FHIR-version"), Description("0.0.81")]
    N0_0_81,
    /// <summary>
    /// DSTU 1 Official version Technical Errata #2.
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("0.0.82", "http://hl7.org/fhir/FHIR-version"), Description("0.0.82")]
    N0_0_82,
    /// <summary>
    /// Draft For Comment (January 2015 Ballot).
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("0.4.0", "http://hl7.org/fhir/FHIR-version"), Description("0.4.0")]
    N0_4_0,
    /// <summary>
    /// DSTU 2 Ballot version (May 2015 Ballot).
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("0.5.0", "http://hl7.org/fhir/FHIR-version"), Description("0.5.0")]
    N0_5_0,
    /// <summary>
    /// DSTU 2 QA Preview + CQIF Ballot (Sep 2015).
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("1.0.0", "http://hl7.org/fhir/FHIR-version"), Description("1.0.0")]
    N1_0_0,
    /// <summary>
    /// DSTU 2 (Official version).
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("1.0.1", "http://hl7.org/fhir/FHIR-version"), Description("1.0.1")]
    N1_0_1,
    /// <summary>
    /// DSTU 2 (Official version) with 1 technical errata.
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("1.0.2", "http://hl7.org/fhir/FHIR-version"), Description("1.0.2")]
    N1_0_2,
    /// <summary>
    /// GAO Ballot + draft changes to main FHIR standard.
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("1.1.0", "http://hl7.org/fhir/FHIR-version"), Description("1.1.0")]
    N1_1_0,
    /// <summary>
    /// CQF on FHIR Ballot + Connectathon 12 (Montreal).
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("1.4.0", "http://hl7.org/fhir/FHIR-version"), Description("1.4.0")]
    N1_4_0,
    /// <summary>
    /// FHIR STU3 Ballot + Connectathon 13 (Baltimore).
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("1.6.0", "http://hl7.org/fhir/FHIR-version"), Description("1.6.0")]
    N1_6_0,
    /// <summary>
    /// FHIR STU3 Candidate + Connectathon 14 (San Antonio).
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("1.8.0", "http://hl7.org/fhir/FHIR-version"), Description("1.8.0")]
    N1_8_0,
    /// <summary>
    /// FHIR Release 3 (STU).
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("3.0.0", "http://hl7.org/fhir/FHIR-version"), Description("3.0.0")]
    N3_0_0,
    /// <summary>
    /// FHIR Release 3 (STU) with 1 technical errata.
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("3.0.1", "http://hl7.org/fhir/FHIR-version"), Description("3.0.1")]
    N3_0_1,
    /// <summary>
    /// FHIR Release 3 (STU) with 2 technical errata.
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("3.0.2", "http://hl7.org/fhir/FHIR-version"), Description("3.0.2")]
    N3_0_2,
    /// <summary>
    /// R4 Ballot #1.
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("3.3.0", "http://hl7.org/fhir/FHIR-version"), Description("3.3.0")]
    N3_3_0,
    /// <summary>
    /// R4 Ballot #2.
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("3.5.0", "http://hl7.org/fhir/FHIR-version"), Description("3.5.0")]
    N3_5_0,
    /// <summary>
    /// FHIR Release 4 (Normative + STU).
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("4.0.0", "http://hl7.org/fhir/FHIR-version"), Description("4.0.0")]
    N4_0_0,
    /// <summary>
    /// FHIR Release 4 (Normative + STU) with 1 technical errata.
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("4.0.1", "http://hl7.org/fhir/FHIR-version"), Description("4.0.1")]
    N4_0_1,
    /// <summary>
    /// Interim Version.
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("4.1.0", "http://hl7.org/fhir/FHIR-version"), Description("4.1.0")]
    N4_1_0,
    /// <summary>
    /// R5 Preview #1.
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("4.2.0", "http://hl7.org/fhir/FHIR-version"), Description("4.2.0")]
    N4_2_0,
    /// <summary>
    /// R4B .
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("4.3.0", "http://hl7.org/fhir/FHIR-version"), Description("4.3.0")]
    N4_3_0,
    /// <summary>
    /// R4B Snapshot #1.
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("4.3.0-snapshot1", "http://hl7.org/fhir/FHIR-version"), Description("4.3.0-snapshot1")]
    N4_3_0Snapshot1,
    /// <summary>
    /// R4B Rolling CI-Build.
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("4.3.0-cibuild", "http://hl7.org/fhir/FHIR-version"), Description("4.3.0-cibuild")]
    N4_3_0Cibuild,
    /// <summary>
    /// R5 Preview #2.
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("4.4.0", "http://hl7.org/fhir/FHIR-version"), Description("4.4.0")]
    N4_4_0,
    /// <summary>
    /// R5 Preview #3.
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("4.5.0", "http://hl7.org/fhir/FHIR-version"), Description("4.5.0")]
    N4_5_0,
    /// <summary>
    /// R5 Draft Ballot.
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("4.6.0", "http://hl7.org/fhir/FHIR-version"), Description("4.6.0")]
    N4_6_0,
    /// <summary>
    /// R5 Snapshot #1.
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("5.0.0-snapshot1", "http://hl7.org/fhir/FHIR-version"), Description("5.0.0-snapshot1")]
    N5_0_0Snapshot1,
    /// <summary>
    /// R5 Rolling CI-Build.
    /// (system: http://hl7.org/fhir/FHIR-version)
    /// </summary>
    [EnumLiteral("5.0.0-cibuild", "http://hl7.org/fhir/FHIR-version"), Description("5.0.0-cibuild")]
    N5_0_0Cibuild,
  }

  /// <summary>
  /// The kind of operation to perform as a part of a property based filter.
  /// (url: http://hl7.org/fhir/ValueSet/filter-operator)
  /// (system: http://hl7.org/fhir/filter-operator)
  /// </summary>
  [FhirEnumeration("FilterOperator")]
  public enum FilterOperator
  {
    /// <summary>
    /// The specified property of the code equals the provided value.
    /// (system: http://hl7.org/fhir/filter-operator)
    /// </summary>
    [EnumLiteral("=", "http://hl7.org/fhir/filter-operator"), Description("Equals")]
    Equal,
    /// <summary>
    /// Includes all concept ids that have a transitive is-a relationship with the concept Id provided as the value, including the provided concept itself (include descendant codes and self).
    /// (system: http://hl7.org/fhir/filter-operator)
    /// </summary>
    [EnumLiteral("is-a", "http://hl7.org/fhir/filter-operator"), Description("Is A (by subsumption)")]
    IsA,
    /// <summary>
    /// Includes all concept ids that have a transitive is-a relationship with the concept Id provided as the value, excluding the provided concept itself i.e. include descendant codes only).
    /// (system: http://hl7.org/fhir/filter-operator)
    /// </summary>
    [EnumLiteral("descendent-of", "http://hl7.org/fhir/filter-operator"), Description("Descendent Of (by subsumption)")]
    DescendentOf,
    /// <summary>
    /// The specified property of the code does not have an is-a relationship with the provided value.
    /// (system: http://hl7.org/fhir/filter-operator)
    /// </summary>
    [EnumLiteral("is-not-a", "http://hl7.org/fhir/filter-operator"), Description("Not (Is A) (by subsumption)")]
    IsNotA,
    /// <summary>
    /// The specified property of the code  matches the regex specified in the provided value.
    /// (system: http://hl7.org/fhir/filter-operator)
    /// </summary>
    [EnumLiteral("regex", "http://hl7.org/fhir/filter-operator"), Description("Regular Expression")]
    Regex,
    /// <summary>
    /// The specified property of the code is in the set of codes or concepts specified in the provided value (comma separated list).
    /// (system: http://hl7.org/fhir/filter-operator)
    /// </summary>
    [EnumLiteral("in", "http://hl7.org/fhir/filter-operator"), Description("In Set")]
    In,
    /// <summary>
    /// The specified property of the code is not in the set of codes or concepts specified in the provided value (comma separated list).
    /// (system: http://hl7.org/fhir/filter-operator)
    /// </summary>
    [EnumLiteral("not-in", "http://hl7.org/fhir/filter-operator"), Description("Not in Set")]
    NotIn,
    /// <summary>
    /// Includes all concept ids that have a transitive is-a relationship from the concept Id provided as the value, including the provided concept itself (i.e. include ancestor codes and self).
    /// (system: http://hl7.org/fhir/filter-operator)
    /// </summary>
    [EnumLiteral("generalizes", "http://hl7.org/fhir/filter-operator"), Description("Generalizes (by Subsumption)")]
    Generalizes,
    /// <summary>
    /// Only concepts with a direct hierarchical relationship to the index code and no other concepts. This does not include the index code in the output.
    /// (system: http://hl7.org/fhir/filter-operator)
    /// </summary>
    [EnumLiteral("child-of", "http://hl7.org/fhir/filter-operator"), Description("Child Of")]
    ChildOf,
    /// <summary>
    /// Includes concept ids that have a transitive is-a relationship with the concept Id provided as the value, but which do not have any concept ids with transitive is-a relationships with themselves.
    /// (system: http://hl7.org/fhir/filter-operator)
    /// </summary>
    [EnumLiteral("descendent-leaf", "http://hl7.org/fhir/filter-operator"), Description("Descendent Leaf")]
    DescendentLeaf,
    /// <summary>
    /// The specified property of the code has at least one value (if the specified value is true; if the specified value is false, then matches when the specified property of the code has no values).
    /// (system: http://hl7.org/fhir/filter-operator)
    /// </summary>
    [EnumLiteral("exists", "http://hl7.org/fhir/filter-operator"), Description("Exists")]
    Exists,
  }

  /// <summary>
  /// The lifecycle status of an artifact.
  /// (url: http://hl7.org/fhir/ValueSet/publication-status)
  /// (system: http://hl7.org/fhir/publication-status)
  /// </summary>
  [FhirEnumeration("PublicationStatus")]
  public enum PublicationStatus
  {
    /// <summary>
    /// This resource is still under development and is not yet considered to be ready for normal use.
    /// (system: http://hl7.org/fhir/publication-status)
    /// </summary>
    [EnumLiteral("draft", "http://hl7.org/fhir/publication-status"), Description("Draft")]
    Draft,
    /// <summary>
    /// This resource is ready for normal use.
    /// (system: http://hl7.org/fhir/publication-status)
    /// </summary>
    [EnumLiteral("active", "http://hl7.org/fhir/publication-status"), Description("Active")]
    Active,
    /// <summary>
    /// This resource has been withdrawn or superseded and should no longer be used.
    /// (system: http://hl7.org/fhir/publication-status)
    /// </summary>
    [EnumLiteral("retired", "http://hl7.org/fhir/publication-status"), Description("Retired")]
    Retired,
    /// <summary>
    /// The authoring system does not know which of the status values currently applies for this resource.  Note: This concept is not to be used for "other" - one of the listed statuses is presumed to apply, it's just not known which one.
    /// (system: http://hl7.org/fhir/publication-status)
    /// </summary>
    [EnumLiteral("unknown", "http://hl7.org/fhir/publication-status"), Description("Unknown")]
    Unknown,
  }

}
