
EXTRA_DIST =  Makefile

# Warning: This is an automatically generated file, do not edit!

srcdir=.
top_srcdir=..

include $(top_srcdir)/config.make

ifeq ($(CONFIG),DEBUG_X86)
ASSEMBLY_COMPILER_COMMAND = dmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize- -debug "-define:DEBUG;"
ASSEMBLY = bin/Debug/crisis.exe
ASSEMBLY_MDB = $(ASSEMBLY).mdb
COMPILE_TARGET = exe
PROJECT_REFERENCES = 
BUILD_DIR = bin/Debug

CRISIS_EXE_MDB_SOURCE=bin/Debug/crisis.exe.mdb
CRISIS_EXE_MDB=$(BUILD_DIR)/crisis.exe.mdb
C5_DLL_SOURCE=../packages/C5.1.0.2.0/lib/net35/C5.dll
PLOSSUM_COMMANDLINE_DLL_SOURCE=../packages/Plossum.CommandLine.0.3.0.14/lib/net35/Plossum\ CommandLine.dll

endif

ifeq ($(CONFIG),RELEASE_X86)
ASSEMBLY_COMPILER_COMMAND = dmcs
ASSEMBLY_COMPILER_FLAGS =  -noconfig -codepage:utf8 -warn:4 -optimize+
ASSEMBLY = bin/Release/crisis.exe
ASSEMBLY_MDB = 
COMPILE_TARGET = exe
PROJECT_REFERENCES = 
BUILD_DIR = bin/Release

CRISIS_EXE_MDB=
C5_DLL_SOURCE=../packages/C5.1.0.2.0/lib/net35/C5.dll
PLOSSUM_COMMANDLINE_DLL_SOURCE=../packages/Plossum.CommandLine.0.3.0.14/lib/net35/Plossum\ CommandLine.dll

endif

AL=al
SATELLITE_ASSEMBLY_NAME=$(notdir $(basename $(ASSEMBLY))).resources.dll

PROGRAMFILES = \
	$(CRISIS_EXE_MDB) \
	$(C5_DLL) \
	$(PLOSSUM_COMMANDLINE_DLL)  

BINARIES = \
	$(CRISIS)  


RESGEN=resgen2

C5_DLL = $(BUILD_DIR)/C5.dll
PLOSSUM_COMMANDLINE_DLL = $(BUILD_DIR)/Plossum\ CommandLine.dll
CRISIS = $(BUILD_DIR)/crisis

FILES = \
	AssemblyInfo.cs \
	Charset.cs \
	Combination.cs \
	Generate.cs \
	Help.cs \
	Program.cs \
	Command.cs \
	FilesNameDirectory.cs \
	MenuCMD/MenuDisplayCharset.cs \
	MenuCMD/Menu.cs \
	ProgressBar.cs 

DATA_FILES = 

RESOURCES = 

EXTRAS = \
	app.desktop \
	MenuCMD \
	crisis.in 

REFERENCES =  \
	System \
	System.Core

DLL_REFERENCES =  \
	../packages/C5.1.0.2.0/lib/net35/C5.dll \
	../packages/Plossum.CommandLine.0.3.0.14/lib/net35/Plossum\ CommandLine.dll

CLEANFILES = $(PROGRAMFILES) $(BINARIES) 

#Targets
all: $(ASSEMBLY) $(PROGRAMFILES) $(BINARIES)  $(top_srcdir)/config.make

include $(top_srcdir)/Makefile.include
#include $(srcdir)/custom-hooks.make



$(eval $(call emit-deploy-target,C5_DLL))
$(eval $(call emit-deploy-target,PLOSSUM_COMMANDLINE_DLL))
$(eval $(call emit-deploy-wrapper,CRISIS,crisis,x))


$(eval $(call emit_resgen_targets))
$(build_xamlg_list): %.xaml.g.cs: %.xaml
	xamlg '$<'


$(ASSEMBLY_MDB): $(ASSEMBLY)
$(ASSEMBLY): $(build_sources) $(build_resources) $(build_datafiles) $(DLL_REFERENCES) $(PROJECT_REFERENCES) $(build_xamlg_list) $(build_satellite_assembly_list)
	make pre-all-local-hook prefix=$(prefix)
	mkdir -p $(shell dirname $(ASSEMBLY))
	make $(CONFIG)_BeforeBuild
	$(ASSEMBLY_COMPILER_COMMAND) $(ASSEMBLY_COMPILER_FLAGS) -out:$(ASSEMBLY) -target:$(COMPILE_TARGET) $(build_sources_embed) $(build_resources_embed) $(build_references_ref)
	make $(CONFIG)_AfterBuild
	make post-all-local-hook prefix=$(prefix)

install-local: $(ASSEMBLY) $(ASSEMBLY_MDB)
	make pre-install-local-hook prefix=$(prefix)
	make install-satellite-assemblies prefix=$(prefix)
	mkdir -p '$(DESTDIR)$(libdir)/$(PACKAGE)'
	$(call cp,$(ASSEMBLY),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call cp,$(ASSEMBLY_MDB),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call cp,$(CRISIS_EXE_MDB),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call cp,$(C5_DLL),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call cp,$(PLOSSUM_COMMANDLINE_DLL),$(DESTDIR)$(libdir)/$(PACKAGE))
	mkdir -p '$(DESTDIR)$(bindir)'
	$(call cp,$(CRISIS),$(DESTDIR)$(bindir))
	make post-install-local-hook prefix=$(prefix)

uninstall-local: $(ASSEMBLY) $(ASSEMBLY_MDB)
	make pre-uninstall-local-hook prefix=$(prefix)
	make uninstall-satellite-assemblies prefix=$(prefix)
	$(call rm,$(ASSEMBLY),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call rm,$(ASSEMBLY_MDB),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call rm,$(CRISIS_EXE_MDB),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call rm,$(C5_DLL),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call rm,$(PLOSSUM_COMMANDLINE_DLL),$(DESTDIR)$(libdir)/$(PACKAGE))
	$(call rm,$(CRISIS),$(DESTDIR)$(bindir))
	make post-uninstall-local-hook prefix=$(prefix)

install: install-local
uninstall: uninstall-local
clean: clean-local

include $(top_srcdir)/rules.make
