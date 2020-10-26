cmake_minimum_required(VERSION 3.0.0)
project(ExchangeCppLayer VERSION 0.1.0)

set(CMAKE_CXX_STANDARD 11)
set(CMAKE_CXX_STANDARD_REQUIRED True)
add_library(ExchangeCppLayer SHARED ExchangeCppLayer.cpp)
set_target_properties(ExchangeCppLayer PROPERTIES PREFIX "" OUTPUT_NAME "Exchange" SUFFIX ".layer")
set(HOOPS_EXCHANGE_DIR "/opt/local/ts3d/HOOPS_Exchange_2020_SP2_U2")
if( NOT DEFINED HOOPS_EXCHANGE_DIR)
    message(FATAL_ERROR "You must set the HOOPS_EXCHANGE_DIR environment variable." )
endif()
target_include_directories(ExchangeCppLayer PUBLIC "${HOOPS_EXCHANGE_DIR}/include")

