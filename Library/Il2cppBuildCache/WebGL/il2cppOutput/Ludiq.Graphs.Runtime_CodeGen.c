#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





// 0x00000001 System.Void Ludiq.ConnectionCollection`3::.ctor()
// 0x00000002 System.Void Ludiq.ConnectionCollectionBase`4::.ctor(TCollection)
// 0x00000003 System.Int32 Ludiq.ConnectionCollectionBase`4::get_Count()
// 0x00000004 System.Boolean Ludiq.ConnectionCollectionBase`4::get_IsReadOnly()
// 0x00000005 System.Collections.Generic.IEnumerator`1<TConnection> Ludiq.ConnectionCollectionBase`4::GetEnumerator()
// 0x00000006 System.Collections.IEnumerator Ludiq.ConnectionCollectionBase`4::System.Collections.IEnumerable.GetEnumerator()
// 0x00000007 System.Collections.Generic.IEnumerable`1<TConnection> Ludiq.ConnectionCollectionBase`4::WithSource(TSource)
// 0x00000008 System.Collections.Generic.List`1<TConnection> Ludiq.ConnectionCollectionBase`4::WithSourceNoAlloc(TSource)
// 0x00000009 TConnection Ludiq.ConnectionCollectionBase`4::SingleOrDefaultWithSource(TSource)
// 0x0000000A System.Collections.Generic.IEnumerable`1<TConnection> Ludiq.ConnectionCollectionBase`4::WithDestination(TDestination)
// 0x0000000B System.Collections.Generic.List`1<TConnection> Ludiq.ConnectionCollectionBase`4::WithDestinationNoAlloc(TDestination)
// 0x0000000C TConnection Ludiq.ConnectionCollectionBase`4::SingleOrDefaultWithDestination(TDestination)
// 0x0000000D System.Void Ludiq.ConnectionCollectionBase`4::Add(TConnection)
// 0x0000000E System.Void Ludiq.ConnectionCollectionBase`4::Clear()
// 0x0000000F System.Boolean Ludiq.ConnectionCollectionBase`4::Contains(TConnection)
// 0x00000010 System.Void Ludiq.ConnectionCollectionBase`4::CopyTo(TConnection[],System.Int32)
// 0x00000011 System.Boolean Ludiq.ConnectionCollectionBase`4::Remove(TConnection)
// 0x00000012 System.Void Ludiq.ConnectionCollectionBase`4::BeforeAdd(TConnection)
// 0x00000013 System.Void Ludiq.ConnectionCollectionBase`4::AfterAdd(TConnection)
// 0x00000014 System.Void Ludiq.ConnectionCollectionBase`4::BeforeRemove(TConnection)
// 0x00000015 System.Void Ludiq.ConnectionCollectionBase`4::AfterRemove(TConnection)
// 0x00000016 System.Void Ludiq.ConnectionCollectionBase`4::AddToDictionaries(TConnection)
// 0x00000017 System.Void Ludiq.ConnectionCollectionBase`4::RemoveFromDictionaries(TConnection)
// 0x00000018 System.Void Ludiq.GraphConnectionCollection`3::.ctor(Ludiq.IGraph)
// 0x00000019 TConnection Ludiq.GraphConnectionCollection`3::Ludiq.IKeyedCollection<System.Guid,TConnection>.get_Item(System.Guid)
// 0x0000001A TConnection Ludiq.GraphConnectionCollection`3::Ludiq.IKeyedCollection<System.Guid,TConnection>.get_Item(System.Int32)
// 0x0000001B System.Boolean Ludiq.GraphConnectionCollection`3::TryGetValue(System.Guid,TConnection&)
// 0x0000001C System.Boolean Ludiq.GraphConnectionCollection`3::Contains(System.Guid)
// 0x0000001D System.Boolean Ludiq.GraphConnectionCollection`3::Remove(System.Guid)
// 0x0000001E System.Void Ludiq.GraphConnectionCollection`3::add_ItemAdded(System.Action`1<TConnection>)
// 0x0000001F System.Void Ludiq.GraphConnectionCollection`3::remove_ItemAdded(System.Action`1<TConnection>)
// 0x00000020 System.Void Ludiq.GraphConnectionCollection`3::add_ItemRemoved(System.Action`1<TConnection>)
// 0x00000021 System.Void Ludiq.GraphConnectionCollection`3::remove_ItemRemoved(System.Action`1<TConnection>)
// 0x00000022 System.Void Ludiq.GraphConnectionCollection`3::add_CollectionChanged(System.Action)
// 0x00000023 System.Void Ludiq.GraphConnectionCollection`3::remove_CollectionChanged(System.Action)
// 0x00000024 System.Void Ludiq.GraphConnectionCollection`3::BeforeAdd(TConnection)
// 0x00000025 System.Void Ludiq.GraphConnectionCollection`3::AfterAdd(TConnection)
// 0x00000026 System.Void Ludiq.GraphConnectionCollection`3::BeforeRemove(TConnection)
// 0x00000027 System.Void Ludiq.GraphConnectionCollection`3::AfterRemove(TConnection)
// 0x00000028 TSource Ludiq.IConnection`2::get_source()
// 0x00000029 TDestination Ludiq.IConnection`2::get_destination()
// 0x0000002A System.Collections.Generic.IEnumerable`1<TConnection> Ludiq.IConnectionCollection`3::WithSource(TSource)
// 0x0000002B System.Collections.Generic.IEnumerable`1<TConnection> Ludiq.IConnectionCollection`3::WithDestination(TDestination)
// 0x0000002C System.Void Ludiq.InvalidConnectionException::.ctor()
extern void InvalidConnectionException__ctor_m86E7E705D6D743EC889B9DC029519356A9959313 (void);
// 0x0000002D System.Void Ludiq.InvalidConnectionException::.ctor(System.String)
extern void InvalidConnectionException__ctor_m79421FA5BA58D7D3BA399956FC9DD9DA47B8BB2A (void);
// 0x0000002E System.Void Ludiq.GraphInstances::Instantiate(Ludiq.GraphReference)
extern void GraphInstances_Instantiate_mBC31DB722EE7E9EC02A45642024A22C0C7695CC7 (void);
// 0x0000002F System.Void Ludiq.GraphInstances::Uninstantiate(Ludiq.GraphReference)
extern void GraphInstances_Uninstantiate_mF863E6AE4EC4FAD8D64BC18F1F1A723EB1C72D50 (void);
// 0x00000030 System.Collections.Generic.HashSet`1<Ludiq.GraphReference> Ludiq.GraphInstances::OfPooled(Ludiq.IGraph)
extern void GraphInstances_OfPooled_m9E532550FEF24E877CD47E48A3884E830FA1CEB4 (void);
// 0x00000031 System.Collections.Generic.HashSet`1<Ludiq.GraphReference> Ludiq.GraphInstances::ChildrenOfPooled(Ludiq.IGraphParent)
extern void GraphInstances_ChildrenOfPooled_m9A07D540940AA5B69093ED48E2C8293687409CC9 (void);
// 0x00000032 System.Void Ludiq.GraphInstances::.cctor()
extern void GraphInstances__cctor_m79D8D1ABDE65010BC00A0430B7F3DA38F9734420 (void);
// 0x00000033 System.Void Ludiq.Graph::.ctor()
extern void Graph__ctor_m6F72F00F374810EB4024E58D29780BD8055CF916 (void);
// 0x00000034 System.String Ludiq.Graph::ToString()
extern void Graph_ToString_mF78E5DC8E7129A5359497307829421DB86D0CC42 (void);
// 0x00000035 Ludiq.IGraphData Ludiq.Graph::CreateData()
// 0x00000036 System.Void Ludiq.Graph::Instantiate(Ludiq.GraphReference)
extern void Graph_Instantiate_mAD543BF2706C3897117259408FD5501A5ABEAA3B (void);
// 0x00000037 System.Void Ludiq.Graph::Uninstantiate(Ludiq.GraphReference)
extern void Graph_Uninstantiate_m1260B45C45E2C967A4DF3402BDB257A0A4D9F7C1 (void);
// 0x00000038 Ludiq.MergedGraphElementCollection Ludiq.Graph::get_elements()
extern void Graph_get_elements_m36E0480F07EB0370BE8DBC5BAB4E7E626562B5F1 (void);
// 0x00000039 System.String Ludiq.Graph::get_title()
extern void Graph_get_title_mA50AF2EE564274FCDD08A5076719D2618B5F461E (void);
// 0x0000003A System.Collections.Generic.IEnumerable`1<Ludiq.ISerializationDependency> Ludiq.Graph::get_deserializationDependencies()
extern void Graph_get_deserializationDependencies_mDA92D8D77F25A6CCE1EBD6EB81771A1B366CB3C2 (void);
// 0x0000003B System.Void Ludiq.Graph::OnBeforeSerialize()
extern void Graph_OnBeforeSerialize_m7D416CA5137AD12973E15DE52CC17E7253FC39FC (void);
// 0x0000003C System.Void Ludiq.Graph::OnAfterDeserialize()
extern void Graph_OnAfterDeserialize_m0BB30DC6E1FA13E79BD28CA88ED6644561E79AFC (void);
// 0x0000003D System.Void Ludiq.Graph::OnAfterDependenciesDeserialized()
extern void Graph_OnAfterDependenciesDeserialized_mC7705F29E805E8C7310B0C3FEA7E8BD1AE0A1861 (void);
// 0x0000003E System.Collections.Generic.IEnumerable`1<System.Object> Ludiq.Graph::get_aotStubs()
extern void Graph_get_aotStubs_mA24A6C5D52A82A0979CA421BF782C54A22C63F44 (void);
// 0x0000003F System.Void Ludiq.Graph::Prewarm()
extern void Graph_Prewarm_m9B895DE4859AD5123E5CD3CD06C04080B114C68B (void);
// 0x00000040 System.Void Ludiq.Graph::Dispose()
extern void Graph_Dispose_m099682F7202675BB39DAFDDD1F413A7F4456A8CA (void);
// 0x00000041 System.Void Ludiq.Graph/<>c::.cctor()
extern void U3CU3Ec__cctor_m4C4D54CB9534950C0B32DD17ED6C5E01CAF2E68D (void);
// 0x00000042 System.Void Ludiq.Graph/<>c::.ctor()
extern void U3CU3Ec__ctor_mA26BEA21945EECDE80518D03CC7BBEB8F24A1467 (void);
// 0x00000043 System.Collections.Generic.IEnumerable`1<Ludiq.ISerializationDependency> Ludiq.Graph/<>c::<get_deserializationDependencies>b__27_0(Ludiq.IGraphElement)
extern void U3CU3Ec_U3Cget_deserializationDependenciesU3Eb__27_0_mD10D29836B1806822144384CDFC1E23FA017BA53 (void);
// 0x00000044 System.Int32 Ludiq.Graph/<>c::<OnAfterDependenciesDeserialized>b__30_0(Ludiq.IGraphElement,Ludiq.IGraphElement)
extern void U3CU3Ec_U3COnAfterDependenciesDeserializedU3Eb__30_0_mBBDCA42BAC854CBA79FB3CCFAAFE980BFE6B588A (void);
// 0x00000045 System.Collections.Generic.IEnumerable`1<System.Object> Ludiq.Graph/<>c::<get_aotStubs>b__32_0(Ludiq.IGraphElement)
extern void U3CU3Ec_U3Cget_aotStubsU3Eb__32_0_m8BA8FB5E1E2F9F9647E2F0CB328CF014891049E9 (void);
// 0x00000046 System.Void Ludiq.GraphElementCollection`1::.ctor(Ludiq.IGraph)
// 0x00000047 Ludiq.IGraph Ludiq.GraphElementCollection`1::get_graph()
// 0x00000048 System.Void Ludiq.GraphElementCollection`1::add_ItemAdded(System.Action`1<TElement>)
// 0x00000049 System.Void Ludiq.GraphElementCollection`1::remove_ItemAdded(System.Action`1<TElement>)
// 0x0000004A System.Void Ludiq.GraphElementCollection`1::add_ItemRemoved(System.Action`1<TElement>)
// 0x0000004B System.Void Ludiq.GraphElementCollection`1::remove_ItemRemoved(System.Action`1<TElement>)
// 0x0000004C System.Void Ludiq.GraphElementCollection`1::add_CollectionChanged(System.Action)
// 0x0000004D System.Void Ludiq.GraphElementCollection`1::remove_CollectionChanged(System.Action)
// 0x0000004E System.Boolean Ludiq.GraphElementCollection`1::get_ProxyCollectionChange()
// 0x0000004F System.Void Ludiq.GraphElementCollection`1::set_ProxyCollectionChange(System.Boolean)
// 0x00000050 System.Void Ludiq.GraphElementCollection`1::BeforeAdd(TElement)
// 0x00000051 System.Void Ludiq.GraphElementCollection`1::AfterAdd(TElement)
// 0x00000052 System.Void Ludiq.GraphElementCollection`1::BeforeRemove(TElement)
// 0x00000053 System.Void Ludiq.GraphElementCollection`1::AfterRemove(TElement)
// 0x00000054 System.Void Ludiq.GraphElementCollection`1::InsertItem(System.Int32,TElement)
// 0x00000055 System.Void Ludiq.GraphElementCollection`1::RemoveItem(System.Int32)
// 0x00000056 System.Void Ludiq.GraphElementCollection`1::ClearItems()
// 0x00000057 System.Void Ludiq.GraphElementCollection`1::SetItem(System.Int32,TElement)
// 0x00000058 Ludiq.NoAllocEnumerator`1<TElement> Ludiq.GraphElementCollection`1::GetEnumerator()
// 0x00000059 System.Void Ludiq.GraphElementCollection`1/<>c::.cctor()
// 0x0000005A System.Void Ludiq.GraphElementCollection`1/<>c::.ctor()
// 0x0000005B System.Int32 Ludiq.GraphElementCollection`1/<>c::<ClearItems>b__23_0(TElement,TElement)
// 0x0000005C System.Void Ludiq.GraphData`1::.ctor(TGraph)
// 0x0000005D System.Collections.Generic.Dictionary`2<Ludiq.IGraphElementWithData,Ludiq.IGraphElementData> Ludiq.GraphData`1::get_elementsData()
// 0x0000005E System.Collections.Generic.Dictionary`2<Ludiq.IGraphParentElement,Ludiq.IGraphData> Ludiq.GraphData`1::get_childrenGraphsData()
// 0x0000005F System.Collections.Generic.Dictionary`2<System.Guid,Ludiq.IGraphElementData> Ludiq.GraphData`1::get_phantomElementsData()
// 0x00000060 System.Collections.Generic.Dictionary`2<System.Guid,Ludiq.IGraphData> Ludiq.GraphData`1::get_phantomChildrenGraphsData()
// 0x00000061 System.Boolean Ludiq.GraphData`1::TryGetElementData(Ludiq.IGraphElementWithData,Ludiq.IGraphElementData&)
// 0x00000062 System.Boolean Ludiq.GraphData`1::TryGetChildGraphData(Ludiq.IGraphParentElement,Ludiq.IGraphData&)
// 0x00000063 Ludiq.IGraphElementData Ludiq.GraphData`1::CreateElementData(Ludiq.IGraphElementWithData)
// 0x00000064 System.Void Ludiq.GraphData`1::FreeElementData(Ludiq.IGraphElementWithData)
// 0x00000065 Ludiq.IGraphData Ludiq.GraphData`1::CreateChildGraphData(Ludiq.IGraphParentElement)
// 0x00000066 System.Void Ludiq.GraphData`1::FreeChildGraphData(Ludiq.IGraphParentElement)
// 0x00000067 Ludiq.IGraphNester Ludiq.GraphNest`2::get_nester()
// 0x00000068 System.Void Ludiq.GraphNest`2::set_nester(Ludiq.IGraphNester)
// 0x00000069 Ludiq.GraphSource Ludiq.GraphNest`2::get_source()
// 0x0000006A System.Void Ludiq.GraphNest`2::set_source(Ludiq.GraphSource)
// 0x0000006B TMacro Ludiq.GraphNest`2::get_macro()
// 0x0000006C System.Void Ludiq.GraphNest`2::set_macro(TMacro)
// 0x0000006D TGraph Ludiq.GraphNest`2::get_embed()
// 0x0000006E System.Void Ludiq.GraphNest`2::set_embed(TGraph)
// 0x0000006F TGraph Ludiq.GraphNest`2::get_graph()
// 0x00000070 Ludiq.IGraph Ludiq.GraphNest`2::Ludiq.IGraphNest.get_graph()
// 0x00000071 System.Void Ludiq.GraphNest`2::add_beforeGraphChange(System.Action)
// 0x00000072 System.Void Ludiq.GraphNest`2::remove_beforeGraphChange(System.Action)
// 0x00000073 System.Void Ludiq.GraphNest`2::add_afterGraphChange(System.Action)
// 0x00000074 System.Void Ludiq.GraphNest`2::remove_afterGraphChange(System.Action)
// 0x00000075 System.Void Ludiq.GraphNest`2::BeforeGraphChange()
// 0x00000076 System.Void Ludiq.GraphNest`2::AfterGraphChange()
// 0x00000077 System.Collections.Generic.IEnumerable`1<Ludiq.ISerializationDependency> Ludiq.GraphNest`2::get_deserializationDependencies()
// 0x00000078 System.Collections.Generic.IEnumerable`1<System.Object> Ludiq.GraphNest`2::get_aotStubs()
// 0x00000079 System.Void Ludiq.GraphNest`2::.ctor()
// 0x0000007A System.Void Ludiq.GraphNest`2/<get_deserializationDependencies>d__41::.ctor(System.Int32)
// 0x0000007B System.Void Ludiq.GraphNest`2/<get_deserializationDependencies>d__41::System.IDisposable.Dispose()
// 0x0000007C System.Boolean Ludiq.GraphNest`2/<get_deserializationDependencies>d__41::MoveNext()
// 0x0000007D Ludiq.ISerializationDependency Ludiq.GraphNest`2/<get_deserializationDependencies>d__41::System.Collections.Generic.IEnumerator<Ludiq.ISerializationDependency>.get_Current()
// 0x0000007E System.Void Ludiq.GraphNest`2/<get_deserializationDependencies>d__41::System.Collections.IEnumerator.Reset()
// 0x0000007F System.Object Ludiq.GraphNest`2/<get_deserializationDependencies>d__41::System.Collections.IEnumerator.get_Current()
// 0x00000080 System.Collections.Generic.IEnumerator`1<Ludiq.ISerializationDependency> Ludiq.GraphNest`2/<get_deserializationDependencies>d__41::System.Collections.Generic.IEnumerable<Ludiq.ISerializationDependency>.GetEnumerator()
// 0x00000081 System.Collections.IEnumerator Ludiq.GraphNest`2/<get_deserializationDependencies>d__41::System.Collections.IEnumerable.GetEnumerator()
// 0x00000082 System.Boolean Ludiq.GraphPointer::IsValidRoot(Ludiq.IGraphRoot)
extern void GraphPointer_IsValidRoot_mC93ABE5041BAF865583BC91EFD10264C57A413C2 (void);
// 0x00000083 System.Void Ludiq.GraphPointer::.ctor()
extern void GraphPointer__ctor_mBE645EAFB6D080C0BEFFF95D1106F110B4683F22 (void);
// 0x00000084 System.Void Ludiq.GraphPointer::Initialize(Ludiq.IGraphRoot)
extern void GraphPointer_Initialize_m8921D314537D8ED33874419DEBC037297D41A191 (void);
// 0x00000085 Ludiq.GraphReference Ludiq.GraphPointer::AsReference()
// 0x00000086 System.Void Ludiq.GraphPointer::CopyFrom(Ludiq.GraphPointer)
extern void GraphPointer_CopyFrom_mA5CF477D86FF8762A6F1C7445D9500D2EF72F26E (void);
// 0x00000087 Ludiq.IGraphRoot Ludiq.GraphPointer::get_root()
extern void GraphPointer_get_root_m40374E3DB3AF7F45890867E15B814322172C9444 (void);
// 0x00000088 System.Void Ludiq.GraphPointer::set_root(Ludiq.IGraphRoot)
extern void GraphPointer_set_root_m03A9F9A69A65AC1D3B623CBA5B05B96D9766831F (void);
// 0x00000089 UnityEngine.Object Ludiq.GraphPointer::get_rootObject()
extern void GraphPointer_get_rootObject_m9048A1A97B394B29A87A37E0F6A7EC5DDF8C9F9F (void);
// 0x0000008A Ludiq.IMachine Ludiq.GraphPointer::get_machine()
extern void GraphPointer_get_machine_m2D1A2101988A866B9715B46960FDC404AB198EBC (void);
// 0x0000008B UnityEngine.MonoBehaviour Ludiq.GraphPointer::get_component()
extern void GraphPointer_get_component_m8A3C7AC3773D3FFE1C29B06D5D296DE128CE4CB2 (void);
// 0x0000008C UnityEngine.GameObject Ludiq.GraphPointer::get_gameObject()
extern void GraphPointer_get_gameObject_m16BB23EC0380D57C2019218597394A00FF806F6B (void);
// 0x0000008D System.Void Ludiq.GraphPointer::set_gameObject(UnityEngine.GameObject)
extern void GraphPointer_set_gameObject_mC90622B07FA3767439C4B2A0663A5C63CC246335 (void);
// 0x0000008E UnityEngine.GameObject Ludiq.GraphPointer::get_self()
extern void GraphPointer_get_self_mBF1B91138567D6556FA48A8C1348C56C2EE189CF (void);
// 0x0000008F System.Nullable`1<UnityEngine.SceneManagement.Scene> Ludiq.GraphPointer::get_scene()
extern void GraphPointer_get_scene_m6D404294DDE9F967DC625B77ABDD7526E469D40D (void);
// 0x00000090 UnityEngine.Object Ludiq.GraphPointer::get_serializedObject()
extern void GraphPointer_get_serializedObject_mEC5145BAAECBCB6F93F9FE6257C2F224205A5892 (void);
// 0x00000091 System.Int32 Ludiq.GraphPointer::get_depth()
extern void GraphPointer_get_depth_m5E363E44A84FEE61E58082467745FFE3E7D2529E (void);
// 0x00000092 System.Boolean Ludiq.GraphPointer::get_isRoot()
extern void GraphPointer_get_isRoot_m27738ABD10A4F4FF36E3A6375E42CC62977BF680 (void);
// 0x00000093 System.Boolean Ludiq.GraphPointer::get_isChild()
extern void GraphPointer_get_isChild_m1BAD78156B1C74FCC3FAB5F7F460A21243AA3805 (void);
// 0x00000094 System.Void Ludiq.GraphPointer::EnsureChild()
extern void GraphPointer_EnsureChild_m7C58DA98A951A9446B9755252048F55DFD1DDF2B (void);
// 0x00000095 System.Boolean Ludiq.GraphPointer::IsWithin()
// 0x00000096 System.Void Ludiq.GraphPointer::EnsureWithin()
// 0x00000097 Ludiq.IGraphParent Ludiq.GraphPointer::get_parent()
extern void GraphPointer_get_parent_m06203B974A8A7B2F006191FB3CBE21A983586D3A (void);
// 0x00000098 T Ludiq.GraphPointer::GetParent()
// 0x00000099 Ludiq.IGraphParentElement Ludiq.GraphPointer::get_parentElement()
extern void GraphPointer_get_parentElement_m897D7214308DDC3AE5DA510C0E99A63B9D9785CC (void);
// 0x0000009A Ludiq.IGraph Ludiq.GraphPointer::get_rootGraph()
extern void GraphPointer_get_rootGraph_m85828233DBE442EC6B27B7B1DD50695452E2B07C (void);
// 0x0000009B Ludiq.IGraph Ludiq.GraphPointer::get_graph()
extern void GraphPointer_get_graph_m2D4A325AD6EF768A61123C04DEDEBCBA85058095 (void);
// 0x0000009C Ludiq.IGraphData Ludiq.GraphPointer::get__data()
extern void GraphPointer_get__data_mC51AFD9DC9753B7C4C88EF6D96848E9A14EDF095 (void);
// 0x0000009D System.Void Ludiq.GraphPointer::set__data(Ludiq.IGraphData)
extern void GraphPointer_set__data_m707433FE323FE44A07D09C7C6AD546DC0A1E2570 (void);
// 0x0000009E Ludiq.IGraphData Ludiq.GraphPointer::get_data()
extern void GraphPointer_get_data_mF21CAE107B8D3A53A185B6EE74AD9A795A1D309E (void);
// 0x0000009F Ludiq.IGraphData Ludiq.GraphPointer::get__parentData()
extern void GraphPointer_get__parentData_mC0AF571372FE03CE7A79DAC155A584D4CBDECA3B (void);
// 0x000000A0 System.Boolean Ludiq.GraphPointer::get_hasData()
extern void GraphPointer_get_hasData_m8E0041F4117C4F8E4378CCF32536F95A8A1DB0A2 (void);
// 0x000000A1 System.Void Ludiq.GraphPointer::EnsureDataAvailable()
extern void GraphPointer_EnsureDataAvailable_mD8D7E820DF671815775EB5BE7BDFDAA387C7A3E2 (void);
// 0x000000A2 T Ludiq.GraphPointer::GetGraphData()
// 0x000000A3 T Ludiq.GraphPointer::GetElementData(Ludiq.IGraphElementWithData)
// 0x000000A4 System.Func`2<Ludiq.IGraphRoot,Ludiq.IGraphDebugData> Ludiq.GraphPointer::get_fetchRootDebugDataBinding()
extern void GraphPointer_get_fetchRootDebugDataBinding_mE2FA7BCEEAB1535D4DB9D902C539579B62068B9F (void);
// 0x000000A5 System.Boolean Ludiq.GraphPointer::get_hasDebugData()
extern void GraphPointer_get_hasDebugData_m8521576EA33D10CA3B3AD9F57AB40FB4E75382B3 (void);
// 0x000000A6 System.Void Ludiq.GraphPointer::EnsureDebugDataAvailable()
extern void GraphPointer_EnsureDebugDataAvailable_m7416491AA8942416BF77E14AF035F256CD1BA44A (void);
// 0x000000A7 Ludiq.IGraphDebugData Ludiq.GraphPointer::get__debugData()
extern void GraphPointer_get__debugData_mEE1763D2DE7BC4509D10CB28FCDCE8780E6B32C6 (void);
// 0x000000A8 Ludiq.IGraphDebugData Ludiq.GraphPointer::get_debugData()
extern void GraphPointer_get_debugData_m269442643B7F3B6939D098EFBFEC9E80E55DD643 (void);
// 0x000000A9 T Ludiq.GraphPointer::GetElementDebugData(Ludiq.IGraphElementWithDebugData)
// 0x000000AA System.Boolean Ludiq.GraphPointer::TryEnterParentElement(Ludiq.IGraphParentElement,System.String&,System.Nullable`1<System.Int32>,System.Boolean)
extern void GraphPointer_TryEnterParentElement_mB9102F88BF8CF1211FB1C876EBAE522EC7975DE5 (void);
// 0x000000AB System.Void Ludiq.GraphPointer::EnterParentElement(Ludiq.IGraphParentElement)
extern void GraphPointer_EnterParentElement_m899D7365050FF67FBE389115830150225C3791EF (void);
// 0x000000AC System.Void Ludiq.GraphPointer::EnterValidParentElement(Ludiq.IGraphParentElement)
extern void GraphPointer_EnterValidParentElement_m95711CA9513D3BBA33454A7CB2C8CE3274904D0D (void);
// 0x000000AD System.Void Ludiq.GraphPointer::ExitParentElement()
extern void GraphPointer_ExitParentElement_mCCF0824180D1720A08A302F1781456C623C24992 (void);
// 0x000000AE System.Boolean Ludiq.GraphPointer::get_isValid()
extern void GraphPointer_get_isValid_m28C866D8CF770BA4EE77118B4D01E64E5B86F959 (void);
// 0x000000AF System.Boolean Ludiq.GraphPointer::InstanceEquals(Ludiq.GraphPointer)
extern void GraphPointer_InstanceEquals_mDB62F6F44AC7AEA9F5BE4BB6B488A5116939BF4B (void);
// 0x000000B0 System.Boolean Ludiq.GraphPointer::DefinitionEquals(Ludiq.GraphPointer)
extern void GraphPointer_DefinitionEquals_m03AD763EB66388E13BE5C317D4419218AB88C972 (void);
// 0x000000B1 System.Int32 Ludiq.GraphPointer::ComputeHashCode()
extern void GraphPointer_ComputeHashCode_mC84F82AFBA1D574D3C356D60A20ECB528ED78C50 (void);
// 0x000000B2 System.String Ludiq.GraphPointer::ToString()
extern void GraphPointer_ToString_mE7E47F38B5EEF37509BEBD398A20E1B7C2EFE5D5 (void);
// 0x000000B3 System.Void Ludiq.GraphPointerException::.ctor(System.String,Ludiq.GraphPointer)
extern void GraphPointerException__ctor_m37F8D13D2B113E5CC45C709336EA0CAB9403EFAA (void);
// 0x000000B4 System.Void Ludiq.GraphReference::.cctor()
extern void GraphReference__cctor_mBB5B5863E5B9061C31FFCA2457170D5566911F20 (void);
// 0x000000B5 System.Void Ludiq.GraphReference::.ctor()
extern void GraphReference__ctor_m7B0A9609AEA822AC5553A495668015231EB1815F (void);
// 0x000000B6 Ludiq.GraphReference Ludiq.GraphReference::New(Ludiq.IGraphRoot,System.Boolean)
extern void GraphReference_New_m363C164C76769BA165271BA65F0FDFFB22F76028 (void);
// 0x000000B7 Ludiq.GraphReference Ludiq.GraphReference::New(Ludiq.GraphPointer)
extern void GraphReference_New_mCCFF5292E29EA189A1DEA8CAEB3DC6ED91A499F3 (void);
// 0x000000B8 System.Void Ludiq.GraphReference::CopyFrom(Ludiq.GraphPointer)
extern void GraphReference_CopyFrom_m4793E06BCB813508B947559D28C33DD2DDE2A902 (void);
// 0x000000B9 Ludiq.GraphReference Ludiq.GraphReference::Clone()
extern void GraphReference_Clone_mA03B58B33DB6E99AF4DD06EADA2ED69E55DD0A5E (void);
// 0x000000BA Ludiq.GraphReference Ludiq.GraphReference::AsReference()
extern void GraphReference_AsReference_m7DDF419206F124F2261FEC7F432B5F1D51A94C39 (void);
// 0x000000BB Ludiq.GraphStack Ludiq.GraphReference::ToStackPooled()
extern void GraphReference_ToStackPooled_mCB12E7C5804F8F255319FF59B6087F3E521774BF (void);
// 0x000000BC System.Void Ludiq.GraphReference::CreateGraphData()
extern void GraphReference_CreateGraphData_mFC4F0B96DEC64670A612A9A31120FB9523791EBB (void);
// 0x000000BD System.Void Ludiq.GraphReference::FreeGraphData()
extern void GraphReference_FreeGraphData_m230C340B862DBDD581549D8542B51DFCBACBA952 (void);
// 0x000000BE System.Boolean Ludiq.GraphReference::Equals(System.Object)
extern void GraphReference_Equals_m8B881E12393ECF87F0D6285AECA821C31A9B02B9 (void);
// 0x000000BF System.Void Ludiq.GraphReference::Hash()
extern void GraphReference_Hash_m4007CED7CB4F9BC51586FF4E92DA8B95A4F39999 (void);
// 0x000000C0 System.Int32 Ludiq.GraphReference::GetHashCode()
extern void GraphReference_GetHashCode_m2494A38938B20A097A4ACABD1DFD8258E18115F6 (void);
// 0x000000C1 System.Boolean Ludiq.GraphReference::op_Equality(Ludiq.GraphReference,Ludiq.GraphReference)
extern void GraphReference_op_Equality_mB3F4CCB7F3C994AC23F0C48E9733A5A735973D8B (void);
// 0x000000C2 System.Boolean Ludiq.GraphReference::op_Inequality(Ludiq.GraphReference,Ludiq.GraphReference)
extern void GraphReference_op_Inequality_mD2003CF8F49E93D9541DE3BD4CA5895CF3A26C82 (void);
// 0x000000C3 Ludiq.GraphReference Ludiq.GraphReference::ParentReference(System.Boolean)
extern void GraphReference_ParentReference_mECDED57DD7852AC6B8A67AA3881541E9CF098B4B (void);
// 0x000000C4 Ludiq.GraphReference Ludiq.GraphReference::ChildReference(Ludiq.IGraphParentElement,System.Boolean,System.Nullable`1<System.Int32>)
extern void GraphReference_ChildReference_m46DE9F688B8D2B2559F41D18E0FFA43A14B5648F (void);
// 0x000000C5 Ludiq.GraphReference Ludiq.GraphReference::Intern(Ludiq.GraphPointer)
extern void GraphReference_Intern_m0BF979D12673ED0C6D9DF8B9C8F780061B57391B (void);
// 0x000000C6 System.Void Ludiq.GraphReference::FreeInvalidInterns()
extern void GraphReference_FreeInvalidInterns_m68A28B4E9E9A29D1AACB8B1BA959792F425AF58C (void);
// 0x000000C7 System.Void Ludiq.GraphsExceptionUtility::SetException(Ludiq.IGraphElementWithDebugData,Ludiq.GraphPointer,System.Exception)
extern void GraphsExceptionUtility_SetException_m9CB1CF4FB71BA3BC7C9368030B41DA458DA09DB8 (void);
// 0x000000C8 System.Void Ludiq.GraphsExceptionUtility::HandleException(Ludiq.IGraphElementWithDebugData,Ludiq.GraphPointer,System.Exception)
extern void GraphsExceptionUtility_HandleException_m32C1DF2B8237539BC17957FE5620367FB4ADC77D (void);
// 0x000000C9 System.Boolean Ludiq.GraphsExceptionUtility::HandledIn(System.Exception,Ludiq.GraphReference)
extern void GraphsExceptionUtility_HandledIn_m5D68F8D100695113F5F14E61C80E357C7F3BE0A7 (void);
// 0x000000CA System.Void Ludiq.GraphStack::.ctor()
extern void GraphStack__ctor_m0FE15FA50C3B976F6F252D95CA240CB8786E2F4B (void);
// 0x000000CB Ludiq.GraphStack Ludiq.GraphStack::New(Ludiq.GraphPointer)
extern void GraphStack_New_m14E2E604A2DC60AB7BCF2779FE499A2C1C5E6935 (void);
// 0x000000CC Ludiq.GraphStack Ludiq.GraphStack::Clone()
extern void GraphStack_Clone_m7031B78685BE832C2FEAA7ED73775ED7D7FEF4E7 (void);
// 0x000000CD System.Void Ludiq.GraphStack::Dispose()
extern void GraphStack_Dispose_m387A82E8F15F6B68AECE1B005B5066AF6B288699 (void);
// 0x000000CE System.Void Ludiq.GraphStack::Ludiq.IPoolable.New()
extern void GraphStack_Ludiq_IPoolable_New_m4284743F88E594CC758A56A5CB0190AE7A14927A (void);
// 0x000000CF System.Void Ludiq.GraphStack::Ludiq.IPoolable.Free()
extern void GraphStack_Ludiq_IPoolable_Free_mFC53D426C1F87C3F555F1A4F17C2D8C498E2051E (void);
// 0x000000D0 Ludiq.GraphReference Ludiq.GraphStack::AsReference()
extern void GraphStack_AsReference_mEFA2922E3D66C097C74EDC5A0A6926F04BF31BE2 (void);
// 0x000000D1 Ludiq.GraphReference Ludiq.GraphStack::ToReference()
extern void GraphStack_ToReference_m333FE476C1A25077ACDEDCFBFE828900A862CB96 (void);
// 0x000000D2 System.Void Ludiq.GraphStack::EnterParentElement(Ludiq.IGraphParentElement)
extern void GraphStack_EnterParentElement_m5625A249B305C65CDAB608E7BAC6B01F2D2C991D (void);
// 0x000000D3 System.Boolean Ludiq.GraphStack::TryEnterParentElement(Ludiq.IGraphParentElement)
extern void GraphStack_TryEnterParentElement_m47671755C5D9240FC5F696895D2AB9202115B6C8 (void);
// 0x000000D4 System.Boolean Ludiq.GraphStack::TryEnterParentElementUnsafe(Ludiq.IGraphParentElement)
extern void GraphStack_TryEnterParentElementUnsafe_m80774FD678E7FF552DF0845958FA7A24BE48559B (void);
// 0x000000D5 System.Void Ludiq.GraphStack::ExitParentElement()
extern void GraphStack_ExitParentElement_mDF4C5C99BF313BA43ADD934CFACCE74B20C5D7D2 (void);
// 0x000000D6 System.Void Ludiq.GraphStack/<>c::.cctor()
extern void U3CU3Ec__cctor_mF097C81FCC2819BF8636D46595D91617C84EC2C7 (void);
// 0x000000D7 System.Void Ludiq.GraphStack/<>c::.ctor()
extern void U3CU3Ec__ctor_m196892E2D2EC7F05DC646ED58486298F6030FD6E (void);
// 0x000000D8 Ludiq.GraphStack Ludiq.GraphStack/<>c::<New>b__3_0()
extern void U3CU3Ec_U3CNewU3Eb__3_0_m67FC5762AC9B49F84BEA03C83EA3E1D53D917372 (void);
// 0x000000D9 Ludiq.MergedGraphElementCollection Ludiq.IGraph::get_elements()
// 0x000000DA Ludiq.IGraphData Ludiq.IGraph::CreateData()
// 0x000000DB System.Void Ludiq.IGraph::Instantiate(Ludiq.GraphReference)
// 0x000000DC System.Void Ludiq.IGraph::Uninstantiate(Ludiq.GraphReference)
// 0x000000DD Ludiq.IGraph Ludiq.IGraphElement::get_graph()
// 0x000000DE System.Void Ludiq.IGraphElement::set_graph(Ludiq.IGraph)
// 0x000000DF System.Boolean Ludiq.IGraphElement::HandleDependencies()
// 0x000000E0 System.Int32 Ludiq.IGraphElement::get_dependencyOrder()
// 0x000000E1 System.Guid Ludiq.IGraphElement::get_guid()
// 0x000000E2 System.Void Ludiq.IGraphElement::Instantiate(Ludiq.GraphReference)
// 0x000000E3 System.Void Ludiq.IGraphElement::Uninstantiate(Ludiq.GraphReference)
// 0x000000E4 System.Collections.Generic.IEnumerable`1<Ludiq.ISerializationDependency> Ludiq.IGraphElement::get_deserializationDependencies()
// 0x000000E5 System.Guid Ludiq.GraphElement`1::get_guid()
// 0x000000E6 System.Void Ludiq.GraphElement`1::Instantiate(Ludiq.GraphReference)
// 0x000000E7 System.Void Ludiq.GraphElement`1::Uninstantiate(Ludiq.GraphReference)
// 0x000000E8 System.Void Ludiq.GraphElement`1::BeforeAdd()
// 0x000000E9 System.Void Ludiq.GraphElement`1::AfterAdd()
// 0x000000EA System.Void Ludiq.GraphElement`1::BeforeRemove()
// 0x000000EB System.Void Ludiq.GraphElement`1::AfterRemove()
// 0x000000EC System.Void Ludiq.GraphElement`1::Dispose()
// 0x000000ED System.Void Ludiq.GraphElement`1::InstantiateNest()
// 0x000000EE System.Void Ludiq.GraphElement`1::UninstantiateNest()
// 0x000000EF System.Int32 Ludiq.GraphElement`1::get_dependencyOrder()
// 0x000000F0 System.Boolean Ludiq.GraphElement`1::HandleDependencies()
// 0x000000F1 TGraph Ludiq.GraphElement`1::get_graph()
// 0x000000F2 System.Void Ludiq.GraphElement`1::set_graph(TGraph)
// 0x000000F3 Ludiq.IGraph Ludiq.GraphElement`1::Ludiq.IGraphElement.get_graph()
// 0x000000F4 System.Void Ludiq.GraphElement`1::Ludiq.IGraphElement.set_graph(Ludiq.IGraph)
// 0x000000F5 Ludiq.IGraph Ludiq.GraphElement`1::Ludiq.IGraphItem.get_graph()
// 0x000000F6 System.Collections.Generic.IEnumerable`1<Ludiq.ISerializationDependency> Ludiq.GraphElement`1::get_deserializationDependencies()
// 0x000000F7 System.Collections.Generic.IEnumerable`1<System.Object> Ludiq.GraphElement`1::get_aotStubs()
// 0x000000F8 System.Void Ludiq.GraphElement`1::Prewarm()
// 0x000000F9 System.Void Ludiq.GraphElement`1::CopyFrom(Ludiq.GraphElement`1<TGraph>)
// 0x000000FA System.String Ludiq.GraphElement`1::ToString()
// 0x000000FB System.Void Ludiq.GraphElement`1::.ctor()
// 0x000000FC Ludiq.IGraph Ludiq.IGraphItem::get_graph()
// 0x000000FD System.Boolean Ludiq.IGraphData::TryGetElementData(Ludiq.IGraphElementWithData,Ludiq.IGraphElementData&)
// 0x000000FE System.Boolean Ludiq.IGraphData::TryGetChildGraphData(Ludiq.IGraphParentElement,Ludiq.IGraphData&)
// 0x000000FF Ludiq.IGraphElementData Ludiq.IGraphData::CreateElementData(Ludiq.IGraphElementWithData)
// 0x00000100 System.Void Ludiq.IGraphData::FreeElementData(Ludiq.IGraphElementWithData)
// 0x00000101 Ludiq.IGraphData Ludiq.IGraphData::CreateChildGraphData(Ludiq.IGraphParentElement)
// 0x00000102 System.Void Ludiq.IGraphData::FreeChildGraphData(Ludiq.IGraphParentElement)
// 0x00000103 Ludiq.IGraphElementDebugData Ludiq.IGraphDebugData::GetOrCreateElementData(Ludiq.IGraphElementWithDebugData)
// 0x00000104 Ludiq.IGraphDebugData Ludiq.IGraphDebugData::GetOrCreateChildGraphData(Ludiq.IGraphParentElement)
// 0x00000105 Ludiq.IGraphElementData Ludiq.IGraphElementWithData::CreateData()
// 0x00000106 System.Void Ludiq.IGraphElementDebugData::set_runtimeException(System.Exception)
// 0x00000107 Ludiq.IGraph Ludiq.IGraphNest::get_graph()
// 0x00000108 Ludiq.IGraphNest Ludiq.IGraphNester::get_nest()
// 0x00000109 System.Void Ludiq.IGraphNester::InstantiateNest()
// 0x0000010A System.Void Ludiq.IGraphNester::UninstantiateNest()
// 0x0000010B Ludiq.IGraph Ludiq.IGraphParent::get_childGraph()
// 0x0000010C System.Boolean Ludiq.IGraphParent::get_isSerializationRoot()
// 0x0000010D UnityEngine.Object Ludiq.IGraphParent::get_serializedObject()
// 0x0000010E Ludiq.IGraph Ludiq.IGraphParent::DefaultGraph()
// 0x0000010F Ludiq.IGraphData Ludiq.IMachine::get_graphData()
// 0x00000110 System.Void Ludiq.IMachine::set_graphData(Ludiq.IGraphData)
// 0x00000111 UnityEngine.GameObject Ludiq.IMachine::get_threadSafeGameObject()
// 0x00000112 System.Void Ludiq.Machine`2::.ctor()
// 0x00000113 Ludiq.GraphNest`2<TGraph,TMacro> Ludiq.Machine`2::get_nest()
// 0x00000114 System.Void Ludiq.Machine`2::set_nest(Ludiq.GraphNest`2<TGraph,TMacro>)
// 0x00000115 Ludiq.IGraphNest Ludiq.Machine`2::Ludiq.IGraphNester.get_nest()
// 0x00000116 UnityEngine.GameObject Ludiq.Machine`2::Ludiq.IMachine.get_threadSafeGameObject()
// 0x00000117 Ludiq.GraphReference Ludiq.Machine`2::get_reference()
// 0x00000118 System.Boolean Ludiq.Machine`2::get_hasGraph()
// 0x00000119 TGraph Ludiq.Machine`2::get_graph()
// 0x0000011A Ludiq.IGraphData Ludiq.Machine`2::get_graphData()
// 0x0000011B System.Void Ludiq.Machine`2::set_graphData(Ludiq.IGraphData)
// 0x0000011C System.Boolean Ludiq.Machine`2::Ludiq.IGraphParent.get_isSerializationRoot()
// 0x0000011D UnityEngine.Object Ludiq.Machine`2::Ludiq.IGraphParent.get_serializedObject()
// 0x0000011E Ludiq.IGraph Ludiq.Machine`2::Ludiq.IGraphParent.get_childGraph()
// 0x0000011F System.Collections.Generic.IEnumerable`1<System.Object> Ludiq.Machine`2::Ludiq.IAotStubbable.get_aotStubs()
// 0x00000120 System.Boolean Ludiq.Machine`2::get_isDescriptionValid()
// 0x00000121 System.Void Ludiq.Machine`2::set_isDescriptionValid(System.Boolean)
// 0x00000122 System.Void Ludiq.Machine`2::Awake()
// 0x00000123 System.Void Ludiq.Machine`2::OnEnable()
// 0x00000124 System.Void Ludiq.Machine`2::OnInstantiateWhileEnabled()
// 0x00000125 System.Void Ludiq.Machine`2::OnUninstantiateWhileEnabled()
// 0x00000126 System.Void Ludiq.Machine`2::OnDisable()
// 0x00000127 System.Void Ludiq.Machine`2::OnDestroy()
// 0x00000128 System.Void Ludiq.Machine`2::OnValidate()
// 0x00000129 System.Void Ludiq.Machine`2::CacheReference()
// 0x0000012A System.Void Ludiq.Machine`2::ClearCachedReference()
// 0x0000012B System.Void Ludiq.Machine`2::InstantiateNest()
// 0x0000012C System.Void Ludiq.Machine`2::UninstantiateNest()
// 0x0000012D System.Void Ludiq.Machine`2::TriggerAnimationEvent(UnityEngine.AnimationEvent)
// 0x0000012E System.Void Ludiq.Machine`2::TriggerUnityEvent(System.String)
// 0x0000012F TGraph Ludiq.Machine`2::DefaultGraph()
// 0x00000130 Ludiq.IGraph Ludiq.Machine`2::Ludiq.IGraphParent.DefaultGraph()
// 0x00000131 Ludiq.IGraph Ludiq.IMacro::get_graph()
// 0x00000132 System.Void Ludiq.IMacro::set_graph(Ludiq.IGraph)
// 0x00000133 TGraph Ludiq.Macro`1::get_graph()
// 0x00000134 System.Void Ludiq.Macro`1::set_graph(TGraph)
// 0x00000135 Ludiq.IGraph Ludiq.Macro`1::Ludiq.IMacro.get_graph()
// 0x00000136 System.Void Ludiq.Macro`1::Ludiq.IMacro.set_graph(Ludiq.IGraph)
// 0x00000137 Ludiq.IGraph Ludiq.Macro`1::Ludiq.IGraphParent.get_childGraph()
// 0x00000138 System.Collections.Generic.IEnumerable`1<System.Object> Ludiq.Macro`1::get_aotStubs()
// 0x00000139 System.Boolean Ludiq.Macro`1::Ludiq.IGraphParent.get_isSerializationRoot()
// 0x0000013A UnityEngine.Object Ludiq.Macro`1::Ludiq.IGraphParent.get_serializedObject()
// 0x0000013B System.Boolean Ludiq.Macro`1::get_isDescriptionValid()
// 0x0000013C System.Void Ludiq.Macro`1::set_isDescriptionValid(System.Boolean)
// 0x0000013D System.Void Ludiq.Macro`1::OnBeforeDeserialize()
// 0x0000013E System.Void Ludiq.Macro`1::OnAfterDeserialize()
// 0x0000013F TGraph Ludiq.Macro`1::DefaultGraph()
// 0x00000140 Ludiq.IGraph Ludiq.Macro`1::Ludiq.IGraphParent.DefaultGraph()
// 0x00000141 System.Void Ludiq.Macro`1::OnEnable()
// 0x00000142 System.Void Ludiq.Macro`1::OnDisable()
// 0x00000143 System.Void Ludiq.Macro`1::.ctor()
// 0x00000144 System.Void Ludiq.GraphGroup::.cctor()
extern void GraphGroup__cctor_m105DFF01D1CACC4DC8B3A1D83C2299B64EB55C99 (void);
// 0x00000145 System.Void Ludiq.MergedGraphElementCollection::add_ItemAdded(System.Action`1<Ludiq.IGraphElement>)
extern void MergedGraphElementCollection_add_ItemAdded_m2112CD74EE642C4448942408A38592C166A82F34 (void);
// 0x00000146 System.Void Ludiq.MergedGraphElementCollection::remove_ItemAdded(System.Action`1<Ludiq.IGraphElement>)
extern void MergedGraphElementCollection_remove_ItemAdded_m7235176C4C247BCA062CF7478E7B57AA7B8123D3 (void);
// 0x00000147 System.Void Ludiq.MergedGraphElementCollection::add_ItemRemoved(System.Action`1<Ludiq.IGraphElement>)
extern void MergedGraphElementCollection_add_ItemRemoved_m6A2D1A56123A01A85D134458048BA396F5318851 (void);
// 0x00000148 System.Void Ludiq.MergedGraphElementCollection::remove_ItemRemoved(System.Action`1<Ludiq.IGraphElement>)
extern void MergedGraphElementCollection_remove_ItemRemoved_m29B23A07D536B641D5E3F682790C8BCFA03A28EC (void);
// 0x00000149 System.Void Ludiq.MergedGraphElementCollection::add_CollectionChanged(System.Action)
extern void MergedGraphElementCollection_add_CollectionChanged_mBB5B991F953A14FBD6C0332052B6AEC67B0406B9 (void);
// 0x0000014A System.Void Ludiq.MergedGraphElementCollection::remove_CollectionChanged(System.Action)
extern void MergedGraphElementCollection_remove_CollectionChanged_m6EDBE97AC9F03C67AE472BBE106AF742DC479754 (void);
// 0x0000014B System.Void Ludiq.MergedGraphElementCollection::Include(Ludiq.IKeyedCollection`2<System.Guid,TSubItem>)
// 0x0000014C System.Void Ludiq.MergedGraphElementCollection::.ctor()
extern void MergedGraphElementCollection__ctor_m37B54B8BE1E6412B02DB453D2DF347F81BE0E9F5 (void);
// 0x0000014D System.Void Ludiq.MergedGraphElementCollection::<Include>b__9_0(TSubItem)
// 0x0000014E System.Void Ludiq.MergedGraphElementCollection::<Include>b__9_1(TSubItem)
// 0x0000014F System.Void Ludiq.MergedGraphElementCollection::<Include>b__9_2()
static Il2CppMethodPointer s_methodPointers[335] = 
{
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	InvalidConnectionException__ctor_m86E7E705D6D743EC889B9DC029519356A9959313,
	InvalidConnectionException__ctor_m79421FA5BA58D7D3BA399956FC9DD9DA47B8BB2A,
	GraphInstances_Instantiate_mBC31DB722EE7E9EC02A45642024A22C0C7695CC7,
	GraphInstances_Uninstantiate_mF863E6AE4EC4FAD8D64BC18F1F1A723EB1C72D50,
	GraphInstances_OfPooled_m9E532550FEF24E877CD47E48A3884E830FA1CEB4,
	GraphInstances_ChildrenOfPooled_m9A07D540940AA5B69093ED48E2C8293687409CC9,
	GraphInstances__cctor_m79D8D1ABDE65010BC00A0430B7F3DA38F9734420,
	Graph__ctor_m6F72F00F374810EB4024E58D29780BD8055CF916,
	Graph_ToString_mF78E5DC8E7129A5359497307829421DB86D0CC42,
	NULL,
	Graph_Instantiate_mAD543BF2706C3897117259408FD5501A5ABEAA3B,
	Graph_Uninstantiate_m1260B45C45E2C967A4DF3402BDB257A0A4D9F7C1,
	Graph_get_elements_m36E0480F07EB0370BE8DBC5BAB4E7E626562B5F1,
	Graph_get_title_mA50AF2EE564274FCDD08A5076719D2618B5F461E,
	Graph_get_deserializationDependencies_mDA92D8D77F25A6CCE1EBD6EB81771A1B366CB3C2,
	Graph_OnBeforeSerialize_m7D416CA5137AD12973E15DE52CC17E7253FC39FC,
	Graph_OnAfterDeserialize_m0BB30DC6E1FA13E79BD28CA88ED6644561E79AFC,
	Graph_OnAfterDependenciesDeserialized_mC7705F29E805E8C7310B0C3FEA7E8BD1AE0A1861,
	Graph_get_aotStubs_mA24A6C5D52A82A0979CA421BF782C54A22C63F44,
	Graph_Prewarm_m9B895DE4859AD5123E5CD3CD06C04080B114C68B,
	Graph_Dispose_m099682F7202675BB39DAFDDD1F413A7F4456A8CA,
	U3CU3Ec__cctor_m4C4D54CB9534950C0B32DD17ED6C5E01CAF2E68D,
	U3CU3Ec__ctor_mA26BEA21945EECDE80518D03CC7BBEB8F24A1467,
	U3CU3Ec_U3Cget_deserializationDependenciesU3Eb__27_0_mD10D29836B1806822144384CDFC1E23FA017BA53,
	U3CU3Ec_U3COnAfterDependenciesDeserializedU3Eb__30_0_mBBDCA42BAC854CBA79FB3CCFAAFE980BFE6B588A,
	U3CU3Ec_U3Cget_aotStubsU3Eb__32_0_m8BA8FB5E1E2F9F9647E2F0CB328CF014891049E9,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	GraphPointer_IsValidRoot_mC93ABE5041BAF865583BC91EFD10264C57A413C2,
	GraphPointer__ctor_mBE645EAFB6D080C0BEFFF95D1106F110B4683F22,
	GraphPointer_Initialize_m8921D314537D8ED33874419DEBC037297D41A191,
	NULL,
	GraphPointer_CopyFrom_mA5CF477D86FF8762A6F1C7445D9500D2EF72F26E,
	GraphPointer_get_root_m40374E3DB3AF7F45890867E15B814322172C9444,
	GraphPointer_set_root_m03A9F9A69A65AC1D3B623CBA5B05B96D9766831F,
	GraphPointer_get_rootObject_m9048A1A97B394B29A87A37E0F6A7EC5DDF8C9F9F,
	GraphPointer_get_machine_m2D1A2101988A866B9715B46960FDC404AB198EBC,
	GraphPointer_get_component_m8A3C7AC3773D3FFE1C29B06D5D296DE128CE4CB2,
	GraphPointer_get_gameObject_m16BB23EC0380D57C2019218597394A00FF806F6B,
	GraphPointer_set_gameObject_mC90622B07FA3767439C4B2A0663A5C63CC246335,
	GraphPointer_get_self_mBF1B91138567D6556FA48A8C1348C56C2EE189CF,
	GraphPointer_get_scene_m6D404294DDE9F967DC625B77ABDD7526E469D40D,
	GraphPointer_get_serializedObject_mEC5145BAAECBCB6F93F9FE6257C2F224205A5892,
	GraphPointer_get_depth_m5E363E44A84FEE61E58082467745FFE3E7D2529E,
	GraphPointer_get_isRoot_m27738ABD10A4F4FF36E3A6375E42CC62977BF680,
	GraphPointer_get_isChild_m1BAD78156B1C74FCC3FAB5F7F460A21243AA3805,
	GraphPointer_EnsureChild_m7C58DA98A951A9446B9755252048F55DFD1DDF2B,
	NULL,
	NULL,
	GraphPointer_get_parent_m06203B974A8A7B2F006191FB3CBE21A983586D3A,
	NULL,
	GraphPointer_get_parentElement_m897D7214308DDC3AE5DA510C0E99A63B9D9785CC,
	GraphPointer_get_rootGraph_m85828233DBE442EC6B27B7B1DD50695452E2B07C,
	GraphPointer_get_graph_m2D4A325AD6EF768A61123C04DEDEBCBA85058095,
	GraphPointer_get__data_mC51AFD9DC9753B7C4C88EF6D96848E9A14EDF095,
	GraphPointer_set__data_m707433FE323FE44A07D09C7C6AD546DC0A1E2570,
	GraphPointer_get_data_mF21CAE107B8D3A53A185B6EE74AD9A795A1D309E,
	GraphPointer_get__parentData_mC0AF571372FE03CE7A79DAC155A584D4CBDECA3B,
	GraphPointer_get_hasData_m8E0041F4117C4F8E4378CCF32536F95A8A1DB0A2,
	GraphPointer_EnsureDataAvailable_mD8D7E820DF671815775EB5BE7BDFDAA387C7A3E2,
	NULL,
	NULL,
	GraphPointer_get_fetchRootDebugDataBinding_mE2FA7BCEEAB1535D4DB9D902C539579B62068B9F,
	GraphPointer_get_hasDebugData_m8521576EA33D10CA3B3AD9F57AB40FB4E75382B3,
	GraphPointer_EnsureDebugDataAvailable_m7416491AA8942416BF77E14AF035F256CD1BA44A,
	GraphPointer_get__debugData_mEE1763D2DE7BC4509D10CB28FCDCE8780E6B32C6,
	GraphPointer_get_debugData_m269442643B7F3B6939D098EFBFEC9E80E55DD643,
	NULL,
	GraphPointer_TryEnterParentElement_mB9102F88BF8CF1211FB1C876EBAE522EC7975DE5,
	GraphPointer_EnterParentElement_m899D7365050FF67FBE389115830150225C3791EF,
	GraphPointer_EnterValidParentElement_m95711CA9513D3BBA33454A7CB2C8CE3274904D0D,
	GraphPointer_ExitParentElement_mCCF0824180D1720A08A302F1781456C623C24992,
	GraphPointer_get_isValid_m28C866D8CF770BA4EE77118B4D01E64E5B86F959,
	GraphPointer_InstanceEquals_mDB62F6F44AC7AEA9F5BE4BB6B488A5116939BF4B,
	GraphPointer_DefinitionEquals_m03AD763EB66388E13BE5C317D4419218AB88C972,
	GraphPointer_ComputeHashCode_mC84F82AFBA1D574D3C356D60A20ECB528ED78C50,
	GraphPointer_ToString_mE7E47F38B5EEF37509BEBD398A20E1B7C2EFE5D5,
	GraphPointerException__ctor_m37F8D13D2B113E5CC45C709336EA0CAB9403EFAA,
	GraphReference__cctor_mBB5B5863E5B9061C31FFCA2457170D5566911F20,
	GraphReference__ctor_m7B0A9609AEA822AC5553A495668015231EB1815F,
	GraphReference_New_m363C164C76769BA165271BA65F0FDFFB22F76028,
	GraphReference_New_mCCFF5292E29EA189A1DEA8CAEB3DC6ED91A499F3,
	GraphReference_CopyFrom_m4793E06BCB813508B947559D28C33DD2DDE2A902,
	GraphReference_Clone_mA03B58B33DB6E99AF4DD06EADA2ED69E55DD0A5E,
	GraphReference_AsReference_m7DDF419206F124F2261FEC7F432B5F1D51A94C39,
	GraphReference_ToStackPooled_mCB12E7C5804F8F255319FF59B6087F3E521774BF,
	GraphReference_CreateGraphData_mFC4F0B96DEC64670A612A9A31120FB9523791EBB,
	GraphReference_FreeGraphData_m230C340B862DBDD581549D8542B51DFCBACBA952,
	GraphReference_Equals_m8B881E12393ECF87F0D6285AECA821C31A9B02B9,
	GraphReference_Hash_m4007CED7CB4F9BC51586FF4E92DA8B95A4F39999,
	GraphReference_GetHashCode_m2494A38938B20A097A4ACABD1DFD8258E18115F6,
	GraphReference_op_Equality_mB3F4CCB7F3C994AC23F0C48E9733A5A735973D8B,
	GraphReference_op_Inequality_mD2003CF8F49E93D9541DE3BD4CA5895CF3A26C82,
	GraphReference_ParentReference_mECDED57DD7852AC6B8A67AA3881541E9CF098B4B,
	GraphReference_ChildReference_m46DE9F688B8D2B2559F41D18E0FFA43A14B5648F,
	GraphReference_Intern_m0BF979D12673ED0C6D9DF8B9C8F780061B57391B,
	GraphReference_FreeInvalidInterns_m68A28B4E9E9A29D1AACB8B1BA959792F425AF58C,
	GraphsExceptionUtility_SetException_m9CB1CF4FB71BA3BC7C9368030B41DA458DA09DB8,
	GraphsExceptionUtility_HandleException_m32C1DF2B8237539BC17957FE5620367FB4ADC77D,
	GraphsExceptionUtility_HandledIn_m5D68F8D100695113F5F14E61C80E357C7F3BE0A7,
	GraphStack__ctor_m0FE15FA50C3B976F6F252D95CA240CB8786E2F4B,
	GraphStack_New_m14E2E604A2DC60AB7BCF2779FE499A2C1C5E6935,
	GraphStack_Clone_m7031B78685BE832C2FEAA7ED73775ED7D7FEF4E7,
	GraphStack_Dispose_m387A82E8F15F6B68AECE1B005B5066AF6B288699,
	GraphStack_Ludiq_IPoolable_New_m4284743F88E594CC758A56A5CB0190AE7A14927A,
	GraphStack_Ludiq_IPoolable_Free_mFC53D426C1F87C3F555F1A4F17C2D8C498E2051E,
	GraphStack_AsReference_mEFA2922E3D66C097C74EDC5A0A6926F04BF31BE2,
	GraphStack_ToReference_m333FE476C1A25077ACDEDCFBFE828900A862CB96,
	GraphStack_EnterParentElement_m5625A249B305C65CDAB608E7BAC6B01F2D2C991D,
	GraphStack_TryEnterParentElement_m47671755C5D9240FC5F696895D2AB9202115B6C8,
	GraphStack_TryEnterParentElementUnsafe_m80774FD678E7FF552DF0845958FA7A24BE48559B,
	GraphStack_ExitParentElement_mDF4C5C99BF313BA43ADD934CFACCE74B20C5D7D2,
	U3CU3Ec__cctor_mF097C81FCC2819BF8636D46595D91617C84EC2C7,
	U3CU3Ec__ctor_m196892E2D2EC7F05DC646ED58486298F6030FD6E,
	U3CU3Ec_U3CNewU3Eb__3_0_m67FC5762AC9B49F84BEA03C83EA3E1D53D917372,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	GraphGroup__cctor_m105DFF01D1CACC4DC8B3A1D83C2299B64EB55C99,
	MergedGraphElementCollection_add_ItemAdded_m2112CD74EE642C4448942408A38592C166A82F34,
	MergedGraphElementCollection_remove_ItemAdded_m7235176C4C247BCA062CF7478E7B57AA7B8123D3,
	MergedGraphElementCollection_add_ItemRemoved_m6A2D1A56123A01A85D134458048BA396F5318851,
	MergedGraphElementCollection_remove_ItemRemoved_m29B23A07D536B641D5E3F682790C8BCFA03A28EC,
	MergedGraphElementCollection_add_CollectionChanged_mBB5B991F953A14FBD6C0332052B6AEC67B0406B9,
	MergedGraphElementCollection_remove_CollectionChanged_m6EDBE97AC9F03C67AE472BBE106AF742DC479754,
	NULL,
	MergedGraphElementCollection__ctor_m37B54B8BE1E6412B02DB453D2DF347F81BE0E9F5,
	NULL,
	NULL,
	NULL,
};
static const int32_t s_InvokerIndices[335] = 
{
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	3247,
	2616,
	4942,
	4942,
	4830,
	4830,
	5017,
	3247,
	3164,
	3164,
	2616,
	2616,
	3164,
	3164,
	3164,
	3247,
	3247,
	3247,
	3164,
	3247,
	3247,
	5017,
	3247,
	1966,
	871,
	1966,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	4885,
	3247,
	2616,
	3164,
	2616,
	3164,
	2616,
	3164,
	3164,
	3164,
	3164,
	2616,
	3164,
	3071,
	3164,
	3144,
	3202,
	3202,
	3247,
	-1,
	-1,
	3164,
	-1,
	3164,
	3164,
	3164,
	3164,
	2616,
	3164,
	3164,
	3202,
	3247,
	-1,
	-1,
	4989,
	3202,
	3247,
	3164,
	3164,
	-1,
	414,
	2616,
	2616,
	3247,
	3202,
	2233,
	2233,
	3144,
	3164,
	1452,
	5017,
	3247,
	4349,
	4830,
	2616,
	3164,
	3164,
	3164,
	3247,
	3247,
	2233,
	3247,
	3144,
	4449,
	4449,
	1968,
	621,
	4830,
	5017,
	4192,
	4192,
	4449,
	3247,
	4830,
	3164,
	3247,
	3247,
	3247,
	3164,
	3164,
	2616,
	2233,
	2233,
	3247,
	5017,
	3247,
	3164,
	3164,
	3164,
	2616,
	2616,
	3164,
	2616,
	3202,
	3144,
	3138,
	2616,
	2616,
	3164,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	3164,
	1055,
	1055,
	1966,
	2616,
	1966,
	2616,
	1966,
	1966,
	3164,
	2616,
	3164,
	3164,
	3247,
	3247,
	3164,
	3202,
	3164,
	3164,
	3164,
	2616,
	3164,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	3164,
	2616,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	5017,
	2616,
	2616,
	2616,
	2616,
	2616,
	2616,
	-1,
	3247,
	-1,
	-1,
	-1,
};
static const Il2CppTokenRangePair s_rgctxIndices[20] = 
{
	{ 0x02000002, { 0, 4 } },
	{ 0x02000003, { 4, 48 } },
	{ 0x02000004, { 52, 21 } },
	{ 0x0200000B, { 73, 38 } },
	{ 0x0200000C, { 111, 4 } },
	{ 0x0200000D, { 115, 4 } },
	{ 0x0200000E, { 119, 12 } },
	{ 0x0200000F, { 131, 5 } },
	{ 0x02000018, { 147, 8 } },
	{ 0x02000028, { 155, 22 } },
	{ 0x0200002B, { 177, 5 } },
	{ 0x06000095, { 136, 1 } },
	{ 0x06000096, { 137, 2 } },
	{ 0x06000098, { 139, 2 } },
	{ 0x060000A2, { 141, 2 } },
	{ 0x060000A3, { 143, 2 } },
	{ 0x060000A9, { 145, 2 } },
	{ 0x0600014B, { 182, 8 } },
	{ 0x0600014D, { 190, 1 } },
	{ 0x0600014E, { 191, 1 } },
};
extern const uint32_t g_rgctx_List_1_tC5DC9490BA9C0273941967D1F904B76BDA00B3B6;
extern const uint32_t g_rgctx_List_1__ctor_m88E5F016A44DF4F327F99619D6D327BB9A69EA4E;
extern const uint32_t g_rgctx_ConnectionCollectionBase_4__ctor_m8FC1FBE849DB61E2F4290962B2D2E34C18870423;
extern const uint32_t g_rgctx_ConnectionCollectionBase_4_tE30CC11FA64F5E67D89261D90B93EA67BE043C11;
extern const uint32_t g_rgctx_Dictionary_2_tA36EEE4A8615ED2D0DF50550DBE53E05ABFC1CCA;
extern const uint32_t g_rgctx_Dictionary_2__ctor_m95AC8CD494534E1B0A10713A337A7C200CC61AAC;
extern const uint32_t g_rgctx_Dictionary_2_t1BFDBBA2AAE0CDAEFD63939B700C7F98FF8B1FA7;
extern const uint32_t g_rgctx_Dictionary_2__ctor_m0AD5F6CFB20C9DBF18E7BE30ADDD98CC9BC19A77;
extern const uint32_t g_rgctx_TCollection_t9BE12F005D94E539CA261D2E150A548EBAD62418;
extern const uint32_t g_rgctx_ICollection_1_tFFEEB0A5EF75A20977FDD928D90122F0D3D80A52;
extern const uint32_t g_rgctx_ICollection_1_get_Count_mAC07243BABC0B2E845A80970B4D1E5906E0E88E9;
extern const uint32_t g_rgctx_IEnumerable_1_t8E75A1A8671B3E7BE6DAAF478905B66241692CFE;
extern const uint32_t g_rgctx_IEnumerable_1_GetEnumerator_m5612F3E7A6D4F6C1E7E89FF4656A80933505DC9E;
extern const uint32_t g_rgctx_ConnectionCollectionBase_4_GetEnumerator_m9A0A064997C5DCE101F3CC8B40B36DC149C0A53F;
extern const uint32_t g_rgctx_ConnectionCollectionBase_4_WithSourceNoAlloc_m34A7D1B14E4FA598404E14E397945887B91EA042;
extern const uint32_t g_rgctx_EnsureThat_IsNotNull_TisTSource_tBA73678FE77D5A631C2CDFC0023FA60F1821B8DC_m81EBC6A9F17FD056A081A31F8BBE393E5A0C643E;
extern const uint32_t g_rgctx_Dictionary_2_TryGetValue_m4747CC800E742CF19E4D9918FC68027640290CDF;
extern const uint32_t g_rgctx_Empty_1_tB5E3B55283812381CAAA8A5B9E594A38C02FB12D;
extern const uint32_t g_rgctx_List_1_get_Count_m23B3E846E5BEC5425B013386B8033545D41D6C09;
extern const uint32_t g_rgctx_List_1_get_Item_m7CC03FC047A6E0781DDCC8FCD836B56003AFC545;
extern const uint32_t g_rgctx_ConnectionCollectionBase_4_WithDestinationNoAlloc_mBCECF5CF625695A152D03CDF4077CDB8DF91F435;
extern const uint32_t g_rgctx_EnsureThat_IsNotNull_TisTDestination_t254863805B27A67409E28E84B5C1F85B6909349A_m9A476EDB29F28BE73551DA477AA546BC52FD7BE4;
extern const uint32_t g_rgctx_Dictionary_2_TryGetValue_m4D6B2FB9C9E17C91188C67B0D98D5A0ADB6E9C44;
extern const uint32_t g_rgctx_TConnection_tCD84E644CFD147482E9F3BC055CC427A8AF8488F;
extern const uint32_t g_rgctx_IConnection_2_t04C548864136689E853C7756E2FC1C5D33ACDE81;
extern const uint32_t g_rgctx_IConnection_2_get_source_m92177B96C765543738C385D99779576A585301C6;
extern const uint32_t g_rgctx_TSource_tBA73678FE77D5A631C2CDFC0023FA60F1821B8DC;
extern const uint32_t g_rgctx_IConnection_2_get_destination_mF7812CD7D145B639F135FE10020B96FC7222EAFA;
extern const uint32_t g_rgctx_TDestination_t254863805B27A67409E28E84B5C1F85B6909349A;
extern const uint32_t g_rgctx_ConnectionCollectionBase_4_BeforeAdd_m005F1DD9195C6A50AB4D45CFC38D779C0B034999;
extern const uint32_t g_rgctx_ICollection_1_Add_m59302A8B087E47CAE4F21DF0DF88AD9C52EF9441;
extern const uint32_t g_rgctx_ConnectionCollectionBase_4_AddToDictionaries_m311EA534558D2FE3A9F5A82E144D2011320D8445;
extern const uint32_t g_rgctx_ConnectionCollectionBase_4_AfterAdd_mCD2C72048ECA1BAD7FAA8EDD87850B99539CB1F8;
extern const uint32_t g_rgctx_ICollection_1_Clear_m4F158C8C61E4B003BD9A03493A6A158E9A9F83F4;
extern const uint32_t g_rgctx_Dictionary_2_Clear_mEF0CB4AA2E3D652AF47DDBB802F8BD34CF62A648;
extern const uint32_t g_rgctx_Dictionary_2_Clear_mF1EA25E96978FD357386563961394F70EC410434;
extern const uint32_t g_rgctx_ICollection_1_Contains_m25AFA2746E3B37C4737DD5A046D48DAC32DF6AE8;
extern const uint32_t g_rgctx_ICollection_1_CopyTo_m883AAC80833598BD98AEC23321FED1E5891B9690;
extern const uint32_t g_rgctx_ConnectionCollectionBase_4_BeforeRemove_m6718ED145B0F7C2CD0B5AAC4CF61B5093EFF08C5;
extern const uint32_t g_rgctx_ICollection_1_Remove_m53BB1D90770833C94349191C2D49CE10A2C03E89;
extern const uint32_t g_rgctx_ConnectionCollectionBase_4_RemoveFromDictionaries_mF90C77B55EAB27BA40DB8A9928E0A8695425FCD3;
extern const uint32_t g_rgctx_ConnectionCollectionBase_4_AfterRemove_mD1FA7874E88E026547B14B17774154734853EC9D;
extern const uint32_t g_rgctx_Dictionary_2_ContainsKey_m3890389A631C989AFC654C9D35092DFBDAE4FE93;
extern const uint32_t g_rgctx_List_1_tABD682ACD947AC343ECFA62CC0547722B5C4D379;
extern const uint32_t g_rgctx_List_1__ctor_m0C0DD81B7BA3E91182CE774A22C988E8557284AC;
extern const uint32_t g_rgctx_Dictionary_2_Add_m8FD25AB616D3AD9AD7462B40818D2AC920BF8FA2;
extern const uint32_t g_rgctx_Dictionary_2_get_Item_mAD61DDCDCA7628E997868CDFA9C7E0A661D86596;
extern const uint32_t g_rgctx_List_1_Add_m6E0148EC8E59165C7C712303C9679B74618E685C;
extern const uint32_t g_rgctx_Dictionary_2_ContainsKey_m7D27A176460F79BEEBE42DE182F5A964377BFB63;
extern const uint32_t g_rgctx_Dictionary_2_Add_mE52A0ED0299112B72AC6ECA8E57AFF8C2E52BBCE;
extern const uint32_t g_rgctx_Dictionary_2_get_Item_m2DE4BC45B1CF4F84B03BF958EBDC6FAA0D146758;
extern const uint32_t g_rgctx_List_1_Remove_mC458EC8CFE458634FBA890480E7BC8ACF7FDC053;
extern const uint32_t g_rgctx_GraphElementCollection_1_t31AA3A2AEFE426BD9C31F06D27498A47BD48589E;
extern const uint32_t g_rgctx_GraphElementCollection_1__ctor_m70068200DA73EAE5DC465DD42CBCC2ED2EAB607C;
extern const uint32_t g_rgctx_ConnectionCollectionBase_4__ctor_m22635EB6195D4D7D542D774C28339386AB1D15C7;
extern const uint32_t g_rgctx_ConnectionCollectionBase_4_tF97703A3BFDB7FDCC49752751EAFEC78D5822575;
extern const uint32_t g_rgctx_GraphElementCollection_1_set_ProxyCollectionChange_mED365727CC2E73CC97E6BBF60479A0FA65A12C64;
extern const uint32_t g_rgctx_KeyedCollection_2_get_Item_mA7CC145CB4A062D947973018555229153AB8AAF2;
extern const uint32_t g_rgctx_Collection_1_get_Item_mEE9449B2C1678EB73157A0FBC76912DEFB8D9D59;
extern const uint32_t g_rgctx_GuidCollection_1_TryGetValue_mA3D58877538E0B41AD63C7D05415152180B22D2A;
extern const uint32_t g_rgctx_KeyedCollection_2_Contains_m4325474D46D878E0D5E5867675B84F4BD065B9B3;
extern const uint32_t g_rgctx_GraphConnectionCollection_3_Contains_m3C9CAF034380D3DCC62B6ECC8075FC0673A63311;
extern const uint32_t g_rgctx_ConnectionCollectionBase_4_Remove_m67A745634D896D35DB77113E350FF2C53A6620FE;
extern const uint32_t g_rgctx_GraphElementCollection_1_add_ItemAdded_mA416512C967976BCE34C6897AEC813E15A297FAC;
extern const uint32_t g_rgctx_GraphElementCollection_1_remove_ItemAdded_m0ABC2F5F07A4D84B07AF84EFAFDDE399E5AECD8A;
extern const uint32_t g_rgctx_GraphElementCollection_1_add_ItemRemoved_mC72F1A04810CE40E3546855BCE8FB24C4066AAA0;
extern const uint32_t g_rgctx_GraphElementCollection_1_remove_ItemRemoved_m0CBECECCF11DD0E2F725379D1BBA3097834308F6;
extern const uint32_t g_rgctx_GraphElementCollection_1_add_CollectionChanged_mD021C1AF2B9CF6A2B947749F43F7A881B73FB003;
extern const uint32_t g_rgctx_GraphElementCollection_1_remove_CollectionChanged_mF7A0DF1C3B94BA64F8A7760CFCAA651BCAE42E03;
extern const uint32_t g_rgctx_GraphElementCollection_1_BeforeAdd_mF0B88363E699914EF4CEF7B53C9DFAE53F1A4407;
extern const uint32_t g_rgctx_GraphElementCollection_1_AfterAdd_mE9D62FD6B9AECB317DE7F05F48FA180AAA225C20;
extern const uint32_t g_rgctx_GraphElementCollection_1_BeforeRemove_m9DB0E03719610D7408B07FA91E9B0DBF72DCD15A;
extern const uint32_t g_rgctx_GraphElementCollection_1_AfterRemove_mB63112C5043C30E9FA9BB9A8B305F14D6315796E;
extern const uint32_t g_rgctx_GuidCollection_1__ctor_mF7EDCA0EC9F4C44FD24D4B3EB648075645B2113C;
extern const uint32_t g_rgctx_GuidCollection_1_t7A19B45546B0A78B8516D334C477E07C3B5B8457;
extern const uint32_t g_rgctx_KeyedCollection_2_t9C994801D4B90F5DFC45A6502B8FCEBEF6CECFA1;
extern const uint32_t g_rgctx_Collection_1_tE0AF40D532630F4D37163BBE0FD4C582F59DCD26;
extern const uint32_t g_rgctx_Action_1_t988CEC32F3FE1A6ECAFE6B924B0DAD974E037DE2;
extern const uint32_t g_rgctx_Interlocked_CompareExchange_TisAction_1_t988CEC32F3FE1A6ECAFE6B924B0DAD974E037DE2_m131C4E055CB891E2727B92E39D4B7CA42C1817CE;
extern const uint32_t g_rgctx_TElement_t1C3427ACDDB69D498454F19718980BF835B5C96C;
extern const uint32_t g_rgctx_GraphElementCollection_1_get_graph_m6DBCD501752B3B9227E02435350B1DBA3AF4B046;
extern const uint32_t g_rgctx_Action_1_Invoke_m153CEF8738889C95162D9CF4B19DEA39DE6F125E;
extern const uint32_t g_rgctx_EnsureThat_IsNotNull_TisTElement_t1C3427ACDDB69D498454F19718980BF835B5C96C_mC441E0971459A12025953264B122F13356D14E82;
extern const uint32_t g_rgctx_GraphElementCollection_1_get_ProxyCollectionChange_mAD4A8CB0A88A3FBA9A2EE2153C6DBEFEF5A06C87;
extern const uint32_t g_rgctx_GraphElementCollection_1_BeforeAdd_mEF952A9BB0D8618045D1E44262BD5A9C3A6EE606;
extern const uint32_t g_rgctx_GuidCollection_1_InsertItem_m5B7F1184794ACAF034F9F3825229E50CC626379C;
extern const uint32_t g_rgctx_GraphElementCollection_1_AfterAdd_m371B3FF65869803944256037AF901578B8AF6FAD;
extern const uint32_t g_rgctx_Collection_1_get_Item_m2D3D5292164A85FAAD5268D66AEF96C1F7CBF378;
extern const uint32_t g_rgctx_Collection_1_Contains_m1F89AE090FD506477914E4EC3991DFD5E23AFF01;
extern const uint32_t g_rgctx_GraphElementCollection_1_BeforeRemove_mF50F8DB1787A8D742618B082494EC3641EED84DF;
extern const uint32_t g_rgctx_KeyedCollection_2_RemoveItem_m7682B8F07DBF3DADD4D9F7593860F19B43E6C8CC;
extern const uint32_t g_rgctx_GraphElementCollection_1_AfterRemove_m665979452CA6993D6D4625C4E5A2A09BF5C2AD50;
extern const uint32_t g_rgctx_ListPool_1_New_m5DB1BA47EA34D62932226544606DD9800C57DFD0;
extern const uint32_t g_rgctx_ListPool_1_tFB5FDAE0B7C3A5EBC2375C000754E20F70CAD0AC;
extern const uint32_t g_rgctx_GraphElementCollection_1_GetEnumerator_m0696B8A4598C39618077DE75FB71B2C4E0EDB608;
extern const uint32_t g_rgctx_NoAllocEnumerator_1_get_Current_mBFFDC27458953F1ECA92243A32B298F0B489018E;
extern const uint32_t g_rgctx_List_1_Add_m8DEB340B11AE581E08265053700ECF18D18D8ECB;
extern const uint32_t g_rgctx_NoAllocEnumerator_1_MoveNext_m26CAE0751DE4AB434DDEBA53DE7D1298C7AD19BF;
extern const uint32_t g_rgctx_NoAllocEnumerator_1_t8F26659D5E6825913A20DCA1ABE022DD3D90D4E9;
extern const uint32_t g_rgctx_U3CU3Ec_t15FD8ECC96403782E4EDA3CB6CDE929F1958D9B6;
extern const uint32_t g_rgctx_U3CU3Ec_U3CClearItemsU3Eb__23_0_mB337617FECC9068EA9D6B18BDA46132EC9868B28;
extern const uint32_t g_rgctx_Comparison_1_tD27D0466DED0A45E095A3F185A934D9AA231A797;
extern const uint32_t g_rgctx_Comparison_1__ctor_mCB5C8F1889576D27CCF028D71EBF43C44621C271;
extern const uint32_t g_rgctx_List_1_Sort_m69626FDF97206C59589E8808990AB6120FF15C3F;
extern const uint32_t g_rgctx_List_1_GetEnumerator_mFDF5391C091DF013591D5E07204EC7BD88751AD2;
extern const uint32_t g_rgctx_Enumerator_get_Current_mD36E8344B3813242222B44429FED561AC1CEC806;
extern const uint32_t g_rgctx_Collection_1_Remove_m0DCB7B53D9B36C86EE096B84110012192994701C;
extern const uint32_t g_rgctx_Enumerator_MoveNext_m53A7324978EB2227BA1A2903765058DB9B0D3B9F;
extern const uint32_t g_rgctx_Enumerator_t01CE1581A960188ED3B817D2796B0B1D44EBAA9D;
extern const uint32_t g_rgctx_ListPool_1_Free_m9DDDC76162097A659501D94164A74745EB03B0DC;
extern const uint32_t g_rgctx_NoAllocEnumerator_1__ctor_mA7720462F57433D21F1E7371E2333C32DA12FCD5;
extern const uint32_t g_rgctx_U3CU3Ec_tC234D8C01878B90BF45C840A93EE519577B2C2A6;
extern const uint32_t g_rgctx_U3CU3Ec__ctor_m474A9FF58D3713C7160E6186855DF0194CA8356B;
extern const uint32_t g_rgctx_U3CU3Ec_tC234D8C01878B90BF45C840A93EE519577B2C2A6;
extern const uint32_t g_rgctx_TElement_t7156B9B0CE661EF20C1DAB900ED29F0248B4162E;
extern const uint32_t g_rgctx_GraphData_1_get_elementsData_mCEBCE24D3B43627F764E8795CC47F184D6CE007C;
extern const uint32_t g_rgctx_GraphData_1_get_childrenGraphsData_mB80C0CF66EEAFF6F2FBCB1D27E4022540FB922A0;
extern const uint32_t g_rgctx_GraphData_1_get_phantomElementsData_m22E77C906D83452C74D72025E9D6EC21C42078D4;
extern const uint32_t g_rgctx_GraphData_1_get_phantomChildrenGraphsData_m8B3D0CB5A9CABCAA2968697AD9B8B6044C265058;
extern const uint32_t g_rgctx_GraphNest_2_get_source_m767CD904CEA83EF4A349914EC48DF67E6FB66944;
extern const uint32_t g_rgctx_GraphNest_2_BeforeGraphChange_mA107800B08FFF4A204053B94B138A0D3AD2FCAE4;
extern const uint32_t g_rgctx_GraphNest_2_AfterGraphChange_m2D35D1B7C854E7E010A4E928357128307B55E9F0;
extern const uint32_t g_rgctx_TMacro_t3B7E3C467C4466B89F33040A6C4A6E2CA4DB0B3E;
extern const uint32_t g_rgctx_GraphNest_2_get_macro_m1E3374E4D1E0B9067F0546B1B2050BD0D5F5FECC;
extern const uint32_t g_rgctx_TGraph_t0DA59FA108C92D732905D67F32E82331AFF7E0BD;
extern const uint32_t g_rgctx_GraphNest_2_get_embed_mEB0D5389E7A0223A212CC7FF8B56A6683446B613;
extern const uint32_t g_rgctx_Macro_1_get_graph_m846BAE668F397C3BC37C8998574F45207C6129BF;
extern const uint32_t g_rgctx_GraphNest_2_get_graph_mB162AE916CB5126965C12C7123F01CBDD80F94C7;
extern const uint32_t g_rgctx_GraphNest_2_get_nester_m3655BD0EDCE761FE10C97DEDD78FF0466596E800;
extern const uint32_t g_rgctx_U3Cget_deserializationDependenciesU3Ed__41_t1C9F2307B9EFB63F41E5B02CBED128823EFC62EA;
extern const uint32_t g_rgctx_U3Cget_deserializationDependenciesU3Ed__41__ctor_mF4F02A5AE88C1435769019390384281CDCE39BFB;
extern const uint32_t g_rgctx_GraphNest_2_get_macro_m03FD4ED9EF75388940728C5757D316D3AAE5A619;
extern const uint32_t g_rgctx_TMacro_t4197A37B9D66CD88D7593EC9A761F1E75FA452AB;
extern const uint32_t g_rgctx_U3Cget_deserializationDependenciesU3Ed__41_t72482C1DCA21CEF7B3F0204B4B1CEEDFDBECE8D6;
extern const uint32_t g_rgctx_U3Cget_deserializationDependenciesU3Ed__41__ctor_m9674B780B320DE4B7160073425FE225FAE8EBA6C;
extern const uint32_t g_rgctx_U3Cget_deserializationDependenciesU3Ed__41_System_Collections_Generic_IEnumerableU3CLudiq_ISerializationDependencyU3E_GetEnumerator_mF294CC8191D1F4C63CA0CF8E535BCD93A755BD17;
extern const uint32_t g_rgctx_T_t4045CA85906452277C5D8B5394B4B9EF70B7623C;
extern const uint32_t g_rgctx_GraphPointer_IsWithin_TisT_tFD01651CE8B7D5644E72B2BE20759F63CBA9A202_m7EB8A83288CA206EF7765B365B2B3CDA0E62B459;
extern const uint32_t g_rgctx_T_tFD01651CE8B7D5644E72B2BE20759F63CBA9A202;
extern const uint32_t g_rgctx_GraphPointer_EnsureWithin_TisT_t3F443F2DAF3635E5CB6C213CB02DEEF8D28E4ECF_m9A92A7DFE8AD422A21ED4A95C25B840DD2D2B81B;
extern const uint32_t g_rgctx_T_t3F443F2DAF3635E5CB6C213CB02DEEF8D28E4ECF;
extern const uint32_t g_rgctx_T_t0E88B13A7185FE75024E6E2CB4C5F0EFC477C82C;
extern const uint32_t g_rgctx_T_t0E88B13A7185FE75024E6E2CB4C5F0EFC477C82C;
extern const uint32_t g_rgctx_T_t0F85FC6E29E46A12E38DAE0B6763E336144824C4;
extern const uint32_t g_rgctx_T_t0F85FC6E29E46A12E38DAE0B6763E336144824C4;
extern const uint32_t g_rgctx_T_t3044808FF6FD67407ABE2BD3336C2435AD4B1F02;
extern const uint32_t g_rgctx_T_t3044808FF6FD67407ABE2BD3336C2435AD4B1F02;
extern const uint32_t g_rgctx_GraphElement_1_get_graph_m606066720BAD36AFBBC7AAE443BE246B5EDC67CF;
extern const uint32_t g_rgctx_TGraph_t213DFD7A794DACB28157F458EE5D508D48C4B689;
extern const uint32_t g_rgctx_GraphElement_1_Instantiate_m023C23C37E23A7473A87FCE57FCCB3E5BEF7842A;
extern const uint32_t g_rgctx_GraphElement_1_Uninstantiate_mA230E32046380DA4E27507C370889C0F957136A9;
extern const uint32_t g_rgctx_GraphElement_1_Dispose_mC434E94E97332DDCB5ED7E1BC82B37001373CC93;
extern const uint32_t g_rgctx_EnsureThat_IsOfType_TisTGraph_t213DFD7A794DACB28157F458EE5D508D48C4B689_m3AE6E8D472B74B275EBC4DCAB1102DF868CAA384;
extern const uint32_t g_rgctx_GraphElement_1_set_graph_mAB094AD2CD502E459B3884AC12156C71BBBA03E4;
extern const uint32_t g_rgctx_GraphElement_1_get_guid_mD32C5EFDC4CFC0EC357198C231A932EFCA22B6B9;
extern const uint32_t g_rgctx_GraphNest_2_tFDD6E5D8CA55D0C010712B9C1BCF851618BAB5A1;
extern const uint32_t g_rgctx_GraphNest_2__ctor_m7B7ED72DF577BA0DAC7571B8E4631A5D091D9925;
extern const uint32_t g_rgctx_Machine_2_get_nest_m44C046E2116B1E441D844A3EF456144214F57D5C;
extern const uint32_t g_rgctx_GraphNest_2_set_nester_m10EADD299B259B11C0E284C56818450CD30A1ED9;
extern const uint32_t g_rgctx_GraphNest_2_set_source_mA2E9BFA50172E9010EFB1ED0FD5097751F5CA969;
extern const uint32_t g_rgctx_Machine_2_get_reference_m0EF9E462593D0000D64E5D0DCE9E2D982CCB5EC5;
extern const uint32_t g_rgctx_GraphNest_2_get_graph_m9DD0803B85F66B936BCFAB18C6AD10827F271C75;
extern const uint32_t g_rgctx_GraphNest_2_get_source_m051527F775F8BDE5904E7DFC5FA42A624FACE4C2;
extern const uint32_t g_rgctx_GraphNest_2_get_macro_mEA2AFEFE5BC18340CB78A74CBE86BA0809142392;
extern const uint32_t g_rgctx_TMacro_t75C7934863AA5089C2FCE1B322602E64D454890A;
extern const uint32_t g_rgctx_Machine_2_get_graph_m056DF857E1DF61BA7F5014F7D62995251BF7E1DB;
extern const uint32_t g_rgctx_TGraph_t5ECBD26C857F1A288FF248F37DA287727B49E668;
extern const uint32_t g_rgctx_GraphNest_2_get_aotStubs_mBFA0FB42A268E75DA70F761D8A4F2A87370E13DC;
extern const uint32_t g_rgctx_Machine_2_CacheReference_mD7622A0E6CAAF585DF2AE7C7E676A36C269FB6DC;
extern const uint32_t g_rgctx_GraphNest_2_add_afterGraphChange_m58225896C8A7E36098221D781FBF5AAB8472DC30;
extern const uint32_t g_rgctx_Machine_2_ClearCachedReference_mBE31016BF8831E84F39544F573CC5CBF387E32CE;
extern const uint32_t g_rgctx_GraphNest_2_add_beforeGraphChange_m82B4FCDE66DEBE6A78B29B3C6BAB79C67E8CC5B4;
extern const uint32_t g_rgctx_Machine_2_InstantiateNest_m1034528F268500D2377A317A581552B7CFD2A10E;
extern const uint32_t g_rgctx_Machine_2_UninstantiateNest_m67515E302D67CC6449C74198AFBB6B8223B0AB36;
extern const uint32_t g_rgctx_Machine_2_OnInstantiateWhileEnabled_mDDFD5433941377239FAD89D071D689B549536200;
extern const uint32_t g_rgctx_Machine_2_OnUninstantiateWhileEnabled_m22659228ABD1B53FE97E7DD6C00B1AE0C1CC163E;
extern const uint32_t g_rgctx_Machine_2_DefaultGraph_mBF9307F3C03445A5009290ABD25313B785DF32CE;
extern const uint32_t g_rgctx_TGraph_tEAE5EFBC23B13DAA52B2E9E7E25C07155B9732A8;
extern const uint32_t g_rgctx_Macro_1_get_graph_mDB9FF186701204BDD1A08F2A728A496BE805CDEB;
extern const uint32_t g_rgctx_Macro_1_set_graph_mC5D6C7A099DF10BC03DD22D89AE71BBA7A20FD3B;
extern const uint32_t g_rgctx_Macro_1_DefaultGraph_m667BADB8155977BAF8CBEFC8E43F2E92F8E72CB5;
extern const uint32_t g_rgctx_Activator_CreateInstance_TisTGraph_tEAE5EFBC23B13DAA52B2E9E7E25C07155B9732A8_m5A6DAF0024EF0D3A3D5C705DA45A16EF810A7E08;
extern const uint32_t g_rgctx_MergedKeyedCollection_2_Include_TisTSubItem_t88BA60F9B6BDCBAEC79D8C0A63931B84CB616354_m34A6812EC890CE4F4475B3BBA7E3D1235613CD2B;
extern const uint32_t g_rgctx_IGraphElementCollection_1_t785F2651AFC93B87F57E3521DDBF51760C762FCD;
extern const uint32_t g_rgctx_MergedGraphElementCollection_U3CIncludeU3Eb__9_0_TisTSubItem_t88BA60F9B6BDCBAEC79D8C0A63931B84CB616354_m39EB866A92F3D74641FBE141C800C9A81C20EB5D;
extern const uint32_t g_rgctx_Action_1_tF1058867D049E206DF3B4ADDB36E31608B88B5D9;
extern const uint32_t g_rgctx_Action_1__ctor_m4C314F6C2D071858A7796D630F4DBE68BA0136D8;
extern const uint32_t g_rgctx_INotifyCollectionChanged_1_t0346602547D4618F37539D95FECBE199DE2118B7;
extern const uint32_t g_rgctx_MergedGraphElementCollection_U3CIncludeU3Eb__9_1_TisTSubItem_t88BA60F9B6BDCBAEC79D8C0A63931B84CB616354_mA813F8DD79EE9FA6D2D4537A6176D9F4A1B5ADB0;
extern const uint32_t g_rgctx_MergedGraphElementCollection_U3CIncludeU3Eb__9_2_TisTSubItem_t88BA60F9B6BDCBAEC79D8C0A63931B84CB616354_m183D235DF3E9399A392BAFCADD821A27E378CB23;
extern const uint32_t g_rgctx_TSubItem_t2E447E9CE60144EC71BC8A51A9BDCC1318BB5EA7;
extern const uint32_t g_rgctx_TSubItem_t3D957A760A813A5A2E9EFD841BDCB57ACC68ED39;
static const Il2CppRGCTXDefinition s_rgctxValues[192] = 
{
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_List_1_tC5DC9490BA9C0273941967D1F904B76BDA00B3B6 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_List_1__ctor_m88E5F016A44DF4F327F99619D6D327BB9A69EA4E },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_ConnectionCollectionBase_4__ctor_m8FC1FBE849DB61E2F4290962B2D2E34C18870423 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_ConnectionCollectionBase_4_tE30CC11FA64F5E67D89261D90B93EA67BE043C11 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Dictionary_2_tA36EEE4A8615ED2D0DF50550DBE53E05ABFC1CCA },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Dictionary_2__ctor_m95AC8CD494534E1B0A10713A337A7C200CC61AAC },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Dictionary_2_t1BFDBBA2AAE0CDAEFD63939B700C7F98FF8B1FA7 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Dictionary_2__ctor_m0AD5F6CFB20C9DBF18E7BE30ADDD98CC9BC19A77 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_TCollection_t9BE12F005D94E539CA261D2E150A548EBAD62418 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_ICollection_1_tFFEEB0A5EF75A20977FDD928D90122F0D3D80A52 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_ICollection_1_get_Count_mAC07243BABC0B2E845A80970B4D1E5906E0E88E9 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerable_1_t8E75A1A8671B3E7BE6DAAF478905B66241692CFE },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IEnumerable_1_GetEnumerator_m5612F3E7A6D4F6C1E7E89FF4656A80933505DC9E },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_ConnectionCollectionBase_4_GetEnumerator_m9A0A064997C5DCE101F3CC8B40B36DC149C0A53F },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_ConnectionCollectionBase_4_WithSourceNoAlloc_m34A7D1B14E4FA598404E14E397945887B91EA042 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_EnsureThat_IsNotNull_TisTSource_tBA73678FE77D5A631C2CDFC0023FA60F1821B8DC_m81EBC6A9F17FD056A081A31F8BBE393E5A0C643E },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Dictionary_2_TryGetValue_m4747CC800E742CF19E4D9918FC68027640290CDF },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Empty_1_tB5E3B55283812381CAAA8A5B9E594A38C02FB12D },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_List_1_get_Count_m23B3E846E5BEC5425B013386B8033545D41D6C09 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_List_1_get_Item_m7CC03FC047A6E0781DDCC8FCD836B56003AFC545 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_ConnectionCollectionBase_4_WithDestinationNoAlloc_mBCECF5CF625695A152D03CDF4077CDB8DF91F435 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_EnsureThat_IsNotNull_TisTDestination_t254863805B27A67409E28E84B5C1F85B6909349A_m9A476EDB29F28BE73551DA477AA546BC52FD7BE4 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Dictionary_2_TryGetValue_m4D6B2FB9C9E17C91188C67B0D98D5A0ADB6E9C44 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_TConnection_tCD84E644CFD147482E9F3BC055CC427A8AF8488F },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IConnection_2_t04C548864136689E853C7756E2FC1C5D33ACDE81 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IConnection_2_get_source_m92177B96C765543738C385D99779576A585301C6 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_TSource_tBA73678FE77D5A631C2CDFC0023FA60F1821B8DC },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IConnection_2_get_destination_mF7812CD7D145B639F135FE10020B96FC7222EAFA },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_TDestination_t254863805B27A67409E28E84B5C1F85B6909349A },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_ConnectionCollectionBase_4_BeforeAdd_m005F1DD9195C6A50AB4D45CFC38D779C0B034999 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_ICollection_1_Add_m59302A8B087E47CAE4F21DF0DF88AD9C52EF9441 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_ConnectionCollectionBase_4_AddToDictionaries_m311EA534558D2FE3A9F5A82E144D2011320D8445 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_ConnectionCollectionBase_4_AfterAdd_mCD2C72048ECA1BAD7FAA8EDD87850B99539CB1F8 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_ICollection_1_Clear_m4F158C8C61E4B003BD9A03493A6A158E9A9F83F4 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Dictionary_2_Clear_mEF0CB4AA2E3D652AF47DDBB802F8BD34CF62A648 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Dictionary_2_Clear_mF1EA25E96978FD357386563961394F70EC410434 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_ICollection_1_Contains_m25AFA2746E3B37C4737DD5A046D48DAC32DF6AE8 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_ICollection_1_CopyTo_m883AAC80833598BD98AEC23321FED1E5891B9690 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_ConnectionCollectionBase_4_BeforeRemove_m6718ED145B0F7C2CD0B5AAC4CF61B5093EFF08C5 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_ICollection_1_Remove_m53BB1D90770833C94349191C2D49CE10A2C03E89 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_ConnectionCollectionBase_4_RemoveFromDictionaries_mF90C77B55EAB27BA40DB8A9928E0A8695425FCD3 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_ConnectionCollectionBase_4_AfterRemove_mD1FA7874E88E026547B14B17774154734853EC9D },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Dictionary_2_ContainsKey_m3890389A631C989AFC654C9D35092DFBDAE4FE93 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_List_1_tABD682ACD947AC343ECFA62CC0547722B5C4D379 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_List_1__ctor_m0C0DD81B7BA3E91182CE774A22C988E8557284AC },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Dictionary_2_Add_m8FD25AB616D3AD9AD7462B40818D2AC920BF8FA2 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Dictionary_2_get_Item_mAD61DDCDCA7628E997868CDFA9C7E0A661D86596 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_List_1_Add_m6E0148EC8E59165C7C712303C9679B74618E685C },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Dictionary_2_ContainsKey_m7D27A176460F79BEEBE42DE182F5A964377BFB63 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Dictionary_2_Add_mE52A0ED0299112B72AC6ECA8E57AFF8C2E52BBCE },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Dictionary_2_get_Item_m2DE4BC45B1CF4F84B03BF958EBDC6FAA0D146758 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_List_1_Remove_mC458EC8CFE458634FBA890480E7BC8ACF7FDC053 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphElementCollection_1_t31AA3A2AEFE426BD9C31F06D27498A47BD48589E },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphElementCollection_1__ctor_m70068200DA73EAE5DC465DD42CBCC2ED2EAB607C },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_ConnectionCollectionBase_4__ctor_m22635EB6195D4D7D542D774C28339386AB1D15C7 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_ConnectionCollectionBase_4_tF97703A3BFDB7FDCC49752751EAFEC78D5822575 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphElementCollection_1_set_ProxyCollectionChange_mED365727CC2E73CC97E6BBF60479A0FA65A12C64 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_KeyedCollection_2_get_Item_mA7CC145CB4A062D947973018555229153AB8AAF2 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Collection_1_get_Item_mEE9449B2C1678EB73157A0FBC76912DEFB8D9D59 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GuidCollection_1_TryGetValue_mA3D58877538E0B41AD63C7D05415152180B22D2A },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_KeyedCollection_2_Contains_m4325474D46D878E0D5E5867675B84F4BD065B9B3 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphConnectionCollection_3_Contains_m3C9CAF034380D3DCC62B6ECC8075FC0673A63311 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_ConnectionCollectionBase_4_Remove_m67A745634D896D35DB77113E350FF2C53A6620FE },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphElementCollection_1_add_ItemAdded_mA416512C967976BCE34C6897AEC813E15A297FAC },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphElementCollection_1_remove_ItemAdded_m0ABC2F5F07A4D84B07AF84EFAFDDE399E5AECD8A },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphElementCollection_1_add_ItemRemoved_mC72F1A04810CE40E3546855BCE8FB24C4066AAA0 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphElementCollection_1_remove_ItemRemoved_m0CBECECCF11DD0E2F725379D1BBA3097834308F6 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphElementCollection_1_add_CollectionChanged_mD021C1AF2B9CF6A2B947749F43F7A881B73FB003 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphElementCollection_1_remove_CollectionChanged_mF7A0DF1C3B94BA64F8A7760CFCAA651BCAE42E03 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphElementCollection_1_BeforeAdd_mF0B88363E699914EF4CEF7B53C9DFAE53F1A4407 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphElementCollection_1_AfterAdd_mE9D62FD6B9AECB317DE7F05F48FA180AAA225C20 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphElementCollection_1_BeforeRemove_m9DB0E03719610D7408B07FA91E9B0DBF72DCD15A },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphElementCollection_1_AfterRemove_mB63112C5043C30E9FA9BB9A8B305F14D6315796E },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GuidCollection_1__ctor_mF7EDCA0EC9F4C44FD24D4B3EB648075645B2113C },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GuidCollection_1_t7A19B45546B0A78B8516D334C477E07C3B5B8457 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_KeyedCollection_2_t9C994801D4B90F5DFC45A6502B8FCEBEF6CECFA1 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Collection_1_tE0AF40D532630F4D37163BBE0FD4C582F59DCD26 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Action_1_t988CEC32F3FE1A6ECAFE6B924B0DAD974E037DE2 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Interlocked_CompareExchange_TisAction_1_t988CEC32F3FE1A6ECAFE6B924B0DAD974E037DE2_m131C4E055CB891E2727B92E39D4B7CA42C1817CE },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_TElement_t1C3427ACDDB69D498454F19718980BF835B5C96C },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphElementCollection_1_get_graph_m6DBCD501752B3B9227E02435350B1DBA3AF4B046 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Action_1_Invoke_m153CEF8738889C95162D9CF4B19DEA39DE6F125E },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_EnsureThat_IsNotNull_TisTElement_t1C3427ACDDB69D498454F19718980BF835B5C96C_mC441E0971459A12025953264B122F13356D14E82 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphElementCollection_1_get_ProxyCollectionChange_mAD4A8CB0A88A3FBA9A2EE2153C6DBEFEF5A06C87 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphElementCollection_1_BeforeAdd_mEF952A9BB0D8618045D1E44262BD5A9C3A6EE606 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GuidCollection_1_InsertItem_m5B7F1184794ACAF034F9F3825229E50CC626379C },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphElementCollection_1_AfterAdd_m371B3FF65869803944256037AF901578B8AF6FAD },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Collection_1_get_Item_m2D3D5292164A85FAAD5268D66AEF96C1F7CBF378 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Collection_1_Contains_m1F89AE090FD506477914E4EC3991DFD5E23AFF01 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphElementCollection_1_BeforeRemove_mF50F8DB1787A8D742618B082494EC3641EED84DF },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_KeyedCollection_2_RemoveItem_m7682B8F07DBF3DADD4D9F7593860F19B43E6C8CC },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphElementCollection_1_AfterRemove_m665979452CA6993D6D4625C4E5A2A09BF5C2AD50 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_ListPool_1_New_m5DB1BA47EA34D62932226544606DD9800C57DFD0 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_ListPool_1_tFB5FDAE0B7C3A5EBC2375C000754E20F70CAD0AC },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphElementCollection_1_GetEnumerator_m0696B8A4598C39618077DE75FB71B2C4E0EDB608 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_NoAllocEnumerator_1_get_Current_mBFFDC27458953F1ECA92243A32B298F0B489018E },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_List_1_Add_m8DEB340B11AE581E08265053700ECF18D18D8ECB },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_NoAllocEnumerator_1_MoveNext_m26CAE0751DE4AB434DDEBA53DE7D1298C7AD19BF },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_NoAllocEnumerator_1_t8F26659D5E6825913A20DCA1ABE022DD3D90D4E9 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3CU3Ec_t15FD8ECC96403782E4EDA3CB6CDE929F1958D9B6 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3CU3Ec_U3CClearItemsU3Eb__23_0_mB337617FECC9068EA9D6B18BDA46132EC9868B28 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Comparison_1_tD27D0466DED0A45E095A3F185A934D9AA231A797 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Comparison_1__ctor_mCB5C8F1889576D27CCF028D71EBF43C44621C271 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_List_1_Sort_m69626FDF97206C59589E8808990AB6120FF15C3F },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_List_1_GetEnumerator_mFDF5391C091DF013591D5E07204EC7BD88751AD2 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Enumerator_get_Current_mD36E8344B3813242222B44429FED561AC1CEC806 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Collection_1_Remove_m0DCB7B53D9B36C86EE096B84110012192994701C },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Enumerator_MoveNext_m53A7324978EB2227BA1A2903765058DB9B0D3B9F },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Enumerator_t01CE1581A960188ED3B817D2796B0B1D44EBAA9D },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_ListPool_1_Free_m9DDDC76162097A659501D94164A74745EB03B0DC },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_NoAllocEnumerator_1__ctor_mA7720462F57433D21F1E7371E2333C32DA12FCD5 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3CU3Ec_tC234D8C01878B90BF45C840A93EE519577B2C2A6 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3CU3Ec__ctor_m474A9FF58D3713C7160E6186855DF0194CA8356B },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3CU3Ec_tC234D8C01878B90BF45C840A93EE519577B2C2A6 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_TElement_t7156B9B0CE661EF20C1DAB900ED29F0248B4162E },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphData_1_get_elementsData_mCEBCE24D3B43627F764E8795CC47F184D6CE007C },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphData_1_get_childrenGraphsData_mB80C0CF66EEAFF6F2FBCB1D27E4022540FB922A0 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphData_1_get_phantomElementsData_m22E77C906D83452C74D72025E9D6EC21C42078D4 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphData_1_get_phantomChildrenGraphsData_m8B3D0CB5A9CABCAA2968697AD9B8B6044C265058 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphNest_2_get_source_m767CD904CEA83EF4A349914EC48DF67E6FB66944 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphNest_2_BeforeGraphChange_mA107800B08FFF4A204053B94B138A0D3AD2FCAE4 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphNest_2_AfterGraphChange_m2D35D1B7C854E7E010A4E928357128307B55E9F0 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_TMacro_t3B7E3C467C4466B89F33040A6C4A6E2CA4DB0B3E },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphNest_2_get_macro_m1E3374E4D1E0B9067F0546B1B2050BD0D5F5FECC },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_TGraph_t0DA59FA108C92D732905D67F32E82331AFF7E0BD },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphNest_2_get_embed_mEB0D5389E7A0223A212CC7FF8B56A6683446B613 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Macro_1_get_graph_m846BAE668F397C3BC37C8998574F45207C6129BF },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphNest_2_get_graph_mB162AE916CB5126965C12C7123F01CBDD80F94C7 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphNest_2_get_nester_m3655BD0EDCE761FE10C97DEDD78FF0466596E800 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3Cget_deserializationDependenciesU3Ed__41_t1C9F2307B9EFB63F41E5B02CBED128823EFC62EA },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3Cget_deserializationDependenciesU3Ed__41__ctor_mF4F02A5AE88C1435769019390384281CDCE39BFB },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphNest_2_get_macro_m03FD4ED9EF75388940728C5757D316D3AAE5A619 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_TMacro_t4197A37B9D66CD88D7593EC9A761F1E75FA452AB },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3Cget_deserializationDependenciesU3Ed__41_t72482C1DCA21CEF7B3F0204B4B1CEEDFDBECE8D6 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3Cget_deserializationDependenciesU3Ed__41__ctor_m9674B780B320DE4B7160073425FE225FAE8EBA6C },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_U3Cget_deserializationDependenciesU3Ed__41_System_Collections_Generic_IEnumerableU3CLudiq_ISerializationDependencyU3E_GetEnumerator_mF294CC8191D1F4C63CA0CF8E535BCD93A755BD17 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_T_t4045CA85906452277C5D8B5394B4B9EF70B7623C },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphPointer_IsWithin_TisT_tFD01651CE8B7D5644E72B2BE20759F63CBA9A202_m7EB8A83288CA206EF7765B365B2B3CDA0E62B459 },
	{ (Il2CppRGCTXDataType)1, (const Il2CppRGCTXDefinitionData *)&g_rgctx_T_tFD01651CE8B7D5644E72B2BE20759F63CBA9A202 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphPointer_EnsureWithin_TisT_t3F443F2DAF3635E5CB6C213CB02DEEF8D28E4ECF_m9A92A7DFE8AD422A21ED4A95C25B840DD2D2B81B },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_T_t3F443F2DAF3635E5CB6C213CB02DEEF8D28E4ECF },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_T_t0E88B13A7185FE75024E6E2CB4C5F0EFC477C82C },
	{ (Il2CppRGCTXDataType)1, (const Il2CppRGCTXDefinitionData *)&g_rgctx_T_t0E88B13A7185FE75024E6E2CB4C5F0EFC477C82C },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_T_t0F85FC6E29E46A12E38DAE0B6763E336144824C4 },
	{ (Il2CppRGCTXDataType)1, (const Il2CppRGCTXDefinitionData *)&g_rgctx_T_t0F85FC6E29E46A12E38DAE0B6763E336144824C4 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_T_t3044808FF6FD67407ABE2BD3336C2435AD4B1F02 },
	{ (Il2CppRGCTXDataType)1, (const Il2CppRGCTXDefinitionData *)&g_rgctx_T_t3044808FF6FD67407ABE2BD3336C2435AD4B1F02 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphElement_1_get_graph_m606066720BAD36AFBBC7AAE443BE246B5EDC67CF },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_TGraph_t213DFD7A794DACB28157F458EE5D508D48C4B689 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphElement_1_Instantiate_m023C23C37E23A7473A87FCE57FCCB3E5BEF7842A },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphElement_1_Uninstantiate_mA230E32046380DA4E27507C370889C0F957136A9 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphElement_1_Dispose_mC434E94E97332DDCB5ED7E1BC82B37001373CC93 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_EnsureThat_IsOfType_TisTGraph_t213DFD7A794DACB28157F458EE5D508D48C4B689_m3AE6E8D472B74B275EBC4DCAB1102DF868CAA384 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphElement_1_set_graph_mAB094AD2CD502E459B3884AC12156C71BBBA03E4 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphElement_1_get_guid_mD32C5EFDC4CFC0EC357198C231A932EFCA22B6B9 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphNest_2_tFDD6E5D8CA55D0C010712B9C1BCF851618BAB5A1 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphNest_2__ctor_m7B7ED72DF577BA0DAC7571B8E4631A5D091D9925 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Machine_2_get_nest_m44C046E2116B1E441D844A3EF456144214F57D5C },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphNest_2_set_nester_m10EADD299B259B11C0E284C56818450CD30A1ED9 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphNest_2_set_source_mA2E9BFA50172E9010EFB1ED0FD5097751F5CA969 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Machine_2_get_reference_m0EF9E462593D0000D64E5D0DCE9E2D982CCB5EC5 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphNest_2_get_graph_m9DD0803B85F66B936BCFAB18C6AD10827F271C75 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphNest_2_get_source_m051527F775F8BDE5904E7DFC5FA42A624FACE4C2 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphNest_2_get_macro_mEA2AFEFE5BC18340CB78A74CBE86BA0809142392 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_TMacro_t75C7934863AA5089C2FCE1B322602E64D454890A },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Machine_2_get_graph_m056DF857E1DF61BA7F5014F7D62995251BF7E1DB },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_TGraph_t5ECBD26C857F1A288FF248F37DA287727B49E668 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphNest_2_get_aotStubs_mBFA0FB42A268E75DA70F761D8A4F2A87370E13DC },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Machine_2_CacheReference_mD7622A0E6CAAF585DF2AE7C7E676A36C269FB6DC },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphNest_2_add_afterGraphChange_m58225896C8A7E36098221D781FBF5AAB8472DC30 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Machine_2_ClearCachedReference_mBE31016BF8831E84F39544F573CC5CBF387E32CE },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_GraphNest_2_add_beforeGraphChange_m82B4FCDE66DEBE6A78B29B3C6BAB79C67E8CC5B4 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Machine_2_InstantiateNest_m1034528F268500D2377A317A581552B7CFD2A10E },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Machine_2_UninstantiateNest_m67515E302D67CC6449C74198AFBB6B8223B0AB36 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Machine_2_OnInstantiateWhileEnabled_mDDFD5433941377239FAD89D071D689B549536200 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Machine_2_OnUninstantiateWhileEnabled_m22659228ABD1B53FE97E7DD6C00B1AE0C1CC163E },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Machine_2_DefaultGraph_mBF9307F3C03445A5009290ABD25313B785DF32CE },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_TGraph_tEAE5EFBC23B13DAA52B2E9E7E25C07155B9732A8 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Macro_1_get_graph_mDB9FF186701204BDD1A08F2A728A496BE805CDEB },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Macro_1_set_graph_mC5D6C7A099DF10BC03DD22D89AE71BBA7A20FD3B },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Macro_1_DefaultGraph_m667BADB8155977BAF8CBEFC8E43F2E92F8E72CB5 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Activator_CreateInstance_TisTGraph_tEAE5EFBC23B13DAA52B2E9E7E25C07155B9732A8_m5A6DAF0024EF0D3A3D5C705DA45A16EF810A7E08 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_MergedKeyedCollection_2_Include_TisTSubItem_t88BA60F9B6BDCBAEC79D8C0A63931B84CB616354_m34A6812EC890CE4F4475B3BBA7E3D1235613CD2B },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_IGraphElementCollection_1_t785F2651AFC93B87F57E3521DDBF51760C762FCD },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_MergedGraphElementCollection_U3CIncludeU3Eb__9_0_TisTSubItem_t88BA60F9B6BDCBAEC79D8C0A63931B84CB616354_m39EB866A92F3D74641FBE141C800C9A81C20EB5D },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Action_1_tF1058867D049E206DF3B4ADDB36E31608B88B5D9 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_Action_1__ctor_m4C314F6C2D071858A7796D630F4DBE68BA0136D8 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_INotifyCollectionChanged_1_t0346602547D4618F37539D95FECBE199DE2118B7 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_MergedGraphElementCollection_U3CIncludeU3Eb__9_1_TisTSubItem_t88BA60F9B6BDCBAEC79D8C0A63931B84CB616354_mA813F8DD79EE9FA6D2D4537A6176D9F4A1B5ADB0 },
	{ (Il2CppRGCTXDataType)3, (const Il2CppRGCTXDefinitionData *)&g_rgctx_MergedGraphElementCollection_U3CIncludeU3Eb__9_2_TisTSubItem_t88BA60F9B6BDCBAEC79D8C0A63931B84CB616354_m183D235DF3E9399A392BAFCADD821A27E378CB23 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_TSubItem_t2E447E9CE60144EC71BC8A51A9BDCC1318BB5EA7 },
	{ (Il2CppRGCTXDataType)2, (const Il2CppRGCTXDefinitionData *)&g_rgctx_TSubItem_t3D957A760A813A5A2E9EFD841BDCB57ACC68ED39 },
};
extern const CustomAttributesCacheGenerator g_Ludiq_Graphs_Runtime_AttributeGenerators[];
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_Ludiq_Graphs_Runtime_CodeGenModule;
const Il2CppCodeGenModule g_Ludiq_Graphs_Runtime_CodeGenModule = 
{
	"Ludiq.Graphs.Runtime.dll",
	335,
	s_methodPointers,
	0,
	NULL,
	s_InvokerIndices,
	0,
	NULL,
	20,
	s_rgctxIndices,
	192,
	s_rgctxValues,
	NULL,
	g_Ludiq_Graphs_Runtime_AttributeGenerators,
	NULL, // module initializer,
	NULL,
	NULL,
	NULL,
};
